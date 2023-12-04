﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace _2023_12_04_MySQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Clear();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tagdij";
            sb.CharacterSet = "utf8";
            MySqlConnection connection = new MySqlConnection(sb.ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM `ugyfel`";
                using (MySqlDataReader dr=command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Tag tag = new Tag(dr.GetInt32("azon"), dr.GetString("nev"), dr.GetInt32("szulev"), dr.GetInt32("irszam"), dr.GetString("orsz"));
                        Console.WriteLine(tag);
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
            Console.WriteLine("\nProgram vége!");
            Console.ReadLine();
        }
    }
}
