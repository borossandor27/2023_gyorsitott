using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Windows.Forms;

namespace restapi_WindowsForms_countrie
{
    public partial class Form1 : Form
    {
        private HttpClient httpClient;
        JArray countryData;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            httpClient = new HttpClient();
        }

        private async void listBox_OrszagNevek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_OrszagNevek.SelectedIndex<0)
            {
                return;
            }
            string code=listBox_OrszagNevek.SelectedItem.ToString().Trim();
            string apiUrl = $"https://restcountries.com/v3.1/alpha/{code}"; //--  a végpont --

            try
            {
                // Elküldjük a GET kérést az API-hoz
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    // Válasz szöveg beolvasása JSON formátumban
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // JSON válasz feldolgozása (használhatod például Newtonsoft.Json névtérrel)
                    //-- bővebben: https://www.newtonsoft.com/json/help/html/t_newtonsoft_json_linq_jobject.htm
                    countryData = (JArray)Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(jsonResponse);
                    var tipus = countryData.GetType();

                    adatokMegjelentese(); 
                    
                    
                }
                else
                {
                    MessageBox.Show("Sikertelen API kérés: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt: " + ex.Message);
            }
        }

        private void adatokMegjelentese()
        {
            textBoxOfficialName.Text = (string)countryData.SelectToken("[0].name.common");
            textBoxRegion.Text = (string)countryData.SelectToken("[0].subregion");
            textBoxCapital.Text= (string)countryData.SelectToken("[0].capital[0]");
            
            pictureBoxFlag.Load((string)countryData.SelectToken("[0].flags.png"));
            pictureBoxCoatOfArms.Load((string)countryData.SelectToken("[0].coatOfArms.png"));
        }

        private void buttonTerkep_Click(object sender, EventArgs e)
        {
            if (countryData != null)
            {
                string url = (string)countryData.SelectToken("[0].maps.googleMaps");
                Process.Start(url);

            }
        }
    }
}
