using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace restapi_konzolos_jsonconvert

{
 
class Program
    {
       static async Task Main(string[] args)
        {

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string apiUrl = "https://jsonplaceholder.typicode.com/users";
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("API válasz:");
                        Console.WriteLine(jsonResponse);
                        stringToJson(jsonResponse);
                    }
                    else
                    {
                        Console.WriteLine($"Hiba történt az API hívás során. Státuszkód: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hiba történt: {ex.Message}");
                }
            }
            
            await Console.Out.WriteLineAsync("\nProgram vége!");

            Console.ReadLine();
        }

        private static void stringToJson(string jsonResponse)
        {
            
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonResponse);
            foreach (User user in users) { Console.WriteLine(user.Name); }
        }
    }

}

