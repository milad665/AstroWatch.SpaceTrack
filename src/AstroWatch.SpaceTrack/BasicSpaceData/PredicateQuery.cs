using System.Linq;
using AstroWatch.SpaceTrack.BasicSpaceData.Classes;

namespace AstroWatch.SpaceTrack.BasicSpaceData
{
    public class PredicateQuery<TBasicSpaceDataClass> where TBasicSpaceDataClass : IBasicSpaceDataClass
    {
        private readonly BasicSpaceDataClient<TBasicSpaceDataClass> _spaceDataClient;

        internal PredicateQuery(string predicateName, BasicSpaceDataClient<TBasicSpaceDataClass> spaceDataClient)
        {
            PredicateName = predicateName;
            _spaceDataClient = spaceDataClient;
        }

        public BasicSpaceDataClient<TBasicSpaceDataClass> IsGreaterThan(PredicateValue value)
        {
            Query = $"/{PredicateName}/>{value}";
            _spaceDataClient.AddQuery(this);
            return _spaceDataClient;
        }
        
        public BasicSpaceDataClient<TBasicSpaceDataClass> IsLessThan(PredicateValue value)
        {
            Query = $"/{PredicateName}/<{value}";
            _spaceDataClient.AddQuery(this);
            return _spaceDataClient;
        }
        
        public BasicSpaceDataClient<TBasicSpaceDataClass> IsBetween(PredicateValue inclusiveMinimum, PredicateValue inclusiveMaximum)
        {
            Query = $"/{PredicateName}/{inclusiveMinimum}--{inclusiveMaximum}";
            _spaceDataClient.AddQuery(this);
            return _spaceDataClient;
        }
        
        public BasicSpaceDataClient<TBasicSpaceDataClass> IsEqualTo(params PredicateValue[] values)
        {
            Query = $"/{PredicateName}/{string.Join(',', values.Select(v => v.ToString()))}";
            _spaceDataClient.AddQuery(this);
            return _spaceDataClient;
        }
        
        public BasicSpaceDataClient<TBasicSpaceDataClass> IsNotEqualTo(PredicateValue value)
        {
            Query = $"/{PredicateName}/<>{value}";
            _spaceDataClient.AddQuery(this);
            return _spaceDataClient;
        }
        
        public BasicSpaceDataClient<TBasicSpaceDataClass> IsNotNull()
        {
            Query = $"/{PredicateName}/<>{PredicateValue.Null}";
            _spaceDataClient.AddQuery(this);
            return _spaceDataClient;
        }
        
        public BasicSpaceDataClient<TBasicSpaceDataClass> IsNull()
        {
            Query = $"/{PredicateName}/{PredicateValue.Null}";
            _spaceDataClient.AddQuery(this);
            return _spaceDataClient;
        }

        public string PredicateName { get; }
        public string Query { get; private set; }
    }
}