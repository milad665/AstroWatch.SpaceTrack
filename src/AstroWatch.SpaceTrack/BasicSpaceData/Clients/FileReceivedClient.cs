using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class FileReceivedClient : BasicSpaceDataClient<Classes.FileReceived>
    {
        public FileReceivedClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "file_received")
        {
        }
    }
}