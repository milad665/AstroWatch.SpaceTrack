using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class CarClient : BasicSpaceDataClient<Classes.Car>
    {
        public CarClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "car")
        {
        }
    }
}