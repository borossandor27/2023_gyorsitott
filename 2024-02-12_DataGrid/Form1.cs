using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_02_12_DataGrid
{
    public partial class Form1 : Form
    {
        Adatbazis db = new Adatbazis();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_Mertekegyseg.Text = "km\x00B2";
            AdattablaBeallitas();
            AdattablaFrissites();
        }

        private void AdattablaFrissites()
        {
            dataGridView_Adatok.Rows.Clear();
            foreach (Orszag orszag in db.orszagok())
            {
                int sorszam = dataGridView_Adatok.Rows.Add(); //-- alapértelmezettet adunk hozzá
                DataGridViewRow row = dataGridView_Adatok.Rows[sorszam]; //-- oszlop tulajdonságokkal formázott cellákat kapunk vissza
                row.Cells["kontinens"].Value = orszag.Kontinens.ToString() ;
                row.Cells["orszag"].Value=orszag.OrszagNev.ToString() ;
                row.Cells["fovaros"].Value=orszag.Fovaros.ToString() ;
                row.Cells["terulet"].Value = orszag.Terulet.ToString();
            }
        }

        private void AdattablaBeallitas()
        {
            //-- A DataGrid megjelenésének a beállítása
            //-- globális, egész táblázat
            dataGridView_Adatok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Adatok.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_Adatok.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView_Adatok.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Adatok.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Italic);
            dataGridView_Adatok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //-- oszlopok tulajdonságai
            DataGridViewColumn column_kontinens = new DataGridViewColumn();
            {
                column_kontinens.HeaderText = "Kontinens";
                column_kontinens.Name = "kontinens";
                column_kontinens.CellTemplate=new DataGridViewTextBoxCell();
            }
            dataGridView_Adatok.Columns.Add(column_kontinens);
            //-----------------------------------------------------------------------------------------
            DataGridViewColumn column_orszag=new DataGridViewColumn();
            {
                column_orszag.HeaderText = "Ország neve";
                column_orszag.Name = "orszag";
                column_orszag.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView_Adatok.Columns.Add(column_orszag);

            //-----------------------------------------------------------------------------------------
            DataGridViewColumn column_fovaros=new DataGridViewColumn();
            {
                column_fovaros.HeaderText = "Főváros";
                column_fovaros.Name = "fovaros";
                column_fovaros.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView_Adatok.Columns.Add(column_fovaros);

            //-----------------------------------------------------------------------------------------
DataGridViewColumn column_terulet=new DataGridViewColumn();
            {
                column_terulet.HeaderText = "Terület";
                column_terulet.Name = "terulet";
                column_terulet.ValueType = typeof(decimal);
                column_terulet.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleRight;
                column_terulet.DefaultCellStyle.Format = "#,##0.00";
                column_terulet.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView_Adatok.Columns.Add(column_terulet);
        }
    }
}
