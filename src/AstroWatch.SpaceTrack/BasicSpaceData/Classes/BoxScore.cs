using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    public class BoxScore : IBasicSpaceDataClass
    {
        [PredicateName("COUNTRY")]
        [JsonPropertyName("COUNTRY")]
        public string? CountryName { get; set; }

        [PredicateName("SPADOC_CD")]
        [JsonPropertyName("SPADOC_CD")]
        public string? SpadocCode { get; set; }

        [PredicateName("ORBITAL_TBA")]
        [JsonPropertyName("ORBITAL_TBA")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? OrbitalToBeAssignedCount { get; set; }

        [PredicateName("ORBITAL_PAYLOAD_COUNT")]
        [JsonPropertyName("ORBITAL_PAYLOAD_COUNT")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? OrbitalPayloadCount { get; set; }

        [PredicateName("ORBITAL_ROCKET_BODY_COUNT")]
        [JsonPropertyName("ORBITAL_ROCKET_BODY_COUNT")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? OrbitalRocketBodyCount { get; set; }

        [PredicateName("ORBITAL_DEBRIS_COUNT")]
        [JsonPropertyName("ORBITAL_DEBRIS_COUNT")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? OrbitalDebrisCount { get; set; }

        [PredicateName("ORBITAL_TOTAL_COUNT")]
        [JsonPropertyName("ORBITAL_TOTAL_COUNT")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? OrbitalTotalCount { get; set; }

        [PredicateName("DECAYED_PAYLOAD_COUNT")]
        [JsonPropertyName("DECAYED_PAYLOAD_COUNT")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? DecayedPayloadCount { get; set; }

        [PredicateName("DECAYED_ROCKET_BODY_COUNT")]
        [JsonPropertyName("DECAYED_ROCKET_BODY_COUNT")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? DecayedRocketBodyCount { get; set; }

        [PredicateName("DECAYED_DEBRIS_COUNT")]
        [JsonPropertyName("DECAYED_DEBRIS_COUNT")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? DecayedDebrisCount { get; set; }

        [PredicateName("DECAYED_TOTAL_COUNT")]
        [JsonPropertyName("DECAYED_TOTAL_COUNT")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? DecayedTotalCount { get; set; }

        [PredicateName("COUNTRY_TOTAL")]
        [JsonPropertyName("COUNTRY_TOTAL")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? TotalCountryObjectsCount { get; set; }
    }

}