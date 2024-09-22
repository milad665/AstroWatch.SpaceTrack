using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class ManeuverClient : BasicSpaceDataClient<Classes.Maneuver>
    {
        public ManeuverClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "maneuver")
        {
        }
    }
}