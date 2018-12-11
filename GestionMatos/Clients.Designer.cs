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
            this.comboBoxNom1.Location = new System.Drawing.Point(81, 42);
            this.comboBoxNom1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxNom1.Name = "comboBoxNom1";
            this.comboBoxNom1.Size = new System.Drawing.Size(82, 21);
            this.comboBoxNom1.TabIndex = 0;
            this.comboBoxNom1.Text = "Nom";
            // 
            // comboBoxTel
            // 
            this.comboBoxTel.FormattingEnabled = true;
            this.comboBoxTel.Location = new System.Drawing.Point(81, 108);
            this.comboBoxTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTel.Name = "comboBoxTel";
            this.comboBoxTel.Size = new System.Drawing.Size(82, 21);
            this.comboBoxTel.TabIndex = 1;
            this.comboBoxTel.Text = "Tél";
            // 
            // comboBoxEmail
            // 
            this.comboBoxEmail.FormattingEnabled = true;
            this.comboBoxEmail.Location = new System.Drawing.Point(81, 168);
            this.comboBoxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(82, 21);
            this.comboBoxEmail.TabIndex = 2;
            this.comboBoxEmail.Text = "email";
            // 
            // comboBoxAdresse
            // 
            this.comboBoxAdresse.FormattingEnabled = true;
            this.comboBoxAdresse.Location = new System.Drawing.Point(328, 42);
            this.comboBoxAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAdresse.Name = "comboBoxAdresse";
            this.comboBoxAdresse.Size = new System.Drawing.Size(82, 21);
            this.comboBoxAdresse.TabIndex = 3;
            this.comboBoxAdresse.Text = "Adresse";
            // 
            // comboBoxCodePostal
            // 
            this.comboBoxCodePostal.FormattingEnabled = true;
            this.comboBoxCodePostal.Location = new System.Drawing.Point(328, 108);
            this.comboBoxCodePostal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCodePostal.Name = "comboBoxCodePostal";
            this.comboBoxCodePostal.Size = new System.Drawing.Size(82, 21);
            this.comboBoxCodePostal.TabIndex = 4;
            this.comboBoxCodePostal.Text = "Code Postal";
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(328, 168);
            this.comboBoxVille.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(82, 21);
            this.comboBoxVille.TabIndex = 5;
            this.comboBoxVille.Text = "Ville";
            // 
            // buttonOk1
            // 
            this.buttonOk1.Location = new System.Drawing.Point(438, 223);
            this.buttonOk1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOk1.Name = "buttonOk1";
            this.buttonOk1.Size = new System.Drawing.Size(35, 27);
            this.buttonOk1.TabIndex = 6;
            this.buttonOk1.Text = "OK";
            this.buttonOk1.UseVisualStyleBackColor = true;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.buttonOk1);
            this.Controls.Add(this.comboBoxVille);
            this.Controls.Add(this.comboBoxCodePostal);
            this.Controls.Add(this.comboBoxAdresse);
            this.Controls.Add(this.comboBoxEmail);
            this.Controls.Add(this.comboBoxTel);
            this.Controls.Add(this.comboBoxNom1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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