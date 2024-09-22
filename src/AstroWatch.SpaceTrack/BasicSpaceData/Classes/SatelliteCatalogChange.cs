using System;
using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    /// <summary>
    /// ~60 days of history showing changes for objects with changes in one of these values: INTLDES, NORAD_CAT_ID, SATNAME, COUNTRY, LAUNCH, or DECAY.
    /// </summary>
public class SatelliteCatalogChange : IBasicSpaceDataClass
{
    [PredicateName("NORAD_CAT_ID")]
    [JsonPropertyName("NORAD_CAT_ID")]
    [JsonConverter(typeof(StringToIntNullableConverter))]
    public int? NoradCatalogId { get; set; }

    [PredicateName("OBJECT_NUMBER")]
    [JsonPropertyName("OBJECT_NUMBER")]
    [JsonConverter(typeof(StringToIntNullableConverter))]
    public int? ObjectNumber { get; set; }

    [PredicateName("CURRENT_NAME")]
    [JsonPropertyName("CURRENT_NAME")]
    public string CurrentObjectName { get; set; }

    [PredicateName("PREVIOUS_NAME")]
    [JsonPropertyName("PREVIOUS_NAME")]
    public string? PreviousObjectName { get; set; }

    [PredicateName("CURRENT_INTLDES")]
    [JsonPropertyName("CURRENT_INTLDES")]
    public string CurrentInternationalDesignator { get; set; }

    [PredicateName("PREVIOUS_INTLDES")]
    [JsonPropertyName("PREVIOUS_INTLDES")]
    public string? PreviousInternationalDesignator { get; set; }

    [PredicateName("CURRENT_COUNTRY")]
    [JsonPropertyName("CURRENT_COUNTRY")]
    public string CurrentCountry { get; set; }

    [PredicateName("PREVIOUS_COUNTRY")]
    [JsonPropertyName("PREVIOUS_COUNTRY")]
    public string? PreviousCountry { get; set; }

    [PredicateName("CURRENT_LAUNCH")]
    [JsonPropertyName("CURRENT_LAUNCH")]
    [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
    public DateTime? CurrentLaunchDate { get; set; }

    [PredicateName("PREVIOUS_LAUNCH")]
    [JsonPropertyName("PREVIOUS_LAUNCH")]
    [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
    public DateTime? PreviousLaunchDate { get; set; }

    [PredicateName("CURRENT_DECAY")]
    [JsonPropertyName("CURRENT_DECAY")]
    [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
    public DateTime? CurrentDecayDate { get; set; }

    [PredicateName("PREVIOUS_DECAY")]
    [JsonPropertyName("PREVIOUS_DECAY")]
    [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
    public DateTime? PreviousDecayDate { get; set; }

    [PredicateName("CHANGE_MADE")]
    [JsonPropertyName("CHANGE_MADE")]
    [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
    public DateTime? ChangeMadeDate { get; set; }
}

}