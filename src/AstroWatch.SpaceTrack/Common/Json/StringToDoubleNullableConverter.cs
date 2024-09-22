using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AstroWatch.SpaceTrack.Common.Json
{
    public class StringToDoubleNullableConverter : JsonConverter<double?>
    {
        public override void Write(Utf8JsonWriter writer, double? value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.HasValue ? value.ToString() : "null");
        }

        public override double? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (string.IsNullOrWhiteSpace(value) || value == "null")
                return null;
            
            return double.Parse(value);
        }
    }
}