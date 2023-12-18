namespace MultiForm
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dolgozóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_egyeb = new System.Windows.Forms.RadioButton();
            this.radioButton_Ferfi = new System.Windows.Forms.RadioButton();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_Szuletesidatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DolgozoNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DolgozoId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Dolgozok = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dolgozóToolStripMenuItem,
            this.termékToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dolgozóToolStripMenuItem
            // 
            this.dolgozóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.módosításToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.dolgozóToolStripMenuItem.Name = "dolgozóToolStripMenuItem";
            this.dolgozóToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.dolgozóToolStripMenuItem.Text = "Dolgozó";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.törlésToolStripMenuItem.Text = "Törlés";
            // 
            // termékToolStripMenuItem
            // 
            this.termékToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem1,
            this.módosításToolStripMenuItem1,
            this.törlésToolStripMenuItem1});
            this.termékToolStripMenuItem.Name = "termékToolStripMenuItem";
            this.termékToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.termékToolStripMenuItem.Text = "Termék";
            // 
            // újToolStripMenuItem1
            // 
            this.újToolStripMenuItem1.Name = "újToolStripMenuItem1";
            this.újToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.újToolStripMenuItem1.Text = "Új";
            // 
            // módosításToolStripMenuItem1
            // 
            this.módosításToolStripMenuItem1.Name = "módosításToolStripMenuItem1";
            this.módosításToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.módosításToolStripMenuItem1.Text = "Módosítás";
            // 
            // törlésToolStripMenuItem1
            // 
            this.törlésToolStripMenuItem1.Name = "törlésToolStripMenuItem1";
            this.törlésToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.törlésToolStripMenuItem1.Text = "Törlés";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_egyeb);
            this.groupBox1.Controls.Add(this.radioButton_Ferfi);
            this.groupBox1.Controls.Add(this.radioButton_No);
            this.groupBox1.Controls.Add(this.dateTimePicker_Szuletesidatum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_DolgozoNev);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_DolgozoId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(425, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 316);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott dolgozó";
            // 
            // radioButton_egyeb
            // 
            this.radioButton_egyeb.AutoSize = true;
            this.radioButton_egyeb.Location = new System.Drawing.Point(366, 247);
            this.radioButton_egyeb.Name = "radioButton_egyeb";
            this.radioButton_egyeb.Size = new System.Drawing.Size(101, 33);
            this.radioButton_egyeb.TabIndex = 5;
            this.radioButton_egyeb.TabStop = true;
            this.radioButton_egyeb.Text = "egyéb";
            this.radioButton_egyeb.UseVisualStyleBackColor = true;
            // 
            // radioButton_Ferfi
            // 
            this.radioButton_Ferfi.AutoSize = true;
            this.radioButton_Ferfi.Location = new System.Drawing.Point(205, 247);
            this.radioButton_Ferfi.Name = "radioButton_Ferfi";
            this.radioButton_Ferfi.Size = new System.Drawing.Size(83, 33);
            this.radioButton_Ferfi.TabIndex = 4;
            this.radioButton_Ferfi.TabStop = true;
            this.radioButton_Ferfi.Text = "Férfi";
            this.radioButton_Ferfi.UseVisualStyleBackColor = true;
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Location = new System.Drawing.Point(57, 247);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(66, 33);
            this.radioButton_No.TabIndex = 4;
            this.radioButton_No.TabStop = true;
            this.radioButton_No.Text = "Nő";
            this.radioButton_No.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_Szuletesidatum
            // 
            this.dateTimePicker_Szuletesidatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Szuletesidatum.Location = new System.Drawing.Point(220, 166);
            this.dateTimePicker_Szuletesidatum.Name = "dateTimePicker_Szuletesidatum";
            this.dateTimePicker_Szuletesidatum.Size = new System.Drawing.Size(193, 34);
            this.dateTimePicker_Szuletesidatum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Születési dátum";
            // 
            // textBox_DolgozoNev
            // 
            this.textBox_DolgozoNev.Location = new System.Drawing.Point(137, 108);
            this.textBox_DolgozoNev.Name = "textBox_DolgozoNev";
            this.textBox_DolgozoNev.Size = new System.Drawing.Size(276, 34);
            this.textBox_DolgozoNev.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Név";
            // 
            // textBox_DolgozoId
            // 
            this.textBox_DolgozoId.Location = new System.Drawing.Point(137, 43);
            this.textBox_DolgozoId.Name = "textBox_DolgozoId";
            this.textBox_DolgozoId.ReadOnly = true;
            this.textBox_DolgozoId.Size = new System.Drawing.Size(100, 34);
            this.textBox_DolgozoId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "id";
            // 
            // listBox_Dolgozok
            // 
            this.listBox_Dolgozok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Dolgozok.FormattingEnabled = true;
            this.listBox_Dolgozok.ItemHeight = 29;
            this.listBox_Dolgozok.Location = new System.Drawing.Point(0, 28);
            this.listBox_Dolgozok.Name = "listBox_Dolgozok";
            this.listBox_Dolgozok.Size = new System.Drawing.Size(367, 548);
            this.listBox_Dolgozok.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 576);
            this.Controls.Add(this.listBox_Dolgozok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dolgozóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem termékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Szuletesidatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DolgozoNev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DolgozoId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_egyeb;
        private System.Windows.Forms.RadioButton radioButton_Ferfi;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.ListBox listBox_Dolgozok;
    }
}