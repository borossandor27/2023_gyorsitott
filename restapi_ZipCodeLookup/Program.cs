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
            string iranyitoszam = "4220";
            await GetZipCodeDataAsync($"http://api.zippopotam.us/hu/{iranyitoszam}");
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

                        // Most a zipCodeData változó tartalmazza az API válaszát 
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
                                Console.WriteLine($"  State: {place.State}");
                                Console.WriteLine($"  State Abbreviation: {place.StateAbbreviation}");
                                Console.WriteLine($"  Longitude: {place.Longitude}");
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

}
