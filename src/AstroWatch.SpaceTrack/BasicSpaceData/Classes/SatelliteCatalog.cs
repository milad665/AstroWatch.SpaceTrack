using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    /// <summary>
    /// Satellite Catalog Information
    /// </summary>
    public class SatelliteCatalog : IBasicSpaceDataClass
    {
        public static List<SatelliteCatalog> FromJsonArray(string json) =>
            JsonSerializer.Deserialize<List<SatelliteCatalog>>(json);

        [PredicateName("INTLDES")]
        [JsonPropertyName("INTLDES")]
        public string? InternationalDesignator { get; set; }

        [PredicateName("NORAD_CAT_ID")]
        [JsonPropertyName("NORAD_CAT_ID")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? NoradCatalogId { get; set; }

        [PredicateName("OBJECT_TYPE")]
        [JsonPropertyName("OBJECT_TYPE")]
        public string? ObjectType { get; set; }

        [PredicateName("SATNAME")]
        [JsonPropertyName("SATNAME")]
        public string? SatelliteName { get; set; }

        [PredicateName("COUNTRY")]
        [JsonPropertyName("COUNTRY")]
        public string? Country { get; set; }

        [PredicateName("LAUNCH")]
        [JsonPropertyName("LAUNCH")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? LaunchDate { get; set; }

        [PredicateName("SITE")]
        [JsonPropertyName("SITE")]
        public string? LaunchSite { get; set; }

        [PredicateName("DECAY")]
        [JsonPropertyName("DECAY")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? DecayDate { get; set; }

        [PredicateName("PERIOD")]
        [JsonPropertyName("PERIOD")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? OrbitalPeriod { get; set; }

        [PredicateName("INCLINATION")]
        [JsonPropertyName("INCLINATION")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Inclination { get; set; }

        [PredicateName("APOGEE")]
        [JsonPropertyName("APOGEE")]
        [JsonConverter(typeof(StringToLongNullableConverter))]
        public long? ApogeeAltitude { get; set; }

        [PredicateName("PERIGEE")]
        [JsonPropertyName("PERIGEE")]
        [JsonConverter(typeof(StringToLongNullableConverter))]
        public long? PerigeeAltitude { get; set; }

        [PredicateName("COMMENT")]
        [JsonPropertyName("COMMENT")]
        public string? Comment { get; set; }

        [PredicateName("COMMENTCODE")]
        [JsonPropertyName("COMMENTCODE")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? CommentCode { get; set; }

        [PredicateName("RCSVALUE")]
        [JsonPropertyName("RCSVALUE")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? RadarCrossSectionValue { get; set; }

        [PredicateName("RCS_SIZE")]
        [JsonPropertyName("RCS_SIZE")]
        public string? RadarCrossSectionSize { get; set; }

        [PredicateName("FILE")]
        [JsonPropertyName("FILE")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? FileId { get; set; }

        [PredicateName("LAUNCH_YEAR")]
        [JsonPropertyName("LAUNCH_YEAR")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? LaunchYear { get; set; }

        [PredicateName("LAUNCH_NUM")]
        [JsonPropertyName("LAUNCH_NUM")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? LaunchNumber { get; set; }

        [PredicateName("LAUNCH_PIECE")]
        [JsonPropertyName("LAUNCH_PIECE")]
        public string? LaunchPiece { get; set; }

        [PredicateName("CURRENT")]
        [JsonPropertyName("CURRENT")]
        public string? CurrentStatus { get; set; }

        [PredicateName("OBJECT_NAME")]
        [JsonPropertyName("OBJECT_NAME")]
        public string? ObjectName { get; set; }

        [PredicateName("OBJECT_ID")]
        [JsonPropertyName("OBJECT_ID")]
        public string? ObjectId { get; set; }

        [PredicateName("OBJECT_NUMBER")]
        [JsonPropertyName("OBJECT_NUMBER")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? ObjectNumber { get; set; }
    }

}