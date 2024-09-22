using System;
using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    public class ConjunctionDataMessage : IBasicSpaceDataClass
    {
        // General Message Properties
        [PredicateName("CDM_ID")]
        [JsonPropertyName("CDM_ID")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? ConjunctionDataMessageId { get; set; }

        [PredicateName("CONSTELLATION")]
        [JsonPropertyName("CONSTELLATION")]
        public string? SatelliteConstellation { get; set; }

        [PredicateName("FILENAME")]
        [JsonPropertyName("FILENAME")]
        public string? FileName { get; set; }

        [PredicateName("INSERT_EPOCH")]
        [JsonPropertyName("INSERT_EPOCH")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? InsertionTimestamp { get; set; }

        [PredicateName("CCSDS_CDM_VERS")]
        [JsonPropertyName("CCSDS_CDM_VERS")]
        public string? CcsdsCdmVersion { get; set; }

        [PredicateName("CREATION_DATE")]
        [JsonPropertyName("CREATION_DATE")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? CreationTimestamp { get; set; }

        [PredicateName("ORIGINATOR")]
        [JsonPropertyName("ORIGINATOR")]
        public string? OriginatorAgency { get; set; }

        [PredicateName("MESSAGE_FOR")]
        [JsonPropertyName("MESSAGE_FOR")]
        public string? IntendedRecipient { get; set; }

        [PredicateName("MESSAGE_ID")]
        [JsonPropertyName("MESSAGE_ID")]
        public string? MessageId { get; set; }

        [PredicateName("COMMENT_EMERGENCY_REPORTABLE")]
        [JsonPropertyName("COMMENT_EMERGENCY_REPORTABLE")]
        public string? EmergencyReportableComment { get; set; }

        [PredicateName("COMMENT_SCREENING_OPTION")]
        [JsonPropertyName("COMMENT_SCREENING_OPTION")]
        public string? ScreeningOptionComment { get; set; }

        [PredicateName("COMMENT_EFFECTIVE_HBR")]
        [JsonPropertyName("COMMENT_EFFECTIVE_HBR")]
        public string? HardBodyRadiusComment { get; set; }

        [PredicateName("TCA")]
        [JsonPropertyName("TCA")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? TimeOfClosestApproach { get; set; }

        [PredicateName("MISS_DISTANCE")]
        [JsonPropertyName("MISS_DISTANCE")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? MissDistance { get; set; }

        [PredicateName("MISS_DISTANCE_UNIT")]
        [JsonPropertyName("MISS_DISTANCE_UNIT")]
        public string? MissDistanceUnit { get; set; }

        [PredicateName("RELATIVE_SPEED")]
        [JsonPropertyName("RELATIVE_SPEED")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? RelativeSpeed { get; set; }

        [PredicateName("RELATIVE_SPEED_UNIT")]
        [JsonPropertyName("RELATIVE_SPEED_UNIT")]
        public string? RelativeSpeedUnit { get; set; }

        [PredicateName("RELATIVE_POSITION_R")]
        [JsonPropertyName("RELATIVE_POSITION_R")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? RelativePositionRadial { get; set; }

        [PredicateName("RELATIVE_POSITION_R_UNIT")]
        [JsonPropertyName("RELATIVE_POSITION_R_UNIT")]
        public string? RelativePositionRadialUnit { get; set; }

        [PredicateName("RELATIVE_POSITION_T")]
        [JsonPropertyName("RELATIVE_POSITION_T")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? RelativePositionTransverse { get; set; }

        [PredicateName("RELATIVE_POSITION_T_UNIT")]
        [JsonPropertyName("RELATIVE_POSITION_T_UNIT")]
        public string? RelativePositionTransverseUnit { get; set; }

        [PredicateName("RELATIVE_POSITION_N")]
        [JsonPropertyName("RELATIVE_POSITION_N")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? RelativePositionNormal { get; set; }

        [PredicateName("RELATIVE_POSITION_N_UNIT")]
        [JsonPropertyName("RELATIVE_POSITION_N_UNIT")]
        public string? RelativePositionNormalUnit { get; set; }

        [PredicateName("RELATIVE_VELOCITY_R")]
        [JsonPropertyName("RELATIVE_VELOCITY_R")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? RelativeVelocityRadial { get; set; }

        [PredicateName("RELATIVE_VELOCITY_R_UNIT")]
        [JsonPropertyName("RELATIVE_VELOCITY_R_UNIT")]
        public string? RelativeVelocityRadialUnit { get; set; }

        [PredicateName("RELATIVE_VELOCITY_T")]
        [JsonPropertyName("RELATIVE_VELOCITY_T")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? RelativeVelocityTransverse { get; set; }

        [PredicateName("RELATIVE_VELOCITY_T_UNIT")]
        [JsonPropertyName("RELATIVE_VELOCITY_T_UNIT")]
        public string? RelativeVelocityTransverseUnit { get; set; }

        [PredicateName("RELATIVE_VELOCITY_N")]
        [JsonPropertyName("RELATIVE_VELOCITY_N")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? RelativeVelocityNormal { get; set; }

        [PredicateName("RELATIVE_VELOCITY_N_UNIT")]
        [JsonPropertyName("RELATIVE_VELOCITY_N_UNIT")]
        public string? RelativeVelocityNormalUnit { get; set; }

        [PredicateName("COLLISION_PROBABILITY")]
        [JsonPropertyName("COLLISION_PROBABILITY")]
        public double? CollisionProbability { get; set; }

        [PredicateName("COLLISION_PROBABILITY_METHOD")]
        [JsonPropertyName("COLLISION_PROBABILITY_METHOD")]
        public string? CollisionProbabilityMethod { get; set; }

        [PredicateName("GID")]
        [JsonPropertyName("GID")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? GlobalIdentifier { get; set; }

        // SAT1 Properties
        [PredicateName("SAT1_OBJECT")]
        [JsonPropertyName("SAT1_OBJECT")]
        public string? Satellite1ObjectId { get; set; }

        [PredicateName("SAT1_OBJECT_DESIGNATOR")]
        [JsonPropertyName("SAT1_OBJECT_DESIGNATOR")]
        public string? Satellite1ObjectDesignator { get; set; }

        [PredicateName("SAT1_CATALOG_NAME")]
        [JsonPropertyName("SAT1_CATALOG_NAME")]
        public string? Satellite1CatalogName { get; set; }

        [PredicateName("SAT1_OBJECT_NAME")]
        [JsonPropertyName("SAT1_OBJECT_NAME")]
        public string? Satellite1ObjectName { get; set; }

        [PredicateName("SAT1_INTERNATIONAL_DESIGNATOR")]
        [JsonPropertyName("SAT1_INTERNATIONAL_DESIGNATOR")]
        public string? Satellite1InternationalDesignator { get; set; }

        [PredicateName("SAT1_OBJECT_TYPE")]
        [JsonPropertyName("SAT1_OBJECT_TYPE")]
        public string? Satellite1ObjectType { get; set; }

        [PredicateName("SAT1_OPERATOR_CONTACT_POSITION")]
        [JsonPropertyName("SAT1_OPERATOR_CONTACT_POSITION")]
        public string? Satellite1OperatorContactPosition { get; set; }

        [PredicateName("SAT1_OPERATOR_ORGANIZATION")]
        [JsonPropertyName("SAT1_OPERATOR_ORGANIZATION")]
        public string? Satellite1OperatorOrganization { get; set; }

        [PredicateName("SAT1_OPERATOR_PHONE")]
        [JsonPropertyName("SAT1_OPERATOR_PHONE")]
        public string? Satellite1OperatorPhone { get; set; }

        [PredicateName("SAT1_OPERATOR_EMAIL")]
        [JsonPropertyName("SAT1_OPERATOR_EMAIL")]
        public string? Satellite1OperatorEmail { get; set; }

        [PredicateName("SAT1_EPHEMERIS_NAME")]
        [JsonPropertyName("SAT1_EPHEMERIS_NAME")]
        public string? Satellite1EphemerisName { get; set; }

        [PredicateName("SAT1_COVARIANCE_METHOD")]
        [JsonPropertyName("SAT1_COVARIANCE_METHOD")]
        public string? Satellite1CovarianceMethod { get; set; }

        [PredicateName("SAT1_MANEUVERABLE")]
        [JsonPropertyName("SAT1_MANEUVERABLE")]
        public string? Satellite1Maneuverable { get; set; }

        [PredicateName("SAT1_REF_FRAME")]
        [JsonPropertyName("SAT1_REF_FRAME")]
        public string? Satellite1ReferenceFrame { get; set; }

        [PredicateName("SAT1_GRAVITY_MODEL")]
        [JsonPropertyName("SAT1_GRAVITY_MODEL")]
        public string? Satellite1GravityModel { get; set; }

        [PredicateName("SAT1_ATMOSPHERIC_MODEL")]
        [JsonPropertyName("SAT1_ATMOSPHERIC_MODEL")]
        public string? Satellite1AtmosphericModel { get; set; }

        [PredicateName("SAT1_N_BODY_PERTURBATIONS")]
        [JsonPropertyName("SAT1_N_BODY_PERTURBATIONS")]
        public string? Satellite1NBodyPerturbations { get; set; }

        [PredicateName("SAT1_SOLAR_RAD_PRESSURE")]
        [JsonPropertyName("SAT1_SOLAR_RAD_PRESSURE")]
        public string? Satellite1SolarRadiationPressure { get; set; }

        [PredicateName("SAT1_EARTH_TIDES")]
        [JsonPropertyName("SAT1_EARTH_TIDES")]
        public string? Satellite1EarthTides { get; set; }

        [PredicateName("SAT1_INTRACK_THRUST")]
        [JsonPropertyName("SAT1_INTRACK_THRUST")]
        public string? Satellite1IntrackThrust { get; set; }

        [PredicateName("SAT1_COMMENT_COVARIANCE_SCALE_FACTOR")]
        [JsonPropertyName("SAT1_COMMENT_COVARIANCE_SCALE_FACTOR")]
        public string? Satellite1CovarianceScaleFactorComment { get; set; }

        [PredicateName("SAT1_COMMENT_EXCLUSION_VOLUME_RADIUS")]
        [JsonPropertyName("SAT1_COMMENT_EXCLUSION_VOLUME_RADIUS")]
        public string? Satellite1ExclusionVolumeRadiusComment { get; set; }

        [PredicateName("SAT1_TIME_LASTOB_START")]
        [JsonPropertyName("SAT1_TIME_LASTOB_START")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? Satellite1LastObservationStart { get; set; }

        [PredicateName("SAT1_TIME_LASTOB_END")]
        [JsonPropertyName("SAT1_TIME_LASTOB_END")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? Satellite1LastObservationEnd { get; set; }

        [PredicateName("SAT1_RECOMMENDED_OD_SPAN")]
        [JsonPropertyName("SAT1_RECOMMENDED_OD_SPAN")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite1RecommendedObservationDuration { get; set; }

        [PredicateName("SAT1_RECOMMENDED_OD_SPAN_UNIT")]
        [JsonPropertyName("SAT1_RECOMMENDED_OD_SPAN_UNIT")]
        public string? Satellite1RecommendedObservationDurationUnit { get; set; }

        [PredicateName("SAT1_ACTUAL_OD_SPAN")]
        [JsonPropertyName("SAT1_ACTUAL_OD_SPAN")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite1ActualObservationDuration { get; set; }

        [PredicateName("SAT1_ACTUAL_OD_SPAN_UNIT")]
        [JsonPropertyName("SAT1_ACTUAL_OD_SPAN_UNIT")]
        public string? Satellite1ActualObservationDurationUnit { get; set; }

        [PredicateName("SAT1_OBS_AVAILABLE")]
        [JsonPropertyName("SAT1_OBS_AVAILABLE")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? Satellite1ObservationsAvailable { get; set; }

        [PredicateName("SAT1_OBS_USED")]
        [JsonPropertyName("SAT1_OBS_USED")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? Satellite1ObservationsUsed { get; set; }

        [PredicateName("SAT1_TRACKS_AVAILABLE")]
        [JsonPropertyName("SAT1_TRACKS_AVAILABLE")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? Satellite1TrackingDataAvailable { get; set; }

        [PredicateName("SAT1_TRACKS_USED")]
        [JsonPropertyName("SAT1_TRACKS_USED")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? Satellite1TrackingDataUsed { get; set; }

        [PredicateName("SAT1_RESIDUALS_ACCEPTED")]
        [JsonPropertyName("SAT1_RESIDUALS_ACCEPTED")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite1AcceptedResiduals { get; set; }

        [PredicateName("SAT1_RESIDUALS_ACCEPTED_UNIT")]
        [JsonPropertyName("SAT1_RESIDUALS_ACCEPTED_UNIT")]
        public string? Satellite1AcceptedResidualsUnit { get; set; }

        [PredicateName("SAT1_WEIGHTED_RMS")]
        [JsonPropertyName("SAT1_WEIGHTED_RMS")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite1WeightedRms { get; set; }

        [PredicateName("SAT1_COMMENT_APOGEE")]
        [JsonPropertyName("SAT1_COMMENT_APOGEE")]
        public string? Satellite1ApogeeComment { get; set; }

        [PredicateName("SAT1_COMMENT_PERIGEE")]
        [JsonPropertyName("SAT1_COMMENT_PERIGEE")]
        public string? Satellite1PerigeeComment { get; set; }

        [PredicateName("SAT1_COMMENT_INCLINATION")]
        [JsonPropertyName("SAT1_COMMENT_INCLINATION")]
        public string? Satellite1InclinationComment { get; set; }

        [PredicateName("SAT1_COMMENT_OPERATOR_HARD_BODY_RADIUS")]
        [JsonPropertyName("SAT1_COMMENT_OPERATOR_HARD_BODY_RADIUS")]
        public string? Satellite1OperatorHardBodyRadiusComment { get; set; }

        [PredicateName("SAT1_AREA_PC")]
        [JsonPropertyName("SAT1_AREA_PC")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite1PhysicalCrossSectionalArea { get; set; }

        [PredicateName("SAT1_AREA_PC_UNIT")]
        [JsonPropertyName("SAT1_AREA_PC_UNIT")]
        public string? Satellite1PhysicalCrossSectionalAreaUnit { get; set; }

        [PredicateName("SAT1_CD_AREA_OVER_MASS")]
        [JsonPropertyName("SAT1_CD_AREA_OVER_MASS")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite1DragCoefficientAreaOverMass { get; set; }

        [PredicateName("SAT1_CD_AREA_OVER_MASS_UNIT")]
        [JsonPropertyName("SAT1_CD_AREA_OVER_MASS_UNIT")]
        public string? Satellite1DragCoefficientAreaOverMassUnit { get; set; }

        [PredicateName("SAT1_CR_AREA_OVER_MASS")]
        [JsonPropertyName("SAT1_CR_AREA_OVER_MASS")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite1RadiationPressureAreaOverMass { get; set; }

        [PredicateName("SAT1_CR_AREA_OVER_MASS_UNIT")]
        [JsonPropertyName("SAT1_CR_AREA_OVER_MASS_UNIT")]
        public string? Satellite1RadiationPressureAreaOverMassUnit { get; set; }

        [PredicateName("SAT1_THRUST_ACCELERATION")]
        [JsonPropertyName("SAT1_THRUST_ACCELERATION")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite1ThrustAcceleration { get; set; }

        [PredicateName("SAT1_THRUST_ACCELERATION_UNIT")]
        [JsonPropertyName("SAT1_THRUST_ACCELERATION_UNIT")]
        public string? Satellite1ThrustAccelerationUnit { get; set; }

        [PredicateName("SAT1_SEDR")]
        [JsonPropertyName("SAT1_SEDR")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite1Sedr { get; set; }

        [PredicateName("SAT1_SEDR_UNIT")]
        [JsonPropertyName("SAT1_SEDR_UNIT")]
        public string? Satellite1SedrUnit { get; set; }

        [PredicateName("SAT1_X")]
        [JsonPropertyName("SAT1_X")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite1XPosition { get; set; }

        [PredicateName("SAT1_X_UNIT")]
        [JsonPropertyName("SAT1_X_UNIT")]
        public string? Satellite1XPositionUnit { get; set; }

        [PredicateName("SAT1_Y")]
        [JsonPropertyName("SAT1_Y")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite1YPosition { get; set; }

        [PredicateName("SAT1_Y_UNIT")]
        [JsonPropertyName("SAT1_Y_UNIT")]
        public string? Satellite1YPositionUnit { get; set; }

        [PredicateName("SAT1_Z")]
        [JsonPropertyName("SAT1_Z")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite1ZPosition { get; set; }

        [PredicateName("SAT1_Z_UNIT")]
        [JsonPropertyName("SAT1_Z_UNIT")]
        public string? Satellite1ZPositionUnit { get; set; }

        [PredicateName("SAT1_X_DOT")]
        [JsonPropertyName("SAT1_X_DOT")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite1XVelocity { get; set; }

        [PredicateName("SAT1_X_DOT_UNIT")]
        [JsonPropertyName("SAT1_X_DOT_UNIT")]
        public string? Satellite1XVelocityUnit { get; set; }

        [PredicateName("SAT1_Y_DOT")]
        [JsonPropertyName("SAT1_Y_DOT")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite1YVelocity { get; set; }

        [PredicateName("SAT1_Y_DOT_UNIT")]
        [JsonPropertyName("SAT1_Y_DOT_UNIT")]
        public string? Satellite1YVelocityUnit { get; set; }

        [PredicateName("SAT1_Z_DOT")]
        [JsonPropertyName("SAT1_Z_DOT")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite1ZVelocity { get; set; }

        [PredicateName("SAT1_Z_DOT_UNIT")]
        [JsonPropertyName("SAT1_Z_DOT_UNIT")]
        public string? Satellite1ZVelocityUnit { get; set; }

        [PredicateName("SAT1_COMMENT_DCP_DENSITY_FORECAST_UNCERTAINTY")]
        [JsonPropertyName("SAT1_COMMENT_DCP_DENSITY_FORECAST_UNCERTAINTY")]
        public string? Satellite1DcpDensityForecastUncertaintyComment { get; set; }

        [PredicateName("SAT1_COMMENT_DCP_SENSITIVITY_VECTOR_POSITION")]
        [JsonPropertyName("SAT1_COMMENT_DCP_SENSITIVITY_VECTOR_POSITION")]
        public string? Satellite1DcpSensitivityVectorPositionComment { get; set; }

        [PredicateName("SAT1_COMMENT_DCP_SENSITIVITY_VECTOR_VELOCITY")]
        [JsonPropertyName("SAT1_COMMENT_DCP_SENSITIVITY_VECTOR_VELOCITY")]
        public string? Satellite1DcpSensitivityVectorVelocityComment { get; set; }

        // SAT2 Properties
        [PredicateName("SAT2_COMMENT_SCREENING_DATA_SOURCE")]
        [JsonPropertyName("SAT2_COMMENT_SCREENING_DATA_SOURCE")]
        public string? Satellite2ScreeningDataSourceComment { get; set; }
        
        [PredicateName("SAT2_OBJECT")]
        [JsonPropertyName("SAT2_OBJECT")]
        public string? Satellite2ObjectId { get; set; }

        [PredicateName("SAT2_OBJECT_DESIGNATOR")]
        [JsonPropertyName("SAT2_OBJECT_DESIGNATOR")]
        public string? Satellite2ObjectDesignator { get; set; }

        [PredicateName("SAT2_CATALOG_NAME")]
        [JsonPropertyName("SAT2_CATALOG_NAME")]
        public string? Satellite2CatalogName { get; set; }

        [PredicateName("SAT2_OBJECT_NAME")]
        [JsonPropertyName("SAT2_OBJECT_NAME")]
        public string? Satellite2ObjectName { get; set; }

        [PredicateName("SAT2_INTERNATIONAL_DESIGNATOR")]
        [JsonPropertyName("SAT2_INTERNATIONAL_DESIGNATOR")]
        public string? Satellite2InternationalDesignator { get; set; }

        [PredicateName("SAT2_OBJECT_TYPE")]
        [JsonPropertyName("SAT2_OBJECT_TYPE")]
        public string? Satellite2ObjectType { get; set; }

        [PredicateName("SAT2_OPERATOR_CONTACT_POSITION")]
        [JsonPropertyName("SAT2_OPERATOR_CONTACT_POSITION")]
        public string? Satellite2OperatorContactPosition { get; set; }

        [PredicateName("SAT2_OPERATOR_ORGANIZATION")]
        [JsonPropertyName("SAT2_OPERATOR_ORGANIZATION")]
        public string? Satellite2OperatorOrganization { get; set; }

        [PredicateName("SAT2_OPERATOR_PHONE")]
        [JsonPropertyName("SAT2_OPERATOR_PHONE")]
        public string? Satellite2OperatorPhone { get; set; }

        [PredicateName("SAT2_OPERATOR_EMAIL")]
        [JsonPropertyName("SAT2_OPERATOR_EMAIL")]
        public string? Satellite2OperatorEmail { get; set; }

        [PredicateName("SAT2_EPHEMERIS_NAME")]
        [JsonPropertyName("SAT2_EPHEMERIS_NAME")]
        public string? Satellite2EphemerisName { get; set; }

        [PredicateName("SAT2_COVARIANCE_METHOD")]
        [JsonPropertyName("SAT2_COVARIANCE_METHOD")]
        public string? Satellite2CovarianceMethod { get; set; }

        [PredicateName("SAT2_MANEUVERABLE")]
        [JsonPropertyName("SAT2_MANEUVERABLE")]
        public string? Satellite2Maneuverable { get; set; }

        [PredicateName("SAT2_REF_FRAME")]
        [JsonPropertyName("SAT2_REF_FRAME")]
        public string? Satellite2ReferenceFrame { get; set; }

        [PredicateName("SAT2_GRAVITY_MODEL")]
        [JsonPropertyName("SAT2_GRAVITY_MODEL")]
        public string? Satellite2GravityModel { get; set; }

        [PredicateName("SAT2_ATMOSPHERIC_MODEL")]
        [JsonPropertyName("SAT2_ATMOSPHERIC_MODEL")]
        public string? Satellite2AtmosphericModel { get; set; }

        [PredicateName("SAT2_N_BODY_PERTURBATIONS")]
        [JsonPropertyName("SAT2_N_BODY_PERTURBATIONS")]
        public string? Satellite2NBodyPerturbations { get; set; }

        [PredicateName("SAT2_SOLAR_RAD_PRESSURE")]
        [JsonPropertyName("SAT2_SOLAR_RAD_PRESSURE")]
        public string? Satellite2SolarRadiationPressure { get; set; }

        [PredicateName("SAT2_EARTH_TIDES")]
        [JsonPropertyName("SAT2_EARTH_TIDES")]
        public string? Satellite2EarthTides { get; set; }

        [PredicateName("SAT2_INTRACK_THRUST")]
        [JsonPropertyName("SAT2_INTRACK_THRUST")]
        public string? Satellite2IntrackThrust { get; set; }

        [PredicateName("SAT2_COMMENT_COVARIANCE_SCALE_FACTOR")]
        [JsonPropertyName("SAT2_COMMENT_COVARIANCE_SCALE_FACTOR")]
        public string? Satellite2CovarianceScaleFactorComment { get; set; }

        [PredicateName("SAT2_COMMENT_EXCLUSION_VOLUME_RADIUS")]
        [JsonPropertyName("SAT2_COMMENT_EXCLUSION_VOLUME_RADIUS")]
        public string? Satellite2ExclusionVolumeRadiusComment { get; set; }

        [PredicateName("SAT2_TIME_LASTOB_START")]
        [JsonPropertyName("SAT2_TIME_LASTOB_START")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? Satellite2LastObservationStart { get; set; }

        [PredicateName("SAT2_TIME_LASTOB_END")]
        [JsonPropertyName("SAT2_TIME_LASTOB_END")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? Satellite2LastObservationEnd { get; set; }

        [PredicateName("SAT2_RECOMMENDED_OD_SPAN")]
        [JsonPropertyName("SAT2_RECOMMENDED_OD_SPAN")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite2RecommendedObservationDuration { get; set; }

        [PredicateName("SAT2_RECOMMENDED_OD_SPAN_UNIT")]
        [JsonPropertyName("SAT2_RECOMMENDED_OD_SPAN_UNIT")]
        public string? Satellite2RecommendedObservationDurationUnit { get; set; }

        [PredicateName("SAT2_ACTUAL_OD_SPAN")]
        [JsonPropertyName("SAT2_ACTUAL_OD_SPAN")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite2ActualObservationDuration { get; set; }

        [PredicateName("SAT2_ACTUAL_OD_SPAN_UNIT")]
        [JsonPropertyName("SAT2_ACTUAL_OD_SPAN_UNIT")]
        public string? Satellite2ActualObservationDurationUnit { get; set; }

        [PredicateName("SAT2_OBS_AVAILABLE")]
        [JsonPropertyName("SAT2_OBS_AVAILABLE")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? Satellite2ObservationsAvailable { get; set; }

        [PredicateName("SAT2_OBS_USED")]
        [JsonPropertyName("SAT2_OBS_USED")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? Satellite2ObservationsUsed { get; set; }

        [PredicateName("SAT2_TRACKS_AVAILABLE")]
        [JsonPropertyName("SAT2_TRACKS_AVAILABLE")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? Satellite2TrackingDataAvailable { get; set; }

        [PredicateName("SAT2_TRACKS_USED")]
        [JsonPropertyName("SAT2_TRACKS_USED")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? Satellite2TrackingDataUsed { get; set; }

        [PredicateName("SAT2_RESIDUALS_ACCEPTED")]
        [JsonPropertyName("SAT2_RESIDUALS_ACCEPTED")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite2AcceptedResiduals { get; set; }

        [PredicateName("SAT2_RESIDUALS_ACCEPTED_UNIT")]
        [JsonPropertyName("SAT2_RESIDUALS_ACCEPTED_UNIT")]
        public string? Satellite2AcceptedResidualsUnit { get; set; }

        [PredicateName("SAT2_WEIGHTED_RMS")]
        [JsonPropertyName("SAT2_WEIGHTED_RMS")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite2WeightedRms { get; set; }

        [PredicateName("SAT2_COMMENT_APOGEE")]
        [JsonPropertyName("SAT2_COMMENT_APOGEE")]
        public string? Satellite2ApogeeComment { get; set; }

        [PredicateName("SAT2_COMMENT_PERIGEE")]
        [JsonPropertyName("SAT2_COMMENT_PERIGEE")]
        public string? Satellite2PerigeeComment { get; set; }

        [PredicateName("SAT2_COMMENT_INCLINATION")]
        [JsonPropertyName("SAT2_COMMENT_INCLINATION")]
        public string? Satellite2InclinationComment { get; set; }

        [PredicateName("SAT2_COMMENT_OPERATOR_HARD_BODY_RADIUS")]
        [JsonPropertyName("SAT2_COMMENT_OPERATOR_HARD_BODY_RADIUS")]
        public string? Satellite2OperatorHardBodyRadiusComment { get; set; }

        [PredicateName("SAT2_AREA_PC")]
        [JsonPropertyName("SAT2_AREA_PC")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite2PhysicalCrossSectionalArea { get; set; }

        [PredicateName("SAT2_AREA_PC_UNIT")]
        [JsonPropertyName("SAT2_AREA_PC_UNIT")]
        public string? Satellite2PhysicalCrossSectionalAreaUnit { get; set; }

        [PredicateName("SAT2_CD_AREA_OVER_MASS")]
        [JsonPropertyName("SAT2_CD_AREA_OVER_MASS")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite2DragCoefficientAreaOverMass { get; set; }

        [PredicateName("SAT2_CD_AREA_OVER_MASS_UNIT")]
        [JsonPropertyName("SAT2_CD_AREA_OVER_MASS_UNIT")]
        public string? Satellite2DragCoefficientAreaOverMassUnit { get; set; }

        [PredicateName("SAT2_CR_AREA_OVER_MASS")]
        [JsonPropertyName("SAT2_CR_AREA_OVER_MASS")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite2RadiationPressureAreaOverMass { get; set; }

        [PredicateName("SAT2_CR_AREA_OVER_MASS_UNIT")]
        [JsonPropertyName("SAT2_CR_AREA_OVER_MASS_UNIT")]
        public string? Satellite2RadiationPressureAreaOverMassUnit { get; set; }

        [PredicateName("SAT2_THRUST_ACCELERATION")]
        [JsonPropertyName("SAT2_THRUST_ACCELERATION")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite2ThrustAcceleration { get; set; }

        [PredicateName("SAT2_THRUST_ACCELERATION_UNIT")]
        [JsonPropertyName("SAT2_THRUST_ACCELERATION_UNIT")]
        public string? Satellite2ThrustAccelerationUnit { get; set; }

        [PredicateName("SAT2_SEDR")]
        [JsonPropertyName("SAT2_SEDR")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite2Sedr { get; set; }

        [PredicateName("SAT2_SEDR_UNIT")]
        [JsonPropertyName("SAT2_SEDR_UNIT")]
        public string? Satellite2SedrUnit { get; set; }

        [PredicateName("SAT2_X")]
        [JsonPropertyName("SAT2_X")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite2XPosition { get; set; }

        [PredicateName("SAT2_X_UNIT")]
        [JsonPropertyName("SAT2_X_UNIT")]
        public string? Satellite2XPositionUnit { get; set; }

        [PredicateName("SAT2_Y")]
        [JsonPropertyName("SAT2_Y")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite2YPosition { get; set; }

        [PredicateName("SAT2_Y_UNIT")]
        [JsonPropertyName("SAT2_Y_UNIT")]
        public string? Satellite2YPositionUnit { get; set; }

        [PredicateName("SAT2_Z")]
        [JsonPropertyName("SAT2_Z")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite2ZPosition { get; set; }

        [PredicateName("SAT2_Z_UNIT")]
        [JsonPropertyName("SAT2_Z_UNIT")]
        public string? Satellite2ZPositionUnit { get; set; }

        [PredicateName("SAT2_X_DOT")]
        [JsonPropertyName("SAT2_X_DOT")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite2XVelocity { get; set; }

        [PredicateName("SAT2_X_DOT_UNIT")]
        [JsonPropertyName("SAT2_X_DOT_UNIT")]
        public string? Satellite2XVelocityUnit { get; set; }

        [PredicateName("SAT2_Y_DOT")]
        [JsonPropertyName("SAT2_Y_DOT")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite2YVelocity { get; set; }

        [PredicateName("SAT2_Y_DOT_UNIT")]
        [JsonPropertyName("SAT2_Y_DOT_UNIT")]
        public string? Satellite2YVelocityUnit { get; set; }

        [PredicateName("SAT2_Z_DOT")]
        [JsonPropertyName("SAT2_Z_DOT")]
        [JsonConverter(typeof(StringToDoubleNullableConverter))]
        public double? Satellite2ZVelocity { get; set; }

        [PredicateName("SAT2_Z_DOT_UNIT")]
        [JsonPropertyName("SAT2_Z_DOT_UNIT")]
        public string? Satellite2ZVelocityUnit { get; set; }

        [PredicateName("SAT2_COMMENT_DCP_DENSITY_FORECAST_UNCERTAINTY")]
        [JsonPropertyName("SAT2_COMMENT_DCP_DENSITY_FORECAST_UNCERTAINTY")]
        public string? Satellite2DcpDensityForecastUncertaintyComment { get; set; }

        [PredicateName("SAT2_COMMENT_DCP_SENSITIVITY_VECTOR_POSITION")]
        [JsonPropertyName("SAT2_COMMENT_DCP_SENSITIVITY_VECTOR_POSITION")]
        public string? Satellite2DcpSensitivityVectorPositionComment { get; set; }

        [PredicateName("SAT2_COMMENT_DCP_SENSITIVITY_VECTOR_VELOCITY")]
        [JsonPropertyName("SAT2_COMMENT_DCP_SENSITIVITY_VECTOR_VELOCITY")]
        public string? Satellite2DcpSensitivityVectorVelocityComment { get; set; }
    }
}