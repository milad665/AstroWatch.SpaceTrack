using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AstroWatch.SpaceTrack.Common.Json
{
    public class StringToLongNullableConverter : JsonConverter<long?>
    {
        public override void Write(Utf8JsonWriter writer, long? value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.HasValue ? value.ToString() : "null");
        }

        public override long? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (string.IsNullOrWhiteSpace(value) || value == "null")
                return null;
            
            return long.Parse(value);
        }
    }
}