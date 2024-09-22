using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Clients
{
    public class GeneralPerturbationsClient : BasicSpaceDataClient<Classes.GeneralPerturbations>
    {
        public GeneralPerturbationsClient(ISpaceTrackAuthenticator authenticator) : base(authenticator,"gp")
        {
            DefaultFormat = ResultFormats.Tle3;
        }
        
        public BasicSpaceDataClient<Classes.GeneralPerturbations> FilterLeo() => FilterOn(p => p.MeanMotion)
            .IsGreaterThan(11.25);

        public BasicSpaceDataClient<Classes.GeneralPerturbations> FilterGeoSync() => FilterOn(p => p.MeanMotion)
            .IsBetween(0.99, 1.01)
            .FilterOn(p => p.Eccentricity)
            .IsLessThan(0.01);
    }
}