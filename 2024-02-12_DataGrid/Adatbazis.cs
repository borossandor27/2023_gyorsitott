using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace _2024_02_12_DataGrid
{
    internal class Adatbazis
    {
        MySqlConnection connection;
        MySqlCommand command;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "orszagok";
            builder.CharacterSet = "utf8";
            connection = new MySqlConnection(builder.ConnectionString);
            command = connection.CreateCommand();
            try
            {
                nyit();
                zar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void zar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void nyit()
        {
            if (connection.State!=System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        internal List<Orszag> orszagok()
        {
            command.CommandText = "SELECT orsz3.kontinens, `orszag`,`fovaros`,`terulet` FROM `orsz3` WHERE 1;";
            List<Orszag> orszags = new List<Orszag>();
            nyit();
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    orszags.Add(new Orszag(dr.GetString("orszag"), dr.GetString("kontinens"), dr.GetString("fovaros"), dr.GetDecimal("terulet")));
                }
            }
            return orszags;
        }
    }
}
