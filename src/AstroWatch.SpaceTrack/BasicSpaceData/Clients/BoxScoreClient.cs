using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class BoxScoreClient : BasicSpaceDataClient<Classes.BoxScore>
    {
        public BoxScoreClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "boxscore")
        {
        }
    }
}