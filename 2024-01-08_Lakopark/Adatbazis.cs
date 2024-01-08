using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.CryptoPro;

namespace _2024_01_08_Lakopark
{
    internal class Adatbazis
    {
        MySqlConnection conn;
        MySqlCommand sql;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Clear();
            sb.Server = "localhost";
            sb.Database = "lakopark";
            sb.UserID = "root";
            sb.Password = "";
            sb.CharacterSet = "utf8";
            conn = new MySqlConnection(sb.ConnectionString);
            sql = conn.CreateCommand();
            try
            {
                kapcsolatNyit();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            } 
            finally
            {
                kapcsolatZar();
            }
        }

        private void kapcsolatZar()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        private void kapcsolatNyit()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }

        internal List<Lakopark> LakoparkokBetoltese()
        {
            List<Lakopark> lakoparkok = new List<Lakopark>();
            sql.CommandText = "SELECT * FROM lakopark NATURAL JOIN epuletek ORDER BY lakopark.lakoparkId;";
            int regiId = -1;
            int lakoparkIndex = -1;
            kapcsolatNyit();
            using(MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    if (regiId != Convert.ToInt32(dr["lakoparkId"]))
                    {
                        regiId = Convert.ToInt32(dr["lakoparkId"]);
                        lakoparkIndex++;
                        int lakoparkId = dr.GetInt32("lakoparkId");
                        string nev = dr["lakoparkNev"].ToString();
                        int utcakSzama = Convert.ToInt32(dr["utcakSzama"]);
                        int maxHazSzam = Convert.ToInt32(dr["telkekSzama"]);
                        Lakopark lakopark = new Lakopark(lakoparkId, nev, utcakSzama, maxHazSzam);
                        lakoparkok.Add(lakopark);
                    }
                    lakoparkok[lakoparkIndex].hazEmeletszam(Convert.ToInt32(dr["utcaSzam"]), Convert.ToInt32(dr["hazSzam"]), Convert.ToInt32(dr["emelet"]));

                }
            }
            return lakoparkok;
        }
    }
}
