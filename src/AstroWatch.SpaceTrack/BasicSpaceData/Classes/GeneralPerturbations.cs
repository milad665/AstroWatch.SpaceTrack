using System;
using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
public class GeneralPerturbations : IBasicSpaceDataClass
{
    [PredicateName("CCSDS_OMM_VERS")]
    [JsonPropertyName("CCSDS_OMM_VERS")]
    public string? CcsdsOmmVersion { get; set; }

    [PredicateName("COMMENT")]
    [JsonPropertyName("COMMENT")]
    public string? Comment { get; set; }

    [PredicateName("CREATION_DATE")]
    [JsonPropertyName("CREATION_DATE")]
    [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
    public DateTime? CreationDate { get; set; }

    [PredicateName("ORIGINATOR")]
    [JsonPropertyName("ORIGINATOR")]
    public string? Originator { get; set; }

    [PredicateName("OBJECT_NAME")]
    [JsonPropertyName("OBJECT_NAME")]
    public string? ObjectName { get; set; }

    [PredicateName("OBJECT_ID")]
    [JsonPropertyName("OBJECT_ID")]
    public string? ObjectId { get; set; }

    [PredicateName("CENTER_NAME")]
    [JsonPropertyName("CENTER_NAME")]
    public string? CenterName { get; set; }

    [PredicateName("REF_FRAME")]
    [JsonPropertyName("REF_FRAME")]
    public string? ReferenceFrame { get; set; }

    [PredicateName("TIME_SYSTEM")]
    [JsonPropertyName("TIME_SYSTEM")]
    public string? TimeSystem { get; set; }

    [PredicateName("MEAN_ELEMENT_THEORY")]
    [JsonPropertyName("MEAN_ELEMENT_THEORY")]
    public string? MeanElementTheory { get; set; }

    [PredicateName("EPOCH")]
    [JsonPropertyName("EPOCH")]
    [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
    public DateTime? Epoch { get; set; }

    [PredicateName("MEAN_MOTION")]
    [JsonPropertyName("MEAN_MOTION")]
    [JsonConverter(typeof(StringToDoubleNullableConverter))]
    public double? MeanMotion { get; set; }

    [PredicateName("ECCENTRICITY")]
    [JsonPropertyName("ECCENTRICITY")]
    [JsonConverter(typeof(StringToDoubleNullableConverter))]
    public double? Eccentricity { get; set; }

    [PredicateName("INCLINATION")]
    [JsonPropertyName("INCLINATION")]
    [JsonConverter(typeof(StringToDoubleNullableConverter))]
    public double? Inclination { get; set; }

    [PredicateName("RA_OF_ASC_NODE")]
    [JsonPropertyName("RA_OF_ASC_NODE")]
    [JsonConverter(typeof(StringToDoubleNullableConverter))]
    public double? RightAscensionOfAscendingNode { get; set; }

    [PredicateName("ARG_OF_PERICENTER")]
    [JsonPropertyName("ARG_OF_PERICENTER")]
    [JsonConverter(typeof(StringToDoubleNullableConverter))]
    public double? ArgumentOfPericenter { get; set; }

    [PredicateName("MEAN_ANOMALY")]
    [JsonPropertyName("MEAN_ANOMALY")]
    [JsonConverter(typeof(StringToDoubleNullableConverter))]
    public double? MeanAnomaly { get; set; }

    [PredicateName("EPHEMERIS_TYPE")]
    [JsonPropertyName("EPHEMERIS_TYPE")]
    [JsonConverter(typeof(StringToIntNullableConverter))]
    public int? EphemerisType { get; set; }

    [PredicateName("CLASSIFICATION_TYPE")]
    [JsonPropertyName("CLASSIFICATION_TYPE")]
    public string? ClassificationType { get; set; }

    [PredicateName("NORAD_CAT_ID")]
    [JsonPropertyName("NORAD_CAT_ID")]
    [JsonConverter(typeof(StringToIntNullableConverter))]
    public int? NoradCatalogId { get; set; }

    [PredicateName("ELEMENT_SET_NO")]
    [JsonPropertyName("ELEMENT_SET_NO")]
    [JsonConverter(typeof(StringToIntNullableConverter))]
    public int? ElementSetNumber { get; set; }

    [PredicateName("REV_AT_EPOCH")]
    [JsonPropertyName("REV_AT_EPOCH")]
    [JsonConverter(typeof(StringToIntNullableConverter))]
    public int? RevolutionAtEpoch { get; set; }

    [PredicateName("BSTAR")]
    [JsonPropertyName("BSTAR")]
    [JsonConverter(typeof(StringToDoubleNullableConverter))]
    public double? BStar { get; set; }

    [PredicateName("MEAN_MOTION_DOT")]
    [JsonPropertyName("MEAN_MOTION_DOT")]
    [JsonConverter(typeof(StringToDoubleNullableConverter))]
    public double? MeanMotionDot { get; set; }

    [PredicateName("MEAN_MOTION_DDOT")]
    [JsonPropertyName("MEAN_MOTION_DDOT")]
    [JsonConverter(typeof(StringToDoubleNullableConverter))]
    public double? MeanMotionDoubleDot { get; set; }

    [PredicateName("SEMIMAJOR_AXIS")]
    [JsonPropertyName("SEMIMAJOR_AXIS")]
    [JsonConverter(typeof(StringToDoubleNullableConverter))]
    public double? SemiMajorAxis { get; set; }

    [PredicateName("PERIOD")]
    [JsonPropertyName("PERIOD")]
    [JsonConverter(typeof(StringToDoubleNullableConverter))]
    public double? OrbitalPeriod { get; set; }

    [PredicateName("APOAPSIS")]
    [JsonPropertyName("APOAPSIS")]
    [JsonConverter(typeof(StringToDoubleNullableConverter))]
    public double? Apoapsis { get; set; }

    [PredicateName("PERIAPSIS")]
    [JsonPropertyName("PERIAPSIS")]
    [JsonConverter(typeof(StringToDoubleNullableConverter))]
    public double? Periapsis { get; set; }

    [PredicateName("OBJECT_TYPE")]
    [JsonPropertyName("OBJECT_TYPE")]
    public string? ObjectType { get; set; }

    [PredicateName("RCS_SIZE")]
    [JsonPropertyName("RCS_SIZE")]
    public string? RadarCrossSectionSize { get; set; }

    [PredicateName("COUNTRY_CODE")]
    [JsonPropertyName("COUNTRY_CODE")]
    public string? CountryCode { get; set; }

    [PredicateName("LAUNCH_DATE")]
    [JsonPropertyName("LAUNCH_DATE")]
    [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
    public DateTime? LaunchDate { get; set; }

    [PredicateName("SITE")]
    [JsonPropertyName("SITE")]
    public string? LaunchSite { get; set; }

    [PredicateName("DECAY_DATE")]
    [JsonPropertyName("DECAY_DATE")]
    [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
    public DateTime? DecayDate { get; set; }

    [PredicateName("FILE")]
    [JsonPropertyName("FILE")]
    public string? File { get; set; }

    [PredicateName("GP_ID")]
    [JsonPropertyName("GP_ID")]
    [JsonConverter(typeof(StringToIntNullableConverter))]
    public int? GeneralPerturbationsId { get; set; }

    [PredicateName("TLE_LINE0")]
    [JsonPropertyName("TLE_LINE0")]
    public string? TleLine0 { get; set; }

    [PredicateName("TLE_LINE1")]
    [JsonPropertyName("TLE_LINE1")]
    public string? TleLine1 { get; set; }

    [PredicateName("TLE_LINE2")]
    [JsonPropertyName("TLE_LINE2")]
    public string? TleLine2 { get; set; }
}

}