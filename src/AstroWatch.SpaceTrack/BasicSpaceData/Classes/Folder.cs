using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    public class Folder : IBasicSpaceDataClass
    {
        [PredicateName("bloc_id")]
        [JsonPropertyName("bloc_id")]
        public int? BlocId { get; set; }

        [PredicateName("folder_id")]
        [JsonPropertyName("folder_id")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? FolderId { get; set; }

        [PredicateName("folder_path")]
        [JsonPropertyName("folder_path")]
        public string? FolderPath { get; set; }

        [PredicateName("folder_name")]
        [JsonPropertyName("folder_name")]
        public string? FolderName { get; set; }

        [PredicateName("permissions")]
        [JsonPropertyName("permissions")]
        public string? Permissions { get; set; }
    }
}