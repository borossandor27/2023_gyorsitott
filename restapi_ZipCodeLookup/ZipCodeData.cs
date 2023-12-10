using Newtonsoft.Json;

namespace restapi_ZipCodeLookup
{
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

}
