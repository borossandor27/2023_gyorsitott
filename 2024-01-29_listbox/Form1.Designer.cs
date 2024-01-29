namespace _2024_01_29_listbox
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
            this.listBox_Dolgozok = new System.Windows.Forms.ListBox();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Dolgozok
            // 
            this.listBox_Dolgozok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Dolgozok.FormattingEnabled = true;
            this.listBox_Dolgozok.ItemHeight = 20;
            this.listBox_Dolgozok.Location = new System.Drawing.Point(0, 0);
            this.listBox_Dolgozok.Name = "listBox_Dolgozok";
            this.listBox_Dolgozok.Size = new System.Drawing.Size(355, 450);
            this.listBox_Dolgozok.TabIndex = 0;
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(428, 22);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(321, 47);
            this.button_Load.TabIndex = 1;
            this.button_Load.Text = "Betöltés";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(428, 92);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(321, 47);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Mentés";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(428, 160);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(321, 47);
            this.button_Insert.TabIndex = 1;
            this.button_Insert.Text = "Új";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(428, 228);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(321, 47);
            this.button_Update.TabIndex = 1;
            this.button_Update.Text = "Módosítás";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(428, 297);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(321, 47);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "Törlés";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.listBox_Dolgozok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dolgozók nyivántartása";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        public System.Windows.Forms.ListBox listBox_Dolgozok;
    }
}

