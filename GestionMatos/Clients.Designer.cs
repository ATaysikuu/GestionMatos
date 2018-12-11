namespace GestionMatos
{
    partial class Clients
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
            this.comboBoxNom1 = new System.Windows.Forms.ComboBox();
            this.comboBoxTel = new System.Windows.Forms.ComboBox();
            this.comboBoxEmail = new System.Windows.Forms.ComboBox();
            this.comboBoxAdresse = new System.Windows.Forms.ComboBox();
            this.comboBoxCodePostal = new System.Windows.Forms.ComboBox();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.buttonOk1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxNom1
            // 
            this.comboBoxNom1.FormattingEnabled = true;
            this.comboBoxNom1.Location = new System.Drawing.Point(122, 64);
            this.comboBoxNom1.Name = "comboBoxNom1";
            this.comboBoxNom1.Size = new System.Drawing.Size(121, 28);
            this.comboBoxNom1.TabIndex = 0;
            this.comboBoxNom1.Text = "Nom";
            // 
            // comboBoxTel
            // 
            this.comboBoxTel.FormattingEnabled = true;
            this.comboBoxTel.Location = new System.Drawing.Point(122, 166);
            this.comboBoxTel.Name = "comboBoxTel";
            this.comboBoxTel.Size = new System.Drawing.Size(121, 28);
            this.comboBoxTel.TabIndex = 1;
            this.comboBoxTel.Text = "Tél";
            // 
            // comboBoxEmail
            // 
            this.comboBoxEmail.FormattingEnabled = true;
            this.comboBoxEmail.Location = new System.Drawing.Point(122, 258);
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(121, 28);
            this.comboBoxEmail.TabIndex = 2;
            this.comboBoxEmail.Text = "email";
            // 
            // comboBoxAdresse
            // 
            this.comboBoxAdresse.FormattingEnabled = true;
            this.comboBoxAdresse.Location = new System.Drawing.Point(492, 64);
            this.comboBoxAdresse.Name = "comboBoxAdresse";
            this.comboBoxAdresse.Size = new System.Drawing.Size(121, 28);
            this.comboBoxAdresse.TabIndex = 3;
            this.comboBoxAdresse.Text = "Adresse";
            // 
            // comboBoxCodePostal
            // 
            this.comboBoxCodePostal.FormattingEnabled = true;
            this.comboBoxCodePostal.Location = new System.Drawing.Point(492, 166);
            this.comboBoxCodePostal.Name = "comboBoxCodePostal";
            this.comboBoxCodePostal.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCodePostal.TabIndex = 4;
            this.comboBoxCodePostal.Text = "Code Postal";
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(492, 258);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(121, 28);
            this.comboBoxVille.TabIndex = 5;
            this.comboBoxVille.Text = "Ville";
            // 
            // buttonOk1
            // 
            this.buttonOk1.Location = new System.Drawing.Point(679, 369);
            this.buttonOk1.Name = "buttonOk1";
            this.buttonOk1.Size = new System.Drawing.Size(52, 42);
            this.buttonOk1.TabIndex = 6;
            this.buttonOk1.Text = "OK";
            this.buttonOk1.UseVisualStyleBackColor = true;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOk1);
            this.Controls.Add(this.comboBoxVille);
            this.Controls.Add(this.comboBoxCodePostal);
            this.Controls.Add(this.comboBoxAdresse);
            this.Controls.Add(this.comboBoxEmail);
            this.Controls.Add(this.comboBoxTel);
            this.Controls.Add(this.comboBoxNom1);
            this.Name = "Clients";
            this.Text = "CLIENT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNom1;
        private System.Windows.Forms.ComboBox comboBoxTel;
        private System.Windows.Forms.ComboBox comboBoxEmail;
        private System.Windows.Forms.ComboBox comboBoxAdresse;
        private System.Windows.Forms.ComboBox comboBoxCodePostal;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.Button buttonOk1;
    }
}