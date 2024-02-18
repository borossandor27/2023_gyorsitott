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
using Newtonsoft.Json;

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

        private void listBox_Dolgozo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dolgozo dolgozo = (Dolgozo) listBox_Dolgozo.SelectedItem;
            textBox_id.Text = dolgozo.Id.ToString();
            textBox_name.Text = dolgozo.Name.ToString();
            textBox_email.Text= dolgozo.Email.ToString();
            dateTimePicker_Szuletett.Value = dolgozo.Birthdate;
            numericUpDown_Fizetes.Value = dolgozo.Payment;
            
            //MessageBox.Show(JsonConvert.SerializeObject(dolgozo));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaFrissitese();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            //-- Update a dolgozó adatait a PUT metódussal frissítjük a REST API-n keresztül
            Dolgozo dolgozo = new Dolgozo();
            dolgozo.Id = Convert.ToInt32(textBox_id.Text);
            if (dolgozo.Id > 0)
            {
                if(string.IsNullOrEmpty(textBox_name.Text) || string.IsNullOrEmpty(textBox_email.Text))
                {
                    MessageBox.Show("Név és email mezők kitöltése kötelező");
                    return;
                }
                dolgozo.Name = textBox_name.Text;
                dolgozo.Email = textBox_email.Text;
                dolgozo.Payment = Convert.ToInt32(numericUpDown_Fizetes.Value);
                dolgozo.Birthdate=dateTimePicker_Szuletett.Value;
                var json = JsonConvert.SerializeObject(dolgozo);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PutAsync(endPoint + "/" + dolgozo.Id, data).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres frissítés");
                    listaFrissitese();
                }
                else
                {
                    MessageBox.Show("Sikertelen frissítés: " + response.ReasonPhrase);
                }
            }   
            bevitelimezokKiuritese();
        }

        private void bevitelimezokKiuritese()
        {
            textBox_email.Text = "";
            textBox_id.Text = "";
            textBox_name.Text = "";
            numericUpDown_Fizetes.Value = numericUpDown_Fizetes.Minimum;
            dateTimePicker_Szuletett.Value = DateTime.Today.AddYears(-18);
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            //-- Új dolgozó adatainak felvitele a REST API-n keresztül
            Dolgozo dolgozo = new Dolgozo();
            if (string.IsNullOrEmpty(textBox_name.Text) || string.IsNullOrEmpty(textBox_email.Text))
            {
                MessageBox.Show("Név és email mezők kitöltése kötelező");
                return;
            }
            dolgozo.Name = textBox_name.Text;
            dolgozo.Email = textBox_email.Text;
            dolgozo.Payment = Convert.ToInt32(numericUpDown_Fizetes.Value);
            dolgozo.Birthdate = dateTimePicker_Szuletett.Value;
            var json = JsonConvert.SerializeObject(dolgozo);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync(endPoint, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sikeres felvitel");
                listaFrissitese();
            }
            else
            {
                MessageBox.Show("Sikertelen felvitel: " + response.ReasonPhrase);
            }
            bevitelimezokKiuritese();
            listaFrissitese();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            //-- Dolgozó törlése a REST API-n keresztül
            Dolgozo dolgozo = (Dolgozo)listBox_Dolgozo.SelectedItem;
            if (dolgozo != null)
            {
                var response = client.DeleteAsync(endPoint + "/" + dolgozo.Id).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres törlés");
                    listaFrissitese();
                }
                else
                {
                    MessageBox.Show("Sikertelen törlés: " + response.ReasonPhrase);
                }
            }
            bevitelimezokKiuritese();
            listaFrissitese();
        }
    }
}
