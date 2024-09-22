using System;
using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    public class CurrentEvent : IBasicSpaceDataClass
    {
        [PredicateName("event_id")]
        [JsonPropertyName("event_id")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? EventId { get; set; }

        [PredicateName("event_text")]
        [JsonPropertyName("event_text")]
        public string? EventText { get; set; }

        [PredicateName("event_creator_id")]
        [JsonPropertyName("event_creator_id")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? EventCreatorId { get; set; }

        [PredicateName("event_creator_uname")]
        [JsonPropertyName("event_creator_uname")]
        public string? EventCreatorUname { get; set; }

        [PredicateName("event_created")]
        [JsonPropertyName("event_created")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? EventCreated { get; set; }

        [PredicateName("event_display_start")]
        [JsonPropertyName("event_display_start")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? EventDisplayStart { get; set; }

        [PredicateName("event_display_end")]
        [JsonPropertyName("event_display_end")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? EventDisplayEnd { get; set; }

        [PredicateName("event_updater_id")]
        [JsonPropertyName("event_updater_id")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? EventUpdaterId { get; set; }

        [PredicateName("event_updater_uname")]
        [JsonPropertyName("event_updater_uname")]
        public string? EventUpdaterUname { get; set; }

        [PredicateName("event_updated")]
        [JsonPropertyName("event_updated")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? EventUpdated { get; set; }

        [PredicateName("event_active")]
        [JsonPropertyName("event_active")]
        [JsonConverter(typeof(StringToBooleanNullableConverter))]
        public bool? EventActive { get; set; }
    }
}