using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class AnnouncementClient : BasicSpaceDataClient<Classes.Announcement>
    {
        public AnnouncementClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "announcement")
        {
        }
    }
}