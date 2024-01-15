using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _2024_01_15_Laptopok
{
    internal class Adatbazis
    {
        MySqlConnection conn=null;
        MySqlCommand sql=null;
        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "laptopok";
            builder.CharacterSet = "utf8";
            conn = new MySqlConnection(builder.ConnectionString);
            sql = conn.CreateCommand();
            try
            {
                kapcsolatNyit();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            } finally
            {
                kapcsolatZar();
            }
        }

        private void kapcsolatZar()
        {
            if(conn.State!=System.Data.ConnectionState.Closed) conn.Close();
        }

        private void kapcsolatNyit()
        {
            if (conn.State != System.Data.ConnectionState.Open) conn.Open();

        }

        internal List<Laptop> getAllLaptop()
        {
            List<Laptop> laptopok = new List<Laptop>();
            sql.CommandText = "SELECT * FROM `laptop` ORDER BY`marka`";
            try
            {
                kapcsolatNyit();
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        long laptopid = dr.GetInt64("laptopId");
                        string marka = dr.GetString("marka");
                        string model = dr.GetString("model");
                        string szin = dr.GetString("szin");
                        string processzor = dr.GetString("processzor");
                        string felbontas = dr.GetString("felbontas");
                        int memoria = dr.GetInt32("memoria");
                        int kepernyomeret = dr.GetInt32("kepernyomeret");
                        int merevlemezkapacitas = dr.GetInt32("merevlemezkapacitas");
                        int ar = dr.GetInt32("ar");
                        laptopok.Add(new Laptop(laptopid, marka, model, szin, processzor, felbontas, memoria, kepernyomeret, merevlemezkapacitas, ar));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatZar();
            }
            return laptopok;
        }

        internal void updateLaptop(Laptop laptop)
        {
            sql.CommandText = "UPDATE `laptop` SET " +
                "`marka`=@marka," +
                "`model`=@model," +
                "`szin`=@szin," +
                "`processzor`=@processzor," +
                "`memoria`=@memoria," +
                "`kepernyomeret`=@kepernyomeret," +
                "`felbontas`=@felbontas," +
                "`merevlemezkapacitas`=@merevlemezkapacitas," +
                "`ar`=@ar " +
                "WHERE `laptopId`=@laptopId";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@marka", laptop.Marka);
            try
            {
                kapcsolatNyit();
                sql.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { kapcsolatZar(); } 
        }
    }
}
