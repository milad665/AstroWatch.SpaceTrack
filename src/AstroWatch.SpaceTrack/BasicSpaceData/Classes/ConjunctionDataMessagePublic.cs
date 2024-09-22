using System;
using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    public class ConjunctionDataMessagePublic : IBasicSpaceDataClass
    {
        [PredicateName("CDM_ID")]
        [JsonPropertyName("CDM_ID")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? CdmId { get; set; }

        [PredicateName("CREATED")]
        [JsonPropertyName("CREATED")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? Created { get; set; }

        [PredicateName("EMERGENCY_REPORTABLE")]
        [JsonPropertyName("EMERGENCY_REPORTABLE")]
        public string? EmergencyReportable { get; set; }

        [PredicateName("TCA")]
        [JsonPropertyName("TCA")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? TimeOfClosestApproach { get; set; }

        [PredicateName("MIN_RNG")]
        [JsonPropertyName("MIN_RNG")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? MinimumRange { get; set; }

        [PredicateName("PC")]
        [JsonPropertyName("PC")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? CollisionProbability { get; set; }

        [PredicateName("SAT_1_ID")]
        [JsonPropertyName("SAT_1_ID")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? Satellite1Id { get; set; }

        [PredicateName("SAT_1_NAME")]
        [JsonPropertyName("SAT_1_NAME")]
        public string? Satellite1Name { get; set; }

        [PredicateName("SAT1_OBJECT_TYPE")]
        [JsonPropertyName("SAT1_OBJECT_TYPE")]
        public string? Satellite1ObjectType { get; set; }

        [PredicateName("SAT1_RCS")]
        [JsonPropertyName("SAT1_RCS")]
        public string? Satellite1RadarCrossSection { get; set; }

        [PredicateName("SAT_1_EXCL_VOL")]
        [JsonPropertyName("SAT_1_EXCL_VOL")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite1ExclusionVolume { get; set; }

        [PredicateName("SAT_2_ID")]
        [JsonPropertyName("SAT_2_ID")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? Satellite2Id { get; set; }

        [PredicateName("SAT_2_NAME")]
        [JsonPropertyName("SAT_2_NAME")]
        public string? Satellite2Name { get; set; }

        [PredicateName("SAT2_OBJECT_TYPE")]
        [JsonPropertyName("SAT2_OBJECT_TYPE")]
        public string? Satellite2ObjectType { get; set; }

        [PredicateName("SAT2_RCS")]
        [JsonPropertyName("SAT2_RCS")]
        public string? Satellite2RadarCrossSection { get; set; }

        [PredicateName("SAT_2_EXCL_VOL")]
        [JsonPropertyName("SAT_2_EXCL_VOL")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite2ExclusionVolume { get; set; }
    }
}