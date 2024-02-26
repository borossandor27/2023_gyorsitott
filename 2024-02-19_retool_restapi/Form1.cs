﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using _2024_02_19_retool_restapi;
using Newtonsoft.Json;

namespace _2024_02_19_retool_restapi
{
    public partial class Form1 : Form
    {
        //-- https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-8.0
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointUrl");

        private static string ReadSetting(string keyName)
        {
            string result = null;
            try
            {
                var value = ConfigurationManager.AppSettings;
                result = value[keyName];
            }
            catch (ConfigurationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox_Gender.Items.Clear();
            //foreach (var item in Enum.GetValues(typeof(Gender)))
            //    {
            //    comboBox_Gender.Items.Add(item);
            //}
            comboBox_Gender.DataSource = Enum.GetValues(typeof(Gender));
            listafrissitese();
        }

        private async void listafrissitese()
        {
            listBox_Vasarlasok.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var vasarlo = Vasarlo.FromJson(jsonString);
                    foreach (Vasarlo item in vasarlo)
                    {
                        listBox_Vasarlasok.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox_Vasarlasok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vasarlo vasarlo = (Vasarlo)listBox_Vasarlasok.SelectedItem;
            textBox_id.Text = vasarlo.Id.ToString();
            textBox_Name.Text = vasarlo.Name.ToString();
            dateTimePicker_date.Value = DateTime.Parse(vasarlo.Date);
            numericUpDown1.Value = vasarlo.Payment;
            comboBox_Gender.DataSource = Enum.GetValues(typeof(Gender));

        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            listafrissitese();
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            Vasarlo vasarlo = new Vasarlo();
            if (string.IsNullOrEmpty(textBox_Name.Text))
            {
                MessageBox.Show("Név megadása kötelező");
                textBox_Name.Focus();
                return;
            }
            vasarlo.Name = textBox_Name.Text;
            vasarlo.Date = dateTimePicker_date.Value.ToString("yyyy-MM-dd");
            vasarlo.Gender = (Gender)Enum.Parse(typeof(Gender), comboBox_Gender.SelectedValue.ToString());
            //vasarlo.Gender = 1;
            vasarlo.Payment = (long)numericUpDown1.Value;
            //-- json-server tudja az autoincrement ----
            var json = JsonConvert.SerializeObject(vasarlo); //-- továbbítandó adat
            var data = new StringContent(json, Encoding.UTF8, "application/json"); //-- fejlécet adtunk hozzá
            var response = client.PostAsync(endPoint, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sikeres felvitel!");
                listafrissitese();
            }
            else
            {
                MessageBox.Show("Sikertelen felvitel!");
            }
            textBox_id.Text = string.Empty;
            textBox_Name.Text = string.Empty;
            numericUpDown1.Value = numericUpDown1.Minimum;
            comboBox_Gender.Text = "";
            dateTimePicker_date.Checked = false;
        }
    }
}
