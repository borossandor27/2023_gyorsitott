using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _2023_12_11_restapi_dogs
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://dog.ceo/api/breeds/list/all");
            try
            {
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string jsonResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine(jsonResponse);
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
                throw;
            }
            

//            Console.WriteLine(await response.Content.ReadAsStringAsync());
            await Console.Out.WriteLineAsync("\nProgram vége!");
            Console.ReadKey();
        }
    }
}
