using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class FilesTransferClient : BasicSpaceDataClient<Classes.FilesTransfer>
    {
        public FilesTransferClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "files_transfer")
        {
        }
    }
}