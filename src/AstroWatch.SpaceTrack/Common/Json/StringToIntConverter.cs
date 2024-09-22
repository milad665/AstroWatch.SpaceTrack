﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AstroWatch.SpaceTrack.Common.Json
{
    public class StringToIntConverter : JsonConverter<int>
    {
        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }

        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return int.Parse(reader.GetString());
        }
    }
}