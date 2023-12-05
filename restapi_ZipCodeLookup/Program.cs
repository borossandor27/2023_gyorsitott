using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace restapi_ZipCodeLookup
{

    public class Program
    {
        static async Task Main(string[] args)
        {
            await GetZipCodeDataAsync("http://api.zippopotam.us/hu/4220");
            Console.ReadLine();
        }

        static async Task GetZipCodeDataAsync(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        ZipCodeData zipCodeData = JsonConvert.DeserializeObject<ZipCodeData>(responseData);

                        // Most a zipCodeData változó tartalmazza az API válaszát az osztályokban
                        // Az adatokhoz való hozzáférés példa:
                        Console.WriteLine($"Post Code: {zipCodeData.PostCode}");
                        Console.WriteLine($"Country: {zipCodeData.Country}");
                        Console.WriteLine($"Country Abbreviation: {zipCodeData.CountryAbbreviation}");

                        if (zipCodeData.Places != null && zipCodeData.Places.Length > 0)
                        {
                            Console.WriteLine("Places:");
                            foreach (var place in zipCodeData.Places)
                            {
                                Console.WriteLine($"  Place Name: {place.PlaceName}");
                                Console.WriteLine($"  Longitude: {place.Longitude}");
                                Console.WriteLine($"  State: {place.State}");
                                Console.WriteLine($"  State Abbreviation: {place.StateAbbreviation}");
                                Console.WriteLine($"  Latitude: {place.Latitude}");
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nincs elérhető helynév az adatokban.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"HTTP hiba kód: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hiba történt: {ex.Message}");
                }
            }
        }
    }

    public partial class ZipCodeData
    {
        [JsonProperty("post code")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PostCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country abbreviation")]
        public string CountryAbbreviation { get; set; }

        [JsonProperty("places")]
        public Place[] Places { get; set; }
    }

    public partial class Place
    {
        [JsonProperty("place name")]
        public string PlaceName { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("state abbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }

    public class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (Int64.TryParse(value, out var l))
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
