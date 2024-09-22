using System;
using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    /// <summary>
    /// Tracking and Impact Prediction (TIP) Message. WINDOW shows precision of predicted decay time in minutes both before & after.
    /// NEXT_REPORT shows hours. LAT / LON values show the location 10Km above which an object is predicted to pass through at middle of the WINDOW, not the predicted Earth impact location.
    /// Message is nominally distributed at daily intervals beginning four days prior to selected objects' decay and several times during the final 24 hours in orbit.
    /// </summary>
    public class TrackingAndImpactPrediction : IBasicSpaceDataClass
    {
        [PredicateName("NORAD_CAT_ID")]
        [JsonPropertyName("NORAD_CAT_ID")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? NoradCatId { get; set; }

        [PredicateName("MSG_EPOCH")]
        [JsonPropertyName("MSG_EPOCH")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? MsgEpoch { get; set; }

        [PredicateName("INSERT_EPOCH")]
        [JsonPropertyName("INSERT_EPOCH")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? InsertEpoch { get; set; }

        [PredicateName("DECAY_EPOCH")]
        [JsonPropertyName("DECAY_EPOCH")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? DecayEpoch { get; set; }

        [PredicateName("WINDOW")]
        [JsonPropertyName("WINDOW")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Window { get; set; }

        [PredicateName("REV")]
        [JsonPropertyName("REV")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Rev { get; set; }

        [PredicateName("DIRECTION")]
        [JsonPropertyName("DIRECTION")]
        public string? Direction { get; set; }

        [PredicateName("LAT")]
        [JsonPropertyName("LAT")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Lat { get; set; }

        [PredicateName("LON")]
        [JsonPropertyName("LON")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Lon { get; set; }

        [PredicateName("INCL")]
        [JsonPropertyName("INCL")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Incl { get; set; }

        [PredicateName("NEXT_REPORT")]
        [JsonPropertyName("NEXT_REPORT")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int NextReport { get; set; }

        [PredicateName("ID")]
        [JsonPropertyName("ID")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Id { get; set; }

        [PredicateName("HIGH_INTEREST")]
        [JsonPropertyName("HIGH_INTEREST")]
        public string? HighInterest { get; set; }

        [PredicateName("OBJECT_NUMBER")]
        [JsonPropertyName("OBJECT_NUMBER")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? ObjectNumber { get; set; }

    }
}