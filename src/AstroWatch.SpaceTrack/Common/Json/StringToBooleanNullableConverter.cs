using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AstroWatch.SpaceTrack.Common.Json
{
    public class StringToBooleanNullableConverter : JsonConverter<bool?>
    {
        public override void Write(Utf8JsonWriter writer, bool? value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.HasValue ? value.ToString() : "null");
        }

        public override bool? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (string.IsNullOrWhiteSpace(value) || value == "null")
                return null;
            
            return bool.Parse(value);
        }
    }
}