using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace restapi_SocialLinksSearch
{
    internal class Program
    {
        //-- https://rapidapi.com/letscrape-6bRBa3QguO5/api/social-links-search
        //-- Uri("https://social-links-search.p.rapidapi.com/search-social-links?query=John%20Smith&social_networks=facebook%2Ctiktok%2Cinstagram%2Csnapchat%2Ctwitter%2Cyoutube%2Clinkedin%2Cgithub%2Cpinterest")
        //-- Headers: X-RapidAPI-Key: regisztrációnál kapott kód
        //-- Headers: X-RapidAPI-Host: social-links-search.p.rapidapi.com
        private static async Task Main()
        {
            string apiKey = "regisztrációnál kapott kód";
            string query = "John Smith";
            string url = "https://social-links-search.p.rapidapi.com/search-social-links?query=John%20Smith&social_networks=facebook%2Ctiktok%2Cinstagram%2Csnapchat%2Ctwitter%2Cyoutube%2Clinkedin%2Cgithub%2Cpinterest";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("x-rapidapi-key", apiKey);
                client.DefaultRequestHeaders.Add("x-rapidapi-host", "social-links-search.p.rapidapi.com");
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    //response.EnsureSuccessStatusCode();
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        JObject json = JObject.Parse(jsonResponse);
                        await Console.Out.WriteLineAsync("Eredmény: "  + json.ToString());
                    }                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
              
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        }
    }

