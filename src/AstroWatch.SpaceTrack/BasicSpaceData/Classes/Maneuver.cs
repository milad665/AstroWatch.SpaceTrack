using System;
using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    public class Maneuver : IBasicSpaceDataClass
    {
        [PredicateName("USER_DEFINED_RELEASABILITY")]
        [JsonPropertyName("USER_DEFINED_RELEASABILITY")]
        public string? UserDefinedReleasability { get; set; }

        [PredicateName("USER_DEFINED_CLASSIFICATION")]
        [JsonPropertyName("USER_DEFINED_CLASSIFICATION")]
        public string? UserDefinedClassification { get; set; }

        [PredicateName("USER_DEFINED_FILENAME")]
        [JsonPropertyName("USER_DEFINED_FILENAME")]
        public string? UserDefinedFilename { get; set; }

        [PredicateName("JSPOC_DEFINED_FILENAME")]
        [JsonPropertyName("JSPOC_DEFINED_FILENAME")]
        public string? JspocDefinedFilename { get; set; }

        [PredicateName("INSERT_EPOCH")]
        [JsonPropertyName("INSERT_EPOCH")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? InsertEpoch { get; set; }

        [PredicateName("CCSDS_OPM_VERS")]
        [JsonPropertyName("CCSDS_OPM_VERS")]
        public string? CcsdsOpmVersion { get; set; }

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

        [PredicateName("USER_DEFINED_NORAD_CAT_ID")]
        [JsonPropertyName("USER_DEFINED_NORAD_CAT_ID")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? UserDefinedNoradCatalogId { get; set; }

        [PredicateName("JSPOC_NORAD_CAT_ID")]
        [JsonPropertyName("JSPOC_NORAD_CAT_ID")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? JspocNoradCatalogId { get; set; }

        [PredicateName("MANEUVERABLE")]
        [JsonPropertyName("MANEUVERABLE")]
        public string? Maneuverable { get; set; }

        [PredicateName("ORBITAL_EPOCH")]
        [JsonPropertyName("ORBITAL_EPOCH")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? OrbitalEpoch { get; set; }

        [PredicateName("SEMI_MAJOR_AXIS")]
        [JsonPropertyName("SEMI_MAJOR_AXIS")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? SemiMajorAxis { get; set; }

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

        [PredicateName("MEAN_MOTION")]
        [JsonPropertyName("MEAN_MOTION")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? MeanMotion { get; set; }

        [PredicateName("EPOCH_JD")]
        [JsonPropertyName("EPOCH_JD")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? EpochJulianDate { get; set; }

        [PredicateName("MANEUVER_EPOCH")]
        [JsonPropertyName("MANEUVER_EPOCH")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? ManeuverEpoch { get; set; }

        [PredicateName("DELTA_V")]
        [JsonPropertyName("DELTA_V")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? DeltaV { get; set; }

        [PredicateName("DELTA_V_UNIT")]
        [JsonPropertyName("DELTA_V_UNIT")]
        public string? DeltaVUnit { get; set; }

        [PredicateName("DELTA_T")]
        [JsonPropertyName("DELTA_T")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? DeltaT { get; set; }

        [PredicateName("DELTA_T_UNIT")]
        [JsonPropertyName("DELTA_T_UNIT")]
        public string? DeltaTUnit { get; set; }

        [PredicateName("COMMENT")]
        [JsonPropertyName("COMMENT")]
        public string? Comment { get; set; }

        [PredicateName("MANEUVER_REASON")]
        [JsonPropertyName("MANEUVER_REASON")]
        public string? ManeuverReason { get; set; }

        [PredicateName("PREDICTION_SOURCE")]
        [JsonPropertyName("PREDICTION_SOURCE")]
        public string? PredictionSource { get; set; }

        [PredicateName("MANEUVER_TYPE")]
        [JsonPropertyName("MANEUVER_TYPE")]
        public string? ManeuverType { get; set; }

        [PredicateName("MANEUVER_DURATION")]
        [JsonPropertyName("MANEUVER_DURATION")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? ManeuverDuration { get; set; }

        [PredicateName("MANEUVER_DURATION_UNIT")]
        [JsonPropertyName("MANEUVER_DURATION_UNIT")]
        public string? ManeuverDurationUnit { get; set; }

        [PredicateName("MANEUVER_SUCCESSFUL")]
        [JsonPropertyName("MANEUVER_SUCCESSFUL")]
        public string? ManeuverSuccessful { get; set; }

        [PredicateName("OPERATOR_RESPONSE")]
        [JsonPropertyName("OPERATOR_RESPONSE")]
        public string? OperatorResponse { get; set; }

        [PredicateName("THRUST_ACCELERATION")]
        [JsonPropertyName("THRUST_ACCELERATION")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? ThrustAcceleration { get; set; }

        [PredicateName("THRUST_ACCELERATION_UNIT")]
        [JsonPropertyName("THRUST_ACCELERATION_UNIT")]
        public string? ThrustAccelerationUnit { get; set; }

        [PredicateName("ORBIT_REF_FRAME")]
        [JsonPropertyName("ORBIT_REF_FRAME")]
        public string? OrbitReferenceFrame { get; set; }

        [PredicateName("DELTA_V_VECTOR_X")]
        [JsonPropertyName("DELTA_V_VECTOR_X")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? DeltaVVectorX { get; set; }

        [PredicateName("DELTA_V_VECTOR_Y")]
        [JsonPropertyName("DELTA_V_VECTOR_Y")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? DeltaVVectorY { get; set; }

        [PredicateName("DELTA_V_VECTOR_Z")]
        [JsonPropertyName("DELTA_V_VECTOR_Z")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? DeltaVVectorZ { get; set; }

        [PredicateName("DELTA_V_MAGNITUDE")]
        [JsonPropertyName("DELTA_V_MAGNITUDE")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? DeltaVMagnitude { get; set; }

        [PredicateName("DELTA_V_MAGNITUDE_UNIT")]
        [JsonPropertyName("DELTA_V_MAGNITUDE_UNIT")]
        public string? DeltaVMagnitudeUnit { get; set; }
    }
}