using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using AstroWatch.SpaceTrack.BasicSpaceData.Classes;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Infrastructure;
using AstroWatch.SpaceTrack.Tle;

namespace AstroWatch.SpaceTrack.BasicSpaceData
{
    public abstract class BasicSpaceDataClient<TBasicSpaceDataClass> where TBasicSpaceDataClass : IBasicSpaceDataClass
    {
        private readonly List<PredicateQuery<TBasicSpaceDataClass>> _predicateQueries;
        private readonly ISpaceTrackAuthenticator _spaceTrackAuthenticator;
        private readonly string _className;
        
        protected BasicSpaceDataClient(ISpaceTrackAuthenticator authenticator, string className)
        {
            _spaceTrackAuthenticator = authenticator;
            _className = className;
            _predicateQueries = new List<PredicateQuery<TBasicSpaceDataClass>>();
        }

        public PredicateQuery<TBasicSpaceDataClass> FilterOn<TPredicate>(Expression<Func<TBasicSpaceDataClass, TPredicate>> expression)
        {
            if (expression.Body.NodeType != ExpressionType.MemberAccess)
                throw new InvalidExpressionException(
                    $"Expressoin not supported: '{expression.Body.NodeType}'. Only property access expressions are supported.");
            
            var mExp = expression.Body as MemberExpression;
            if (mExp.Expression != null &&
                mExp.Expression.Type.GetInterfaces().Any(i => i == typeof(IBasicSpaceDataClass)))
            {
                if (mExp.Member.CustomAttributes.All(m => m.AttributeType != typeof(PredicateNameAttribute) || m.ConstructorArguments.All(s => string.IsNullOrWhiteSpace(s.Value?.ToString()))))
                    throw new InvalidExpressionException(
                        $"Property {mExp.Member.Name} must have a predicate name associated to it using 'PredicateNameAttribute' which is not null or empty.");

                return new PredicateQuery<TBasicSpaceDataClass>(mExp.Member.CustomAttributes
                    .First(a => a.AttributeType == typeof(PredicateNameAttribute))
                    .ConstructorArguments[0].Value.ToString(), this);
            }

            throw new InvalidExpressionException(
                $"Expressoin not supported: '{expression.Body.NodeType}'. Only property access expressions are supported.");
        }

        public async Task<string> GetAsStringAsync() => await GetAsStringAsync(DefaultFormat);
        public async Task<string> GetAsJsonStringAsync() => await GetAsStringAsync(ResultFormats.Json);
        public async Task<string> GetAsXmlStringAsync() => await GetAsStringAsync(ResultFormats.Xml);
        public async Task<string> GetAsHtmlStringAsync() => await GetAsStringAsync(ResultFormats.Html);
        public async Task<string> GetAsTleStringAsync() => await GetAsStringAsync(ResultFormats.Tle3);
        public async Task<List<TBasicSpaceDataClass>> GetAsDeSerializedListAsync() => JsonSerializer.Deserialize<List<TBasicSpaceDataClass>>(await GetAsJsonStringAsync());
        public async Task<List<TleData>> GetAsTleDataAsync() => TleParser.ExtractTleSet(await GetAsTleStringAsync());
        public async Task<string> GetAsCsvStringAsync() => await GetAsStringAsync(ResultFormats.Csv);
        public async Task<string> GetAsCsvAsync(string fileNameToSave)
        {
            var csv = await GetAsCsvStringAsync();
            await using var f = System.IO.File.Create(fileNameToSave);
            await using var w = new StreamWriter(f);
            await w.WriteAsync(csv);
            return csv;
        }
        
        
        protected ResultFormats? DefaultFormat { get; set; }

        internal void AddQuery(PredicateQuery<TBasicSpaceDataClass> query)
        {
            if (_predicateQueries.Any(p => p.PredicateName.Equals(query.PredicateName)))
                throw new Exception("A predicate query for the same predicate already exists.");
            
            _predicateQueries.Add(query);
        }
        
        private async Task<string> GetAsStringAsync(ResultFormats? format)
        {
            var query = string.Concat(_predicateQueries.Select(q => q.Query));
            var result = await GetDataAsync(_className, query, format);
            _predicateQueries.Clear();
            return result;
        }
        
        private async Task<string> GetDataAsync(string spaceDataClass, string query, ResultFormats? format)
        {
            var frmtQuery = "";
            if (format.HasValue)
            {
                var frmt = Enum.GetName(typeof(ResultFormats), format).ToLower();
                if (format == ResultFormats.Tle3)
                    frmt = "3le";
                frmtQuery = $"/format/{frmt}";
            }
            
            var basicDataQueryUrl =
                $"{Settings.SpaceTracBaseUrl}/basicspacedata/query/class/{spaceDataClass}{query}{frmtQuery}";
            
            var cookie = await _spaceTrackAuthenticator.LoginAsync();
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Cookie", cookie);
            var response = await client.GetAsync(basicDataQueryUrl);
            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException($"Unable to get data from server. Status code: {response.StatusCode}");

            return await response.Content.ReadAsStringAsync();
        }
    }
}