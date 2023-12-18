using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MultiForm
{
    internal class Adatbazis
    {
        MySqlCommand command=null;
        MySqlConnection connection=null;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "dolgozok";
            builder.CharacterSet = "utf8";
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                nyit();
                command = connection.CreateCommand();
                zar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
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
            if(connection.State!=System.Data.ConnectionState.Open) {
                connection.Open();

            }
        }

        public void insertDolgozo(string nev, DateTime szuletett, string nem) {
            command.CommandText = "INSERT INTO `dolgozo` (`dolgozoid`, `dolgozonev`, `szuletesi_Ido`, `nem`) VALUES (NULL, @nev, @szuletett, @nem);";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", nev);
            command.Parameters.AddWithValue("@szuletett", szuletett.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@nem", nem);
            nyit();
            command.ExecuteNonQuery();
            zar();
        }
    }
}
