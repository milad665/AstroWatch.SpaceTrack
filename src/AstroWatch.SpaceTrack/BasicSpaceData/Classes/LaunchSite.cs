using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    public class LaunchSite : IBasicSpaceDataClass
    {
        [PredicateName("SITE_CODE")]
        [JsonPropertyName("SITE_CODE")]
        public string? SiteCode { get; set; }

        [PredicateName("LAUNCH_SITE")]
        [JsonPropertyName("LAUNCH_SITE")]
        public string? LaunchSiteName { get; set; }
    }

}