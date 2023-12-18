using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //-- adatok ellenőrzése --
            if (string.IsNullOrEmpty(textBox_DolgozoNev.Text))
            {
                MessageBox.Show("Nincs megadva név!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_DolgozoNev.Select();
                return;
            }
            if(!(radioButton_No.Checked || radioButton_Ferfi.Checked || radioButton_egyeb.Checked))
            {
                MessageBox.Show("Nincs megadva nem!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //-- adatok kiírása az adatbázisba --
            string nev = textBox_DolgozoNev.Text;
            DateTime dateTime = dateTimePicker_Szuletesidatum.Value;
            string nem = string.Empty;
            if (radioButton_No.Checked)
            {
                nem = "nő";
            } else if (radioButton_Ferfi.Checked)
            {
                nem = "férfi";
            }
            else
            {
                nem = "egyéb";
            }
            Program.db.insertDolgozo(nev, dateTime, nem);
            MessageBox.Show("Adatok kiírása az adatbázisba!", "Sikeres adatbevitel!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //-- adatmezők kiürítése --
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dateTimePicker_Szuletesidatum.MinDate = DateTime.Now.AddYears(-100);
            dateTimePicker_Szuletesidatum.MaxDate = DateTime.Now.AddYears(-18);
            dateTimePicker_Szuletesidatum.Value = DateTime.Now.AddYears(-30);
        }
    }
}
