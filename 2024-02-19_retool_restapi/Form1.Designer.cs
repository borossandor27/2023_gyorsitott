namespace _2024_02_19_retool_restapi
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
            this.listBox_Vasarlasok = new System.Windows.Forms.ListBox();
            this.groupBox_Payment = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Read = new System.Windows.Forms.Button();
            this.button_Create = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Payment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Vasarlasok
            // 
            this.listBox_Vasarlasok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Vasarlasok.FormattingEnabled = true;
            this.listBox_Vasarlasok.ItemHeight = 16;
            this.listBox_Vasarlasok.Location = new System.Drawing.Point(0, 0);
            this.listBox_Vasarlasok.Name = "listBox_Vasarlasok";
            this.listBox_Vasarlasok.Size = new System.Drawing.Size(221, 344);
            this.listBox_Vasarlasok.TabIndex = 0;
            this.listBox_Vasarlasok.SelectedIndexChanged += new System.EventHandler(this.listBox_Vasarlasok_SelectedIndexChanged);
            // 
            // groupBox_Payment
            // 
            this.groupBox_Payment.Controls.Add(this.label6);
            this.groupBox_Payment.Controls.Add(this.button_Delete);
            this.groupBox_Payment.Controls.Add(this.button_Update);
            this.groupBox_Payment.Controls.Add(this.button_Read);
            this.groupBox_Payment.Controls.Add(this.button_Create);
            this.groupBox_Payment.Controls.Add(this.label5);
            this.groupBox_Payment.Controls.Add(this.dateTimePicker_date);
            this.groupBox_Payment.Controls.Add(this.numericUpDown1);
            this.groupBox_Payment.Controls.Add(this.label4);
            this.groupBox_Payment.Controls.Add(this.label3);
            this.groupBox_Payment.Controls.Add(this.comboBox_Gender);
            this.groupBox_Payment.Controls.Add(this.textBox_Name);
            this.groupBox_Payment.Controls.Add(this.label2);
            this.groupBox_Payment.Controls.Add(this.textBox_id);
            this.groupBox_Payment.Controls.Add(this.label1);
            this.groupBox_Payment.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Payment.Location = new System.Drawing.Point(221, 0);
            this.groupBox_Payment.Name = "groupBox_Payment";
            this.groupBox_Payment.Size = new System.Drawing.Size(557, 866);
            this.groupBox_Payment.TabIndex = 1;
            this.groupBox_Payment.TabStop = false;
            this.groupBox_Payment.Text = "Kiválasztott vásárlás";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "€";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(401, 267);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(89, 37);
            this.button_Delete.TabIndex = 12;
            this.button_Delete.Text = "Törlés";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(276, 270);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(89, 37);
            this.button_Update.TabIndex = 11;
            this.button_Update.Text = "Módosít";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(149, 273);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(89, 37);
            this.button_Read.TabIndex = 10;
            this.button_Read.Text = "Olvasás";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(39, 273);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(89, 37);
            this.button_Create.TabIndex = 9;
            this.button_Create.Text = "Új";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dátum";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Checked = false;
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_date.Location = new System.Drawing.Point(125, 216);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.ShowCheckBox = true;
            this.dateTimePicker_date.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_date.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(125, 165);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Összeg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nem";
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Ferfi",
            "No"});
            this.comboBox_Gender.Location = new System.Drawing.Point(125, 120);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Gender.TabIndex = 3;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(125, 80);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(216, 22);
            this.textBox_Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(125, 30);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(122, 22);
            this.textBox_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 344);
            this.Controls.Add(this.groupBox_Payment);
            this.Controls.Add(this.listBox_Vasarlasok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Payment.ResumeLayout(false);
            this.groupBox_Payment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Vasarlasok;
        private System.Windows.Forms.GroupBox groupBox_Payment;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label6;
    }
}

