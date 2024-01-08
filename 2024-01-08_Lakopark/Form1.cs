using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_01_08_Lakopark
{
    public partial class Form1 : Form
    {
        Adatbazis adatbazis = new Adatbazis();
        List<Lakopark> lakoparkok = new List<Lakopark>(); //-- a lakóparkok listája
        int lakoparkIndex = 0; //-- a listában melyik lakópark van kiválasztva

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lakoparkok = adatbazis.LakoparkokBetoltese();
            lakoparkAdatokKiirasa();
        }
        void lakoparkAdatokKiirasa()
        {
            button_Balra.Visible = lakoparkIndex > 0;
            button_Jobbra.Visible = lakoparkIndex < lakoparkok.Count - 1;
            panel_Epuletek.Controls.Clear();
            this.Text = $"{lakoparkok[lakoparkIndex].Nev} lakópark";
            pictureBox_nevado.Image = lakoparkok[lakoparkIndex].nevadoKepe();
            pictureBox_nevado.SizeMode = PictureBoxSizeMode.StretchImage;
            int kepmeret = 40;
            for (int i = 0; i < lakoparkok[lakoparkIndex].UtcakSzama; i++)
            {
                for(int j=0;j< lakoparkok[lakoparkIndex].MaxHazSzam; j++)
                {
                    PictureBox haz = new PictureBox();
                    haz.Width = kepmeret;
                    haz.Height = kepmeret;
                    haz.Left = kepmeret + j * kepmeret;
                    haz.Top = kepmeret + i * kepmeret;
                    haz.BorderStyle = BorderStyle.FixedSingle;
                    haz.BackColor = Color.White;
                    haz.SizeMode = PictureBoxSizeMode.StretchImage;
                    haz.Image = lakoparkok[lakoparkIndex].getHazKepe(i+1,j+1);
                    haz.Tag = $"{i+1}.{j+1}";
                    haz.Click += Haz_Click;
                    panel_Epuletek.Controls.Add(haz);
                }
            }
        }

        private void Haz_Click(object sender, EventArgs e)
        {
            PictureBox haz = (PictureBox)sender;
            string[] hazAdatok = haz.Tag.ToString().Split('.');
            //MessageBox.Show($"A {hazAdatok[0]}. utcában a {hazAdatok[1]}. ház {lakoparkok[lakoparkIndex].Hazak[int.Parse(hazAdatok[0]) - 1, int.Parse(hazAdatok[1])-1]} emeletes.");
            lakoparkok[lakoparkIndex].hazEmeletNovel(int.Parse(hazAdatok[0]), int.Parse(hazAdatok[1]));
            haz.Image = lakoparkok[lakoparkIndex].getHazKepe(int.Parse(hazAdatok[0]), int.Parse(hazAdatok[1]));
        }

        private void button_Balra_Click(object sender, EventArgs e)
        {
            if (lakoparkIndex > 0)
            {
                lakoparkIndex--;
                lakoparkAdatokKiirasa();
            }
        }

        private void button_Jobbra_Click(object sender, EventArgs e)
        {
            if (lakoparkIndex < lakoparkok.Count - 1)
            {
                lakoparkIndex++;
                lakoparkAdatokKiirasa();
            }
        }
    }
}
