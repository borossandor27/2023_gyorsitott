namespace restapi_retool
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
            this.listBox_Dolgozo = new System.Windows.Forms.ListBox();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_Fizetes = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_Szuletett = new System.Windows.Forms.DateTimePicker();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Fizetes)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Dolgozo
            // 
            this.listBox_Dolgozo.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Dolgozo.FormattingEnabled = true;
            this.listBox_Dolgozo.ItemHeight = 20;
            this.listBox_Dolgozo.Location = new System.Drawing.Point(0, 0);
            this.listBox_Dolgozo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox_Dolgozo.Name = "listBox_Dolgozo";
            this.listBox_Dolgozo.Size = new System.Drawing.Size(222, 413);
            this.listBox_Dolgozo.TabIndex = 0;
            this.listBox_Dolgozo.SelectedIndexChanged += new System.EventHandler(this.listBox_Dolgozo_SelectedIndexChanged);
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(242, 350);
            this.button_Create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(142, 44);
            this.button_Create.TabIndex = 2;
            this.button_Create.Text = "Új";
            this.button_Create.UseVisualStyleBackColor = true;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(416, 350);
            this.button_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(142, 44);
            this.button_Update.TabIndex = 2;
            this.button_Update.Text = "Módosít";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(591, 350);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(142, 44);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Törlés";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown_Fizetes);
            this.groupBox1.Controls.Add(this.dateTimePicker_Szuletett);
            this.groupBox1.Controls.Add(this.textBox_email);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(222, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 318);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dolgozó adatai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fizetés";
            // 
            // numericUpDown_Fizetes
            // 
            this.numericUpDown_Fizetes.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Fizetes.Location = new System.Drawing.Point(156, 246);
            this.numericUpDown_Fizetes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown_Fizetes.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_Fizetes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Fizetes.Name = "numericUpDown_Fizetes";
            this.numericUpDown_Fizetes.Size = new System.Drawing.Size(290, 26);
            this.numericUpDown_Fizetes.TabIndex = 13;
            this.numericUpDown_Fizetes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Fizetes.ThousandsSeparator = true;
            this.numericUpDown_Fizetes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePicker_Szuletett
            // 
            this.dateTimePicker_Szuletett.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Szuletett.Location = new System.Drawing.Point(156, 196);
            this.dateTimePicker_Szuletett.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_Szuletett.Name = "dateTimePicker_Szuletett";
            this.dateTimePicker_Szuletett.Size = new System.Drawing.Size(151, 26);
            this.dateTimePicker_Szuletett.TabIndex = 12;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(156, 146);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(290, 26);
            this.textBox_email.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Született";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(156, 96);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(290, 26);
            this.textBox_name.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Név";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(156, 46);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(112, 26);
            this.textBox_id.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.listBox_Dolgozo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "REST API példa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Fizetes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Dolgozo;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_Fizetes;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Szuletett;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
    }
}

