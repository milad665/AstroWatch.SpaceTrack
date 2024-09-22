using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class DeleteClient : BasicSpaceDataClient<Classes.Delete>
    {
        public DeleteClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "delete")
        {
        }
    }
}