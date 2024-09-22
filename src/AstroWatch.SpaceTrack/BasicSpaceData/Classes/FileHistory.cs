using System;
using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    public class FileHistory : IBasicSpaceDataClass
    {
        [PredicateName("file_history_id")]
        [JsonPropertyName("file_history_id")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? FileHistoryId { get; set; }

        [PredicateName("file_name")]
        [JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        [PredicateName("file_uploaded")]
        [JsonPropertyName("file_uploaded")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? FileUploaded { get; set; }

        [PredicateName("file_size")]
        [JsonPropertyName("file_size")]
        [JsonConverter(typeof(StringToLongNullableConverter))]
        public long? FileSize { get; set; }

        [PredicateName("file_md5")]
        [JsonPropertyName("file_md5")]
        public string? FileMd5 { get; set; }

        [PredicateName("file_id")]
        [JsonPropertyName("file_id")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? FileId { get; set; }
    }
}