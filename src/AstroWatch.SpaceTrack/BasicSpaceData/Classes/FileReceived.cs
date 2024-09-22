using System;
using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    public class FileReceived : IBasicSpaceDataClass
    {
        [PredicateName("file_id")]
        [JsonPropertyName("file_id")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? FileId { get; set; }

        [PredicateName("file_name")]
        [JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        [PredicateName("source_name")]
        [JsonPropertyName("source_name")]
        public string? SourceName { get; set; }

        [PredicateName("file_type")]
        [JsonPropertyName("file_type")]
        public string? FileType { get; set; }

        [PredicateName("received_epoch")]
        [JsonPropertyName("received_epoch")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? ReceivedEpoch { get; set; }
    }
}