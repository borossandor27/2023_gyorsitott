﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using _2024_02_19_retool_restapi;
//
//    var vasarlo = Vasarlo.FromJson(jsonString);

namespace _2024_02_19_retool_restapi
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Vasarlo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        [JsonProperty("payment")]
        public long Payment { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public enum Gender { Ferfi, No };

    public partial class Vasarlo
    {
        public static Vasarlo[] FromJson(string json) => JsonConvert.DeserializeObject<Vasarlo[]>(json, _2024_02_19_retool_restapi.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Vasarlo[] self) => JsonConvert.SerializeObject(self, _2024_02_19_retool_restapi.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                GenderConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class GenderConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Gender) || t == typeof(Gender?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ferfi":
                    return Gender.Ferfi;
                case "no":
                    return Gender.No;
            }
            throw new Exception("Cannot unmarshal type Gender");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Gender)untypedValue;
            switch (value)
            {
                case Gender.Ferfi:
                    serializer.Serialize(writer, "ferfi");
                    return;
                case Gender.No:
                    serializer.Serialize(writer, "no");
                    return;
            }
            throw new Exception("Cannot marshal type Gender");
        }

        public static readonly GenderConverter Singleton = new GenderConverter();
    }
}
