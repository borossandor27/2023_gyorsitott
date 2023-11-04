using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restapi_WinForm_complete
{
    internal class Person
    {
        int id;
        string Name, email, address;
        DateTime dateOfBirth;

        [JsonProperty("id")]
        public int Id { get => id; set => id = value; }
        [JsonProperty("Name")]
        public string Name1 { get => Name; set => Name = value; }
        [JsonProperty("email")]
        public string Email { get => email; set => email = value; }
        [JsonProperty("address")]
        public string Address { get => address; set => address = value; }
        [JsonProperty("dateOfBirth")]
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        [JsonConstructor]
        public Person(int id, string name1, string email, string address, DateTime dateOfBirth)
        {
            Id = id;
            Name1 = name1;
            Email = email;
            Address = address;
            DateOfBirth = dateOfBirth;
        }
        public Person( string name1, string email, string address, DateTime dateOfBirth)
        {
            Name1 = name1;
            Email = email;
            Address = address;
            DateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
