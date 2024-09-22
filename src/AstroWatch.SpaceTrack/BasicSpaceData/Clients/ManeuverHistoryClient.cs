using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class ManeuverHistoryClient : BasicSpaceDataClient<Classes.ManeuverHistory>
    {
        public ManeuverHistoryClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "maneuver_history")
        {
        }
    }
}