namespace WindowsFormsCzigleczky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ForrasFajl = new System.Windows.Forms.TextBox();
            this.button_Betoltes = new System.Windows.Forms.Button();
            this.listBox_Orszagok = new System.Windows.Forms.ListBox();
            this.button_TeruletekAtlaga = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Legfeljebb100ezer = new System.Windows.Forms.RadioButton();
            this.radioButton_100ezernelNagyobb = new System.Windows.Forms.RadioButton();
            this.button_Megszamolas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Kiiras = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_MinimuMaximum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_KeresendoOrszag = new System.Windows.Forms.TextBox();
            this.checkBox_TalalatokJelolese = new System.Windows.Forms.CheckBox();
            this.button_Kereses = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forrásfájl neve";
            // 
            // textBox_ForrasFajl
            // 
            this.textBox_ForrasFajl.Location = new System.Drawing.Point(19, 49);
            this.textBox_ForrasFajl.Name = "textBox_ForrasFajl";
            this.textBox_ForrasFajl.Size = new System.Drawing.Size(306, 38);
            this.textBox_ForrasFajl.TabIndex = 1;
            this.textBox_ForrasFajl.Text = "orszagok.csv";
            // 
            // button_Betoltes
            // 
            this.button_Betoltes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Betoltes.Location = new System.Drawing.Point(19, 102);
            this.button_Betoltes.Name = "button_Betoltes";
            this.button_Betoltes.Size = new System.Drawing.Size(306, 48);
            this.button_Betoltes.TabIndex = 2;
            this.button_Betoltes.Text = "Betöltés";
            this.button_Betoltes.UseVisualStyleBackColor = false;
            this.button_Betoltes.Click += new System.EventHandler(this.button_Betoltes_Click);
            // 
            // listBox_Orszagok
            // 
            this.listBox_Orszagok.FormattingEnabled = true;
            this.listBox_Orszagok.ItemHeight = 31;
            this.listBox_Orszagok.Location = new System.Drawing.Point(19, 166);
            this.listBox_Orszagok.Name = "listBox_Orszagok";
            this.listBox_Orszagok.Size = new System.Drawing.Size(306, 562);
            this.listBox_Orszagok.TabIndex = 3;
            // 
            // button_TeruletekAtlaga
            // 
            this.button_TeruletekAtlaga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_TeruletekAtlaga.Location = new System.Drawing.Point(19, 739);
            this.button_TeruletekAtlaga.Name = "button_TeruletekAtlaga";
            this.button_TeruletekAtlaga.Size = new System.Drawing.Size(306, 56);
            this.button_TeruletekAtlaga.TabIndex = 4;
            this.button_TeruletekAtlaga.Text = "Területek átlaga";
            this.button_TeruletekAtlaga.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Legfeljebb100ezer);
            this.groupBox1.Controls.Add(this.radioButton_100ezernelNagyobb);
            this.groupBox1.Location = new System.Drawing.Point(387, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 149);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mit számoljunk?";
            // 
            // radioButton_Legfeljebb100ezer
            // 
            this.radioButton_Legfeljebb100ezer.AutoSize = true;
            this.radioButton_Legfeljebb100ezer.Location = new System.Drawing.Point(28, 94);
            this.radioButton_Legfeljebb100ezer.Name = "radioButton_Legfeljebb100ezer";
            this.radioButton_Legfeljebb100ezer.Size = new System.Drawing.Size(374, 36);
            this.radioButton_Legfeljebb100ezer.TabIndex = 1;
            this.radioButton_Legfeljebb100ezer.TabStop = true;
            this.radioButton_Legfeljebb100ezer.Text = "legfeljebb 100.000 területű";
            this.radioButton_Legfeljebb100ezer.UseVisualStyleBackColor = true;
            // 
            // radioButton_100ezernelNagyobb
            // 
            this.radioButton_100ezernelNagyobb.AutoSize = true;
            this.radioButton_100ezernelNagyobb.Checked = true;
            this.radioButton_100ezernelNagyobb.Location = new System.Drawing.Point(28, 37);
            this.radioButton_100ezernelNagyobb.Name = "radioButton_100ezernelNagyobb";
            this.radioButton_100ezernelNagyobb.Size = new System.Drawing.Size(407, 36);
            this.radioButton_100ezernelNagyobb.TabIndex = 0;
            this.radioButton_100ezernelNagyobb.TabStop = true;
            this.radioButton_100ezernelNagyobb.Text = "100.000-nél nagyobb területű";
            this.radioButton_100ezernelNagyobb.UseVisualStyleBackColor = true;
            // 
            // button_Megszamolas
            // 
            this.button_Megszamolas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Megszamolas.Location = new System.Drawing.Point(387, 201);
            this.button_Megszamolas.Name = "button_Megszamolas";
            this.button_Megszamolas.Size = new System.Drawing.Size(476, 58);
            this.button_Megszamolas.TabIndex = 6;
            this.button_Megszamolas.Text = "Megszámolás";
            this.button_Megszamolas.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Eredmény fájl neve";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(387, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 38);
            this.textBox1.TabIndex = 8;
            // 
            // button_Kiiras
            // 
            this.button_Kiiras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Kiiras.Location = new System.Drawing.Point(387, 376);
            this.button_Kiiras.Name = "button_Kiiras";
            this.button_Kiiras.Size = new System.Drawing.Size(476, 56);
            this.button_Kiiras.TabIndex = 9;
            this.button_Kiiras.Text = "Kiírás";
            this.button_Kiiras.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Minimum vagy maximum?";
            // 
            // comboBox_MinimuMaximum
            // 
            this.comboBox_MinimuMaximum.FormattingEnabled = true;
            this.comboBox_MinimuMaximum.Items.AddRange(new object[] {
            "Minimum",
            "Maximum"});
            this.comboBox_MinimuMaximum.Location = new System.Drawing.Point(393, 524);
            this.comboBox_MinimuMaximum.Name = "comboBox_MinimuMaximum";
            this.comboBox_MinimuMaximum.Size = new System.Drawing.Size(470, 39);
            this.comboBox_MinimuMaximum.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ország keresése";
            // 
            // textBox_KeresendoOrszag
            // 
            this.textBox_KeresendoOrszag.Location = new System.Drawing.Point(393, 636);
            this.textBox_KeresendoOrszag.Name = "textBox_KeresendoOrszag";
            this.textBox_KeresendoOrszag.Size = new System.Drawing.Size(470, 38);
            this.textBox_KeresendoOrszag.TabIndex = 13;
            // 
            // checkBox_TalalatokJelolese
            // 
            this.checkBox_TalalatokJelolese.AutoSize = true;
            this.checkBox_TalalatokJelolese.Location = new System.Drawing.Point(393, 697);
            this.checkBox_TalalatokJelolese.Name = "checkBox_TalalatokJelolese";
            this.checkBox_TalalatokJelolese.Size = new System.Drawing.Size(389, 36);
            this.checkBox_TalalatokJelolese.TabIndex = 14;
            this.checkBox_TalalatokJelolese.Text = "Találatok jelölése a listában";
            this.checkBox_TalalatokJelolese.UseVisualStyleBackColor = true;
            // 
            // button_Kereses
            // 
            this.button_Kereses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Kereses.Location = new System.Drawing.Point(393, 739);
            this.button_Kereses.Name = "button_Kereses";
            this.button_Kereses.Size = new System.Drawing.Size(476, 56);
            this.button_Kereses.TabIndex = 9;
            this.button_Kereses.Text = "Keresés";
            this.button_Kereses.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(920, 815);
            this.Controls.Add(this.checkBox_TalalatokJelolese);
            this.Controls.Add(this.textBox_KeresendoOrszag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_MinimuMaximum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Kereses);
            this.Controls.Add(this.button_Kiiras);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Megszamolas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_TeruletekAtlaga);
            this.Controls.Add(this.listBox_Orszagok);
            this.Controls.Add(this.button_Betoltes);
            this.Controls.Add(this.textBox_ForrasFajl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Czigleczky könyv példa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ForrasFajl;
        private System.Windows.Forms.Button button_Betoltes;
        private System.Windows.Forms.ListBox listBox_Orszagok;
        private System.Windows.Forms.Button button_TeruletekAtlaga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Legfeljebb100ezer;
        private System.Windows.Forms.RadioButton radioButton_100ezernelNagyobb;
        private System.Windows.Forms.Button button_Megszamolas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Kiiras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_MinimuMaximum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_KeresendoOrszag;
        private System.Windows.Forms.CheckBox checkBox_TalalatokJelolese;
        private System.Windows.Forms.Button button_Kereses;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

