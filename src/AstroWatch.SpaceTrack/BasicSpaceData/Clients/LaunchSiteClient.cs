using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class LaunchSiteClient : BasicSpaceDataClient<Classes.LaunchSite>
    {
        public LaunchSiteClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "launch_site")
        {
        }
    }
}