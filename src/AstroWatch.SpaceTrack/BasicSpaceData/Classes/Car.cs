using System;
using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    public class Car : IBasicSpaceDataClass
    {
        [PredicateName("ORIGINATOR")]
        [JsonPropertyName("ORIGINATOR")]
        public string? OriginatingAgency { get; set; }

        [PredicateName("EPHEMERIS_FILE_UPLOAD")]
        [JsonPropertyName("EPHEMERIS_FILE_UPLOAD")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? EphemerisFileUploadDate { get; set; }

        [PredicateName("CREATION_DATE")]
        [JsonPropertyName("CREATION_DATE")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? CreationDate { get; set; }

        [PredicateName("INSERT_EPOCH")]
        [JsonPropertyName("INSERT_EPOCH")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? InsertionEpoch { get; set; }

        [PredicateName("OBJECT_DESIGNATOR")]
        [JsonPropertyName("OBJECT_DESIGNATOR")]
        public string? ObjectDesignator { get; set; }

        [PredicateName("INTERNATIONAL_DESIGNATOR")]
        [JsonPropertyName("INTERNATIONAL_DESIGNATOR")]
        public string? InternationalDesignator { get; set; }

        [PredicateName("ORG_ID")]
        [JsonPropertyName("ORG_ID")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? OrganizationId { get; set; }

        [PredicateName("CONSTELLATION")]
        [JsonPropertyName("CONSTELLATION")]
        public string? SatelliteConstellation { get; set; }

        [PredicateName("CA_RESULT_CODE")]
        [JsonPropertyName("CA_RESULT_CODE")]
        public string? ConjunctionAssessmentResultCode { get; set; }

        [PredicateName("CA_RESULT_SHORT_DESCRIPTION")]
        [JsonPropertyName("CA_RESULT_SHORT_DESCRIPTION")]
        public string? ConjunctionAssessmentResultDescription { get; set; }

        [PredicateName("SAT1_EPHEMERIS_NAME")]
        [JsonPropertyName("SAT1_EPHEMERIS_NAME")]
        public string? Satellite1EphemerisName { get; set; }

        [PredicateName("SAT2_EPHEMERIS_NAME")]
        [JsonPropertyName("SAT2_EPHEMERIS_NAME")]
        public string? Satellite2EphemerisName { get; set; }
    }
}