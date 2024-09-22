using System;
using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    public class File : IBasicSpaceDataClass
    {
        [PredicateName("FOLDER_ID")]
        [JsonPropertyName("FOLDER_ID")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? FolderId { get; set; }

        [PredicateName("FOLDER_NAME")]
        [JsonPropertyName("FOLDER_NAME")]
        public string? FolderName { get; set; }

        [PredicateName("FILE_FULLPATH")]
        [JsonPropertyName("FILE_FULLPATH")]
        public string? FileFullpath { get; set; }

        [PredicateName("FILE_ID")]
        [JsonPropertyName("FILE_ID")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? FileId { get; set; }

        [PredicateName("FILE_NAME")]
        [JsonPropertyName("FILE_NAME")]
        public string? FileName { get; set; }

        [PredicateName("FILE_UPLOADED")]
        [JsonPropertyName("FILE_UPLOADED")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? FileUploaded { get; set; }

        [PredicateName("FILE_BYTES")]
        [JsonPropertyName("FILE_BYTES")]
        [JsonConverter(typeof(StringToLongNullableConverter))]
        public long? FileBytes { get; set; }

        [PredicateName("FILE_DELETE")]
        [JsonPropertyName("FILE_DELETE")]
        public bool? FileDelete { get; set; }

        [PredicateName("FILE_LINK")]
        [JsonPropertyName("FILE_LINK")]
        public string? FileLink { get; set; }

        [PredicateName("FILE_TYPE")]
        [JsonPropertyName("FILE_TYPE")]
        public string? FileType { get; set; }
    }
}