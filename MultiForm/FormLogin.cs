﻿using System;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_FelhasznaloNev.Text))
            {
                MessageBox.Show("Nincs megadva felhasználónév!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_FelhasznaloNev.Select();
                return;
            }
            if (string.IsNullOrEmpty(textBox_Jelszo.Text))
            {
                MessageBox.Show("Nincs megadva jelszó!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Jelszo.Select();
                return;
            }
            if (textBox_FelhasznaloNev.Text == "admin" && textBox_Jelszo.Text == "admin")
            {
                Program.formMain.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó!", "Hibás adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_FelhasznaloNev.Select();
                return;
            }
        }
    }
}
