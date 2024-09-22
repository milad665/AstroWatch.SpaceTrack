using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using AstroWatch.SpaceTrack.BasicSpaceData.Classes;
using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class SatelliteCatalogClient : BasicSpaceDataClient<SatelliteCatalog>
    {
        public SatelliteCatalogClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "satcat")
        {
        }
        
        public async Task<List<SatelliteCatalog>> GetAsSatelliteCatalogEntriesAsync()
        {
            var result = await GetAsStringAsync();
            return JsonSerializer.Deserialize<List<SatelliteCatalog>>(result);
        }
    }
}