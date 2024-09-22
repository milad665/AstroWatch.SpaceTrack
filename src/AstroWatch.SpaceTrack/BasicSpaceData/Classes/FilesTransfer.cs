using System;
using System.Text.Json.Serialization;
using AstroWatch.SpaceTrack.Common;
using AstroWatch.SpaceTrack.Common.Json;

namespace AstroWatch.SpaceTrack.BasicSpaceData.Classes
{
    public class FilesTransfer : IBasicSpaceDataClass
    {
        [PredicateName("file_id")]
        [JsonPropertyName("file_id")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? FileId { get; set; }

        [PredicateName("file_name")]
        [JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        [PredicateName("transfer_file_name")]
        [JsonPropertyName("transfer_file_name")]
        public string? TransferFileName { get; set; }

        [PredicateName("transfer_courier")]
        [JsonPropertyName("transfer_courier")]
        public string? TransferCourier { get; set; }

        [PredicateName("file_uploaded")]
        [JsonPropertyName("file_uploaded")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? FileUploaded { get; set; }

        [PredicateName("file_deleted")]
        [JsonPropertyName("file_deleted")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? FileDeleted { get; set; }

        [PredicateName("transfer_step1")]
        [JsonPropertyName("transfer_step1")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? TransferStep1 { get; set; }

        [PredicateName("transfer_step2")]
        [JsonPropertyName("transfer_step2")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? TransferStep2 { get; set; }

        [PredicateName("last_downloaded_datetime")]
        [JsonPropertyName("last_downloaded_datetime")]
        [JsonConverter(typeof(SpaceTrackCustomDateTimeNullableConverter))]
        public DateTime? LastDownloadedDatetime { get; set; }

        [PredicateName("last_downloaded_uname")]
        [JsonPropertyName("last_downloaded_uname")]
        public string? LastDownloadedUname { get; set; }

        [PredicateName("upload_step1_diff")]
        [JsonPropertyName("upload_step1_diff")]
        public string? UploadStep1Diff { get; set; }

        [PredicateName("step1_step2_diff")]
        [JsonPropertyName("step1_step2_diff")]
        public string? Step1Step2Diff { get; set; }

        [PredicateName("step2_download_diff")]
        [JsonPropertyName("step2_download_diff")]
        public string? Step2DownloadDiff { get; set; }

        [PredicateName("complete")]
        [JsonPropertyName("complete")]
        [JsonConverter(typeof(StringToBooleanNullableConverter))]
        public bool? Complete { get; set; }

        [PredicateName("parent_id")]
        [JsonPropertyName("parent_id")]
        [JsonConverter(typeof(StringToIntNullableConverter))]
        public int? ParentId { get; set; }
    }
}