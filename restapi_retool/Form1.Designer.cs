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
            this.listBox_Dolgozo = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Szuletett = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_Fizetes = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Fizetes)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Dolgozo
            // 
            this.listBox_Dolgozo.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Dolgozo.FormattingEnabled = true;
            this.listBox_Dolgozo.ItemHeight = 16;
            this.listBox_Dolgozo.Location = new System.Drawing.Point(0, 0);
            this.listBox_Dolgozo.Name = "listBox_Dolgozo";
            this.listBox_Dolgozo.Size = new System.Drawing.Size(198, 339);
            this.listBox_Dolgozo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericUpDown_Fizetes);
            this.panel1.Controls.Add(this.dateTimePicker_Szuletett);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(198, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 257);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(103, 23);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Név";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(103, 63);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(258, 22);
            this.textBox_name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 22);
            this.textBox1.TabIndex = 1;
            // 
            // dateTimePicker_Szuletett
            // 
            this.dateTimePicker_Szuletett.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Szuletett.Location = new System.Drawing.Point(103, 143);
            this.dateTimePicker_Szuletett.Name = "dateTimePicker_Szuletett";
            this.dateTimePicker_Szuletett.Size = new System.Drawing.Size(135, 22);
            this.dateTimePicker_Szuletett.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Született";
            // 
            // numericUpDown_Fizetes
            // 
            this.numericUpDown_Fizetes.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Fizetes.Location = new System.Drawing.Point(103, 183);
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
            this.numericUpDown_Fizetes.Size = new System.Drawing.Size(258, 22);
            this.numericUpDown_Fizetes.TabIndex = 3;
            this.numericUpDown_Fizetes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Fizetes.ThousandsSeparator = true;
            this.numericUpDown_Fizetes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fizetés";
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(215, 280);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(126, 35);
            this.button_Create.TabIndex = 2;
            this.button_Create.Text = "Új";
            this.button_Create.UseVisualStyleBackColor = true;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(370, 280);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(126, 35);
            this.button_Update.TabIndex = 2;
            this.button_Update.Text = "Módosít";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(525, 280);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(126, 35);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Törlés";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 339);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox_Dolgozo);
            this.Name = "Form1";
            this.Text = "REST API példa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Fizetes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Dolgozo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Szuletett;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_Fizetes;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
    }
}

