using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace restapi_konzolos_jsonconvert
{
    internal class User
    {
        int id;
        string name;
        string username;
        string email;
        Address address;
        string phone;
        string website;
        Company company;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Website { get => website; set => website = value; }
        internal Address Address { get => address; set => address = value; }
        internal Company Company { get => company; set => company = value; }

        public User(int id, string name, string username, string email, string phone, string website, Address address, Company company)
        {
            Id = id;
            Name = name;
            Username = username;
            Email = email;
            Phone = phone;
            Website = website;
            Address = address;
            Company = company;
        }
    }
}
