using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class ConjunctionDataMessagePublicClient : BasicSpaceDataClient<Classes.ConjunctionDataMessagePublic>
    {
        public ConjunctionDataMessagePublicClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "cdm_public")
        {
        }
    }
}