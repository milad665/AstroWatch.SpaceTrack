using AstroWatch.SpaceTrack.BasicSpaceData.Clients;

namespace AstroWatch.SpaceTrack
{
    public interface ISpaceTrackPublicClient
    {
        AnnouncementClient Announcement { get; }
        BoxScoreClient BoxScore { get; }
        ConjunctionDataMessagePublicClient ConjunctionDataMessagePublic { get; }
        DecayClient Decay { get; }
        GeneralPerturbationsClient GeneralPerturbations { get; }
        GeneralPerturbationsHistoryClient GeneralPerturbationsHistory { get; }
        LaunchSiteClient LaunchSite { get; }
        SatelliteCatalogClient SatelliteCatalog { get; }
        SatelliteCatalogChangeClient SatelliteCatalogChange { get; }
        SatelliteCatalogDebutClient SatelliteCatalogDebut { get; }
        TrackingAndImpactPredictionClient TrackingAndImpactPrediction { get; }
    }
}