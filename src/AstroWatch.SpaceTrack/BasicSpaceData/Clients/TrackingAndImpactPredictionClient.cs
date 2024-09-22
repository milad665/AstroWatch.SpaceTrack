using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class TrackingAndImpactPredictionClient : BasicSpaceDataClient<Classes.TrackingAndImpactPrediction>
    {
        public TrackingAndImpactPredictionClient(ISpaceTrackAuthenticator authenticator) : base(authenticator, "tip")
        {
        }
    }
}