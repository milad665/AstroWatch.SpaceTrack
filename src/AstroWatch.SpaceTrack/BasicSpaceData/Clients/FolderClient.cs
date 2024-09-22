using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class FolderClient : BasicSpaceDataClient<Classes.Folder>
    {
        public FolderClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "folder")
        {
        }
    }
}