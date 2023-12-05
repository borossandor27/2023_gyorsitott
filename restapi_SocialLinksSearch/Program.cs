using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace restapi_SocialLinksSearch
{
    internal class Program
    {
        //-- https://rapidapi.com/letscrape-6bRBa3QguO5/api/social-links-search
        static async Task Main()
        {
            string query = "John Smith";
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://social-links-search.p.rapidapi.com/search-social-links?query={query}&social_networks=facebook%2Ctiktok%2Cinstagram%2Csnapchat%2Ctwitter%2Cyoutube%2Clinkedin%2Cgithub%2Cpinterest"),
                Headers =
                {
                    { "X-RapidAPI-Key", "7508cc1faemsh44c251a5df385ecp14ccb9jsn763eeb288635" },
                    { "X-RapidAPI-Host", "social-links-search.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
            Console.WriteLine("\nProgram vége");
            Console.ReadLine();
        }
    }
}
