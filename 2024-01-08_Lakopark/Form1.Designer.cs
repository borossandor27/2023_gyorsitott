namespace _2024_01_08_Lakopark
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
            this.pictureBox_nevado = new System.Windows.Forms.PictureBox();
            this.panel_Epuletek = new System.Windows.Forms.Panel();
            this.button_Balra = new System.Windows.Forms.Button();
            this.button_Jobbra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_nevado)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_nevado
            // 
            this.pictureBox_nevado.Location = new System.Drawing.Point(13, 13);
            this.pictureBox_nevado.Name = "pictureBox_nevado";
            this.pictureBox_nevado.Size = new System.Drawing.Size(147, 179);
            this.pictureBox_nevado.TabIndex = 0;
            this.pictureBox_nevado.TabStop = false;
            // 
            // panel_Epuletek
            // 
            this.panel_Epuletek.Location = new System.Drawing.Point(203, 13);
            this.panel_Epuletek.Name = "panel_Epuletek";
            this.panel_Epuletek.Size = new System.Drawing.Size(522, 289);
            this.panel_Epuletek.TabIndex = 1;
            // 
            // button_Balra
            // 
            this.button_Balra.BackgroundImage = global::_2024_01_08_Lakopark.Properties.Resources.balnyil;
            this.button_Balra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Balra.Location = new System.Drawing.Point(49, 426);
            this.button_Balra.Name = "button_Balra";
            this.button_Balra.Size = new System.Drawing.Size(120, 67);
            this.button_Balra.TabIndex = 2;
            this.button_Balra.UseVisualStyleBackColor = true;
            this.button_Balra.Click += new System.EventHandler(this.button_Balra_Click);
            // 
            // button_Jobbra
            // 
            this.button_Jobbra.BackgroundImage = global::_2024_01_08_Lakopark.Properties.Resources.jobbnyil;
            this.button_Jobbra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Jobbra.Location = new System.Drawing.Point(203, 426);
            this.button_Jobbra.Name = "button_Jobbra";
            this.button_Jobbra.Size = new System.Drawing.Size(120, 67);
            this.button_Jobbra.TabIndex = 2;
            this.button_Jobbra.UseVisualStyleBackColor = true;
            this.button_Jobbra.Click += new System.EventHandler(this.button_Jobbra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 545);
            this.Controls.Add(this.button_Jobbra);
            this.Controls.Add(this.button_Balra);
            this.Controls.Add(this.panel_Epuletek);
            this.Controls.Add(this.pictureBox_nevado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_nevado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_nevado;
        private System.Windows.Forms.Panel panel_Epuletek;
        private System.Windows.Forms.Button button_Balra;
        private System.Windows.Forms.Button button_Jobbra;
    }
}

