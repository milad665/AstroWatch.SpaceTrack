using System;
using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    // Announcement Class
    public class Announcement : IBasicSpaceDataClass
    {
        [PredicateName("announcement_type")]
        [JsonPropertyName("announcement_type")]
        public string? AnnouncementType { get; set; }

        [PredicateName("announcement_text")]
        [JsonPropertyName("announcement_text")]
        public string? AnnouncementMessage { get; set; }

        [PredicateName("announcement_start")]
        [JsonPropertyName("announcement_start")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? AnnouncementStartTime { get; set; }

        [PredicateName("announcement_end")]
        [JsonPropertyName("announcement_end")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? AnnouncementEndTime { get; set; }
    }
}