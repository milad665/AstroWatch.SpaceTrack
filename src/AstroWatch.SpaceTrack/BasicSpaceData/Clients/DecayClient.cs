using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class DecayClient : BasicSpaceDataClient<Classes.Decay>
    {
        public DecayClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "decay")
        {
        }
    }
}