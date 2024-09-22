using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class GeneralPerturbationsHistoryClient : BasicSpaceDataClient<Classes.GeneralPerturbationsHistory>
    {
        public GeneralPerturbationsHistoryClient(ISpaceTrackAuthenticator authenticator) : base(authenticator,"gp_history")
        {
        }
    }
}