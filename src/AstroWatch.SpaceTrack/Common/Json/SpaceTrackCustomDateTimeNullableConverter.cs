using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AstroWatch.SpaceTrack.Common.Json
{
    public class SpaceTrackCustomDateTimeNullableConverter : JsonConverter<DateTime?>
    {
        private const string Format = "yyyy-MM-dd H:mm:ss";

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.HasValue ? value.Value.ToString(Format) : "null");
        }

        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (string.IsNullOrWhiteSpace(value) || value == "null")
                return null;

            var format = value.Contains("T") ? Format.Replace(" ", "T") : Format;
            var indexOfMilliseconds = value.IndexOf('.');
            if (indexOfMilliseconds >= 0)
                format = $"{format}.{new string('f', value.Length - indexOfMilliseconds - 1)}";


            if (DateTime.TryParseExact(value, format, CultureInfo.InvariantCulture, DateTimeStyles.None,
                    out var result))
                return result;
            return DateTime.Parse(value);
        }
    }
}