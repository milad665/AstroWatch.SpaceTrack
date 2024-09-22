using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class ConjunctionDataMessageClient : BasicSpaceDataClient<Classes.ConjunctionDataMessage>
    {
        public ConjunctionDataMessageClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "cdm")
        {
        }
    }
}