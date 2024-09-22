using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class CurrentEventClient : BasicSpaceDataClient<Classes.CurrentEvent>
    {
        public CurrentEventClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "current_event")
        {
        }
    }
}