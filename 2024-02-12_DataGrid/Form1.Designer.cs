namespace _2024_02_12_DataGrid
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_Adatok = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_kontinens = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_orszag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Fovaros = new System.Windows.Forms.TextBox();
            this.numericUpDown_Terulet = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Mertekegyseg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Adatok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Terulet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Mertekegyseg);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericUpDown_Terulet);
            this.panel1.Controls.Add(this.textBox_Fovaros);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_orszag);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_kontinens);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 450);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_Adatok
            // 
            this.dataGridView_Adatok.AllowUserToAddRows = false;
            this.dataGridView_Adatok.AllowUserToDeleteRows = false;
            this.dataGridView_Adatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Adatok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Adatok.Location = new System.Drawing.Point(294, 0);
            this.dataGridView_Adatok.Name = "dataGridView_Adatok";
            this.dataGridView_Adatok.ReadOnly = true;
            this.dataGridView_Adatok.RowHeadersWidth = 62;
            this.dataGridView_Adatok.RowTemplate.Height = 28;
            this.dataGridView_Adatok.Size = new System.Drawing.Size(1229, 450);
            this.dataGridView_Adatok.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kontinens";
            // 
            // textBox_kontinens
            // 
            this.textBox_kontinens.Location = new System.Drawing.Point(17, 37);
            this.textBox_kontinens.Name = "textBox_kontinens";
            this.textBox_kontinens.Size = new System.Drawing.Size(245, 26);
            this.textBox_kontinens.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ország";
            // 
            // textBox_orszag
            // 
            this.textBox_orszag.Location = new System.Drawing.Point(24, 118);
            this.textBox_orszag.Name = "textBox_orszag";
            this.textBox_orszag.Size = new System.Drawing.Size(238, 26);
            this.textBox_orszag.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Főváros";
            // 
            // textBox_Fovaros
            // 
            this.textBox_Fovaros.Location = new System.Drawing.Point(24, 202);
            this.textBox_Fovaros.Name = "textBox_Fovaros";
            this.textBox_Fovaros.Size = new System.Drawing.Size(238, 26);
            this.textBox_Fovaros.TabIndex = 5;
            // 
            // numericUpDown_Terulet
            // 
            this.numericUpDown_Terulet.DecimalPlaces = 2;
            this.numericUpDown_Terulet.Location = new System.Drawing.Point(24, 272);
            this.numericUpDown_Terulet.Name = "numericUpDown_Terulet";
            this.numericUpDown_Terulet.Size = new System.Drawing.Size(176, 26);
            this.numericUpDown_Terulet.TabIndex = 6;
            this.numericUpDown_Terulet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Terület";
            // 
            // label_Mertekegyseg
            // 
            this.label_Mertekegyseg.AutoSize = true;
            this.label_Mertekegyseg.Location = new System.Drawing.Point(206, 274);
            this.label_Mertekegyseg.Name = "label_Mertekegyseg";
            this.label_Mertekegyseg.Size = new System.Drawing.Size(51, 20);
            this.label_Mertekegyseg.TabIndex = 8;
            this.label_Mertekegyseg.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 450);
            this.Controls.Add(this.dataGridView_Adatok);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Adatok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Terulet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Adatok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_Terulet;
        private System.Windows.Forms.TextBox textBox_Fovaros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_orszag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_kontinens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Mertekegyseg;
    }
}

