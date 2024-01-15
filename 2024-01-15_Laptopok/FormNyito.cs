using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace _2024_01_15_Laptopok
{
    public partial class FormNyito : Form
    {
        public FormNyito()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (string gyarto in Program.laptopok.Select(a => a.Marka).Distinct())
            {
                CheckBox cb = new CheckBox();
                cb.Text = gyarto; //-- szöveg beállítása
                cb.Checked = true;
                cb.Location = new Point(10, panel_Gyartok.Controls.Count * 20);
                cb.CheckedChanged += new EventHandler(gyarto_valtozott);
                panel_Gyartok.Controls.Add(cb);
            }
            updateLaptopLista();
        }

        private void gyarto_valtozott(object sender, EventArgs e)
        {
            updateLaptopLista();
        }

        private void updateLaptopLista()
        {
            
            listBox_Laptopok.Items.Clear();
            //-- a kiválasztott gyártók laptopjainak a hozzádása
            List<string> kivalasztottak = new List<string>();
            foreach (CheckBox item in panel_Gyartok.Controls)
            {
                if (item.Checked) { kivalasztottak.Add(item.Text); };
            }
            foreach (Laptop  item in Program.laptopok)
            {
                if (kivalasztottak.Contains(item.Marka))
                {
                    listBox_Laptopok.Items.Add(item);
                }
            }
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLaptop formLaptop = new FormLaptop("add");
            formLaptop.ShowDialog();
        }

        private void módosítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_Laptopok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott elem!");
                return;
            }
            FormLaptop formLaptop = new FormLaptop("edit");
            formLaptop.ShowDialog();

        }

        private void törölToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_Laptopok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott elem!");
                return;
            }
            FormLaptop formLaptop = new FormLaptop("delete");
            formLaptop.ShowDialog();


        }
    }
}
