using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class SatelliteCatalogChangeClient : BasicSpaceDataClient<Classes.SatelliteCatalogChange>
    {
        public SatelliteCatalogChangeClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "satcat_change")
        {
        }
    }
}