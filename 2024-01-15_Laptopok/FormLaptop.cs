using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_01_15_Laptopok
{
    public partial class FormLaptop : Form
    {
        string muvelet;
        public FormLaptop(string muvelet)
        {
            InitializeComponent();
            this.muvelet = muvelet;
        }

        private void FormLaptop_Load(object sender, EventArgs e)
        {
            switch (muvelet)
            {
                case "add":
                    this.Text = "Új laptop";
                    button_Muvelet.Text = "Rögzítés";
                    button_Muvelet.BackColor = Color.Green;
                    button_Muvelet.Click += new EventHandler(insertLaptop);
                    break;
                case "edit":
                    this.Text = "Módosítás";
                    button_Muvelet.Text = "Módosítás";
                    button_Muvelet.BackColor = Color.Blue;
                    button_Muvelet.ForeColor = Color.White;
                    button_Muvelet.Click += new EventHandler(updateLaptop);
                    adatmezokFeltoltese();
                    break;
                case "delete":
                    this.Text = "Törlés";
                    button_Muvelet.Text = "Törlés";
                    button_Muvelet.BackColor = Color.Red;
                    button_Muvelet.ForeColor= Color.White;
                    button_Muvelet.Click += new EventHandler(deleteLaptop);
                    adatmezokFeltoltese();
                    break;

            }
        }

        private void adatmezokFeltoltese()
        {
            Laptop laptop = (Laptop)Program.formNyito.listBox_Laptopok.SelectedItem;
            textBox_LaptopId.Text = laptop.Laptopid.ToString();
            textBox_Felbontas.Text=laptop.Felbontas.ToString();
            textBox_Marka.Text=laptop.Marka.ToString();
            textBox_Model.Text=laptop.Model.ToString();
            textBox_Szin.Text=laptop.Szin.ToString();
            nu_kepernyomeret.Value = (decimal)laptop.Kepernyomeret;
            nu_memoria.Value = (decimal)laptop.Memoria;
            nu_ar.Value = (decimal)laptop.Ar;
        }

        private void deleteLaptop(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void updateLaptop(object sender, EventArgs e)
        {
            Laptop laptop = new Laptop();
            laptop.Laptopid = int.Parse(textBox_LaptopId.Text);
            laptop.Marka=textBox_Marka.Text;
            laptop.Model=textBox_Model.Text;
            laptop.Processzor=textBox_Processzor.Text;
            laptop.Szin=textBox_Szin.Text;
            Program.db.updateLaptop(laptop);
        }

        private void insertLaptop(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
