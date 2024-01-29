using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_01_29_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            Form_Dolgozo form_Dolgozo = new Form_Dolgozo("insert");
            form_Dolgozo.ShowDialog();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {

            if (listBox_Dolgozok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott dolgozó");
                return;
            }
            Dolgozo dolgozo=(Dolgozo)listBox_Dolgozok.SelectedItem;
            listBox_Dolgozok.Items.Remove(dolgozo);
            Form_Dolgozo form_Dolgozo = new Form_Dolgozo("update",dolgozo);
            form_Dolgozo.ShowDialog();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Dolgozok.SelectedIndex<0)
            {
                MessageBox.Show("Nincs kiváklasztott dolgozó");
                return ;
            }
            Dolgozo dolgozo = (Dolgozo)listBox_Dolgozok.SelectedItem;
            listBox_Dolgozok.Items.Remove(dolgozo);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename= saveFileDialog1.FileName;
                using (StreamWriter myStream = new StreamWriter(filename))
                {
                    foreach (Dolgozo item in listBox_Dolgozok.Items)
                    {
                        myStream.Write(item.toTxt());
                    }
                    myStream.Flush();
                }

                
            }
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog= new OpenFileDialog();
            openFileDialog.Filter= "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string adatFile = openFileDialog.FileName;
                using (StreamReader sr = new StreamReader(adatFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] sor = sr.ReadLine().Split(';');
                        Dolgozo uj = new Dolgozo(ulong.Parse(sor[0]), sor[1], DateTime.Parse(sor[2]));
                        listBox_Dolgozok.Items.Add(uj);
                    }
                }
            }
        }
    }
}
