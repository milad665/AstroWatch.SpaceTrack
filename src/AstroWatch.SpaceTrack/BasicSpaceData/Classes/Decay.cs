using System;
using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    public class Decay : IBasicSpaceDataClass
    {
        [PredicateName("NORAD_CAT_ID")]
        [JsonPropertyName("NORAD_CAT_ID")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? NoradCatalogId { get; set; }

        [PredicateName("OBJECT_NUMBER")]
        [JsonPropertyName("OBJECT_NUMBER")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? ObjectNumber { get; set; }

        [PredicateName("OBJECT_NAME")]
        [JsonPropertyName("OBJECT_NAME")]
        public string? ObjectName { get; set; }

        [PredicateName("INTLDES")]
        [JsonPropertyName("INTLDES")]
        public string? InternationalDesignator { get; set; }

        [PredicateName("OBJECT_ID")]
        [JsonPropertyName("OBJECT_ID")]
        public string? SpaceTrackObjectId { get; set; }

        [PredicateName("RCS")]
        [JsonPropertyName("RCS")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? RadarCrossSection { get; set; }

        [PredicateName("RCS_SIZE")]
        [JsonPropertyName("RCS_SIZE")]
        public string? RadarCrossSectionSize { get; set; }

        [PredicateName("COUNTRY")]
        [JsonPropertyName("COUNTRY")]
        public string? CountryOfOrigin { get; set; }

        [PredicateName("MSG_EPOCH")]
        [JsonPropertyName("MSG_EPOCH")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? MessageTimestamp { get; set; }

        [PredicateName("DECAY_EPOCH")]
        [JsonPropertyName("DECAY_EPOCH")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? DecayTimestamp { get; set; }

        [PredicateName("SOURCE")]
        [JsonPropertyName("SOURCE")]
        public string? SourceAgency { get; set; }

        [PredicateName("MSG_TYPE")]
        [JsonPropertyName("MSG_TYPE")]
        public string? MessageType { get; set; }

        [PredicateName("PRECEDENCE")]
        [JsonPropertyName("PRECEDENCE")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? MessagePrecedence { get; set; }
    }
}