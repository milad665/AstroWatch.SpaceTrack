using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Security.Authentication;
using System.Threading.Tasks;
using AstroWatch.SpaceTrack.Common;
using Microsoft.Extensions.Options;

namespace AstroWatch.SpaceTrack.Infrastructure
{
    public class SpaceTrackAuthenticator : ISpaceTrackAuthenticator
    {
        private static string LoginUrl = $"{Settings.SpaceTracBaseUrl}/ajaxauth/login";
        private static IEnumerable<string> _cookie = null;
        private static DateTime _validUntil = DateTime.MinValue;
        private SpaceTrackSettings _spaceTrackSettings;

        public SpaceTrackAuthenticator(IOptions<SpaceTrackSettings> spaceTrackSettings)
        {
            _spaceTrackSettings = spaceTrackSettings.Value;
        }
        
        public SpaceTrackAuthenticator(SpaceTrackSettings spaceTrackSettings)
        {
            _spaceTrackSettings = spaceTrackSettings;
        }
        
        public async Task<IEnumerable<string>> LoginAsync()
        {
            if (_cookie != null && _validUntil > DateTime.UtcNow.AddMinutes(1))
                return _cookie;
            
            var client = new HttpClient();
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("identity", _spaceTrackSettings.Username),
                new KeyValuePair<string, string>("password", _spaceTrackSettings.Password)
            };
            var response = await client.PostAsync(LoginUrl, new FormUrlEncodedContent(parameters));
            if (!response.IsSuccessStatusCode)
                throw new AuthenticationException($"Unable to login. Status code: {response.StatusCode}");

            response.Headers.TryGetValues(("Set-Cookie"), out _cookie);
            UpdateValidUntil(_cookie);
            return _cookie;
        }

        private void UpdateValidUntil(IEnumerable<string> cookies)
        {
            var cookie = cookies.FirstOrDefault(c => c.Contains("expires="));
            if (string.IsNullOrWhiteSpace(cookie))
                return;

            try
            {
                var datestring = cookie.Split(';').First(p => p.Contains("expires")).Split('=')[1].Split(',')[1].Replace("GMT", "").Trim();
                _validUntil = DateTime.ParseExact(datestring, "dd-MMM-yyyy hh:mm:ss", CultureInfo.CurrentCulture);
            }
            catch (Exception e)
            {
            }
        }
    }
}