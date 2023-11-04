using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restapi_WinForm_complete
{
    public partial class Form1 : Form
    {
        /*
         * Endpoint URL: https://retoolapi.dev/WdWE6Y/data
         * 
         * HTTP method endpoints
         *  GET          /WdWE6Y/data
         *  GET filter   /WdWE6Y/data?Name=value
         *  GET by id    /WdWE6Y/data/1
         *  GET paginate /WdWE6Y/data?_page=2&_limit=10
         *  POST         /WdWE6Y/data
         *  PUT          /WdWE6Y/data/1
         *  PATCH        /WdWE6Y/data/1
         *  DELETE       /WdWE6Y/data/1
         * 
         *   {
         *      "id": 1,
         *      "Name": "Talya Manketell",
         *      "email": "tbanger23@sbwire.com",
         *      "address": "Pittsfield, Massachusetts, United States",
         *      "dateOfBirth": "Jan 1, 1970 12:00 AM"
         *   }
         */
        private HttpClient client;
        JArray persons;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //-- elolvasni: https://learn.microsoft.com/hu-hu/dotnet/fundamentals/networking/http/httpclient-guidelines
            client = new HttpClient();
            //-- LifeTime? -----
            ListBoxUpdate();
        }

        private async void ListBoxUpdate()
        {
            string apiUrl = $"https://retoolapi.dev/WdWE6Y/data/"; //--  a végpont --
            listBoxPersons.Items.Clear();
            try
            {
                // Elküldjük a GET kérést az API-hoz
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    // Válasz szöveg beolvasása JSON formátumban
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // JSON válasz feldolgozása (használhatod például Newtonsoft.Json névtérrel)
                    //-- bővebben: https://www.newtonsoft.com/json/help/html/t_newtonsoft_json_linq_jobject.htm
                    persons = (JArray)Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(jsonResponse);

                    foreach (JToken item in persons)
                    {
                        Person person = item.ToObject<Person>();
                        listBoxPersons.Items.Add(person);
                    }
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

        private void listBoxPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
         

            Person person = listBoxPersons.SelectedItem as Person;
            textBoxId.Text = person.Id.ToString();
            textBoxName.Text = person.Name1;
            textBoxAddress.Text = person.Address.ToString();
            textBoxEmail.Text = person.Email.ToString();
            dateTimePickerDateOfBirth.Value = person.DateOfBirth;
        }
        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (hianyzoAdat())
            {
                MessageBox.Show("Hiányzó adat!");
                return;
            }
            //-- JSon létrehozása ------------
            int id = int.Parse(textBoxId.Text);
            string name = textBoxName.Text;
            string address = textBoxAddress.Text;
            string email = textBoxEmail.Text;
            DateTime dateOfBird = dateTimePickerDateOfBirth.Value;
            Person person = new Person(id, name, email, address, dateOfBird);
            string apiUrl = $"https://retoolapi.dev/WdWE6Y/data/{id}"; //--  a végpont --
            HttpContent request = new StringContent(JsonConvert.SerializeObject(person), Encoding.UTF8, "application/json");
            request.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            try
            {
                // Elküldjük a PUT kérést az API-hoz
                HttpResponseMessage response = await client.PutAsync(apiUrl, request);

                if (response.IsSuccessStatusCode)
                {
                    // Válasz szöveg beolvasása JSON formátumban
                    string content = await response.Content.ReadAsStringAsync();
                    if (string.IsNullOrEmpty(content))
                    {
                        MessageBox.Show("A módosítás sikeres!");
                    }
                    else
                    {
                        MessageBox.Show("Sikeres módosítás!");
                    }
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
            ListBoxUpdate();
        }

        private async void buttonInsert_Click(object sender, EventArgs e)
        {
            if (hianyzoAdat())
            {
                MessageBox.Show("Hiányzó adat!");
                return;
            }
 
            //-- JSon létrehozása ------------
            //int id = int.Parse(textBoxId.Text);
            string name = textBoxName.Text;
            string address = textBoxAddress.Text;
            string email = textBoxEmail.Text;
            DateTime dateOfBird = dateTimePickerDateOfBirth.Value;
            Person person = new Person(name, email, address, dateOfBird);
            string apiUrl = $"https://retoolapi.dev/WdWE6Y/data"; //--  a végpont --
            HttpContent request = new StringContent(JsonConvert.SerializeObject(person), Encoding.UTF8, "application/json");
            request.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            try
            {
                // Elküldjük a PUT kérést az API-hoz
                HttpResponseMessage response = await client.PostAsync(apiUrl, request);

                if (response.IsSuccessStatusCode)
                {
                    // Válasz szöveg beolvasása JSON formátumban
                    string content = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(content))
                    {
                        MessageBox.Show("Új adat rögzítése sikeres!", "Sikeres művelet!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Új adat rögzítése sikertelen!", "A kiszolgáló a kérést visszautasította!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sikertelen API kérés: " + response.ReasonPhrase, "Kliens oldali hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt: " + ex.Message, "A kiszolgáló a kérést visszautasította!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ListBoxUpdate();
        }

        private bool hianyzoAdat()
        {
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxAddress.Text) || !IsValidEmail(textBoxEmail.Text) || dateTimePickerDateOfBirth.Value == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (hianyzoAdat())
            {
                MessageBox.Show("Hiányzó adat!");
                return;
            }

            //-- JSon létrehozása ------------
            int id = int.Parse(textBoxId.Text);
            string name = textBoxName.Text;
            string address = textBoxAddress.Text;
            string email = textBoxEmail.Text;
            DateTime dateOfBird = dateTimePickerDateOfBirth.Value;
            Person person = new Person(id, name, email, address, dateOfBird);

            //-- Törlésre rákérdezünk -----------------------
            string keredsSzoveg = $"Valóban szeretné törölni {person.Name1} adatait?";
            if (MessageBox.Show(keredsSzoveg,"Megerősítés kérése",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button2)==DialogResult.No)
            {
                return;                
            } 
            //-- törlést jóváhagyta a felhasználó ----------------
            string apiUrl = $"https://retoolapi.dev/WdWE6Y/data/{id}"; //--  a végpont --
            HttpContent request = new StringContent(JsonConvert.SerializeObject(person), Encoding.UTF8, "application/json");
            request.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            try
            {
                // Elküldjük a PUT kérést az API-hoz
                HttpResponseMessage response = await client.DeleteAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    // Válasz szöveg beolvasása JSON formátumban
                    string content = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(content))
                    {
                        MessageBox.Show($"{person.Name1} nevű felhasználó törlése sikeres!", "Sikeres művelet!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show($"{person.Name1} nevű felhasználó törlése sikertelen!", "A kiszolgáló a kérést visszautasította!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sikertelen API kérés: " + response.ReasonPhrase, "Kliens oldali hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt: " + ex.Message, "A kiszolgáló a kérést visszautasította!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ListBoxUpdate();

        }
    }
}
