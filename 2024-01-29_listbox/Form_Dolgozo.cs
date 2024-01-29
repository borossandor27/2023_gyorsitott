using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_01_29_listbox
{
    public partial class Form_Dolgozo : Form
    {
        string muvelet;
        public Form_Dolgozo(string muvelet, Object param=null)
        {
            InitializeComponent();
            this.muvelet = muvelet;
            switch (muvelet)
            {
                case "insert":
                    button1.Text = "Rögzítés";
                    this.Text = "Új dolgozó  adatai";
                    break;
                case "update":
                    button1.Text = "Módosít";
                    this.Text = "Új dolgozó  adatainak a módosítása";
                    //Dolgozo dolgozo=(Dolgozo)Program.nyitoForm.listBox_Dolgozok.SelectedItem;
                    Dolgozo dolgozo=(Dolgozo)param;
                    textBox_Id.Text = dolgozo.Id.ToString();
                    textBox_Nev.Text= dolgozo.Nev.ToString();
                    dateTimePicker_Szuletes.Value = dolgozo.Szulido;
                    break;
                default:
                    break;
            }


        }

        private void Form_Dolgozo_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
 switch (muvelet)
            {
                case "insert":
                    ujDolgozo();
                    break;
                case "update":
                    modosit();
                    break;
            }
        }

        private void modosit()
        {
            ulong id = ulong.Parse(textBox_Id.Text);
            if (String.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Hiányzó név!");
                textBox_Nev.Focus();
                return;
            }
            string nev = textBox_Nev.Text;
            if (dateTimePicker_Szuletes.Value.Year > DateTime.Now.Year - 18)
            {
                MessageBox.Show("Túl fiatal!");
                return;
            }
            //-- Az adatok elfogadhatóak
            Dolgozo dolgozo = new Dolgozo(id, nev, dateTimePicker_Szuletes.Value);
 
            Program.nyitoForm.listBox_Dolgozok.Items.Add(dolgozo);
            this.Close();
        }

        void ujDolgozo()
        {
            ulong id = (ulong)(Program.nyitoForm.listBox_Dolgozok.Items.Count + 1);
            if (String.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Hiányzó név!");
                textBox_Nev.Focus();
                return;
            }
            string nev = textBox_Nev.Text;
            if (dateTimePicker_Szuletes.Value.Year > DateTime.Now.Year - 18)
            {
                MessageBox.Show("Túl fiatal!");
                return;
            }
            //-- Az adatok elfogadhatóak
            Dolgozo ujDolgozo = new Dolgozo(id, nev, dateTimePicker_Szuletes.Value);
            Program.nyitoForm.listBox_Dolgozok.Items.Add(ujDolgozo);
            this.Close();
        }
    }
}
