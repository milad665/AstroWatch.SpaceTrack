using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    public class Delete : IBasicSpaceDataClass
    {
        [PredicateName("FILE_ID")]
        [JsonPropertyName("FILE_ID")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? FileId { get; set; }

        [PredicateName("FOLDER_ID")]
        [JsonPropertyName("FOLDER_ID")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? FolderId { get; set; }
    }
}