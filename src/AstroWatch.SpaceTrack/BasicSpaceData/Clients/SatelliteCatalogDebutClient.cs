using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class SatelliteCatalogDebutClient : BasicSpaceDataClient<Classes.SatelliteCatalogDebut>
    {
        public SatelliteCatalogDebutClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "satcat_debut")
        {
        }
    }
}