using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class FileHistoryClient : BasicSpaceDataClient<Classes.FileHistory>
    {
        public FileHistoryClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "file_history")
        {
        }
    }
}