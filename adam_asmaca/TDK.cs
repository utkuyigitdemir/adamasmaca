using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adam_asmaca
{
    public partial class Tdk
    {
        [JsonProperty("sayac")]
        public Sayac[] Sayac { get; set; }

        [JsonProperty("karistirma")]
        public Karistirma[] Karistirma { get; set; }

        [JsonProperty("atasoz")]
        public Atasoz[] Atasoz { get; set; }

        [JsonProperty("syyd")]
        public Syyd[] Syyd { get; set; }

        [JsonProperty("kural")]
        public Kural[] Kural { get; set; }

        [JsonProperty("yabanci")]
        public Yabanci Yabanci { get; set; }

        [JsonProperty("kelime")]
        public Atasoz[] Kelime { get; set; }
    }

    public partial class Atasoz
    {
        [JsonProperty("madde")]
        public string Madde { get; set; }

        [JsonProperty("anlam")]
        public string Anlam { get; set; }
    }

    public partial class Karistirma
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("yanlis")]
        public string Yanlis { get; set; }

        [JsonProperty("dogru")]
        public string Dogru { get; set; }
    }

    public partial class Kural
    {
        [JsonProperty("adi")]
        public string Adi { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class Sayac
    {
        [JsonProperty("deger")]
        public string Deger { get; set; }
    }

    public partial class Syyd
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("yanliskelime")]
        public string Yanliskelime { get; set; }

        [JsonProperty("dogrukelime")]
        public string Dogrukelime { get; set; }
    }

    public partial class Yabanci
    {
        [JsonProperty("karsid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Karsid { get; set; }

        [JsonProperty("kkelime")]
        public string Kkelime { get; set; }

        [JsonProperty("kkoken")]
        public string Kkoken { get; set; }

        [JsonProperty("kkarsilik")]
        public string Kkarsilik { get; set; }

        [JsonProperty("anlam")]
        public string Anlam { get; set; }
    }

    public partial class Tdk
    {
        public static Tdk FromJson(string json) => JsonConvert.DeserializeObject<Tdk>(json, adam_asmaca.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Tdk self) => JsonConvert.SerializeObject(self, adam_asmaca.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
