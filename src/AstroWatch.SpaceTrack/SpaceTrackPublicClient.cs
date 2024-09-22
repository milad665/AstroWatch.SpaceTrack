using AstroWatch.SpaceTrack.BasicSpaceData.Clients;
using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack
{
    public class SpaceTrackPublicClient : ISpaceTrackPublicClient
    {
        private readonly ISpaceTrackAuthenticator _authenticator;

        public SpaceTrackPublicClient(ISpaceTrackAuthenticator authenticator)
        {
            _authenticator = authenticator;
            
            Announcement = new AnnouncementClient(authenticator);
            BoxScore = new BoxScoreClient(authenticator);
            ConjunctionDataMessagePublic = new ConjunctionDataMessagePublicClient(authenticator);
            Decay = new DecayClient(authenticator);
            GeneralPerturbations = new GeneralPerturbationsClient(authenticator);
            GeneralPerturbationsHistory = new GeneralPerturbationsHistoryClient(authenticator);
            LaunchSite = new LaunchSiteClient(authenticator);
            SatelliteCatalog = new SatelliteCatalogClient(authenticator);
            SatelliteCatalogChange = new SatelliteCatalogChangeClient(authenticator);
            SatelliteCatalogDebut = new SatelliteCatalogDebutClient(authenticator);
            TrackingAndImpactPrediction = new TrackingAndImpactPredictionClient(authenticator);
        }
        
        public AnnouncementClient Announcement { get; }
        public BoxScoreClient BoxScore { get; }
        public ConjunctionDataMessagePublicClient ConjunctionDataMessagePublic { get; }
        public DecayClient Decay { get; }
        public GeneralPerturbationsClient GeneralPerturbations { get; }
        public GeneralPerturbationsHistoryClient GeneralPerturbationsHistory { get; }
        public LaunchSiteClient LaunchSite { get; }
        public SatelliteCatalogClient SatelliteCatalog { get; }
        public SatelliteCatalogChangeClient SatelliteCatalogChange { get; }
        public SatelliteCatalogDebutClient SatelliteCatalogDebut { get; }
        public TrackingAndImpactPredictionClient TrackingAndImpactPrediction { get; }
    }
}