using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using restapi_retool;

namespace restapi_retool
{
    public partial class Form1 : Form
    {
        string endPoint = ReadSetting("endPoint");
        HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker_Szuletett.MaxDate = DateTime.Today;
            dateTimePicker_Szuletett.Value = DateTime.Today.AddYears(-18);
            listaFrissitese();
        }

        private async void listaFrissitese()
        {
            listBox_Dolgozo.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    // Válasz szöveg beolvasása JSON formátumban
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    var dolgozok = Dolgozo.FromJson(jsonResponse);

                    foreach (Dolgozo item in dolgozok)
                    {
                        listBox_Dolgozo.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Sikertelen API kérés: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sikertelen API kérés: " + ex.Message);
            }
        }

       
        static string ReadSetting(string key)
        {
            string result = string.Empty;
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                result = appSettings[key] ?? "Not Found";
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
            return result;
        }
    }
}
