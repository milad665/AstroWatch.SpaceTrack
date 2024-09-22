using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class FileClient : BasicSpaceDataClient<Classes.File>
    {
        public FileClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "file")
        {
        }
    }
}