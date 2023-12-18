namespace MultiForm
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_FelhasznaloNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Jelszo = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév";
            // 
            // textBox_FelhasznaloNev
            // 
            this.textBox_FelhasznaloNev.Location = new System.Drawing.Point(230, 45);
            this.textBox_FelhasznaloNev.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_FelhasznaloNev.Name = "textBox_FelhasznaloNev";
            this.textBox_FelhasznaloNev.Size = new System.Drawing.Size(269, 34);
            this.textBox_FelhasznaloNev.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(43, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jelszó";
            // 
            // textBox_Jelszo
            // 
            this.textBox_Jelszo.Location = new System.Drawing.Point(230, 111);
            this.textBox_Jelszo.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_Jelszo.Name = "textBox_Jelszo";
            this.textBox_Jelszo.Size = new System.Drawing.Size(269, 34);
            this.textBox_Jelszo.TabIndex = 2;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(48, 202);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(461, 67);
            this.button_Login.TabIndex = 3;
            this.button_Login.Text = "Belépés";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 331);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Jelszo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_FelhasznaloNev);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormLogin";
            this.Text = "Belépés";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_FelhasznaloNev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Jelszo;
        private System.Windows.Forms.Button button_Login;
    }
}

