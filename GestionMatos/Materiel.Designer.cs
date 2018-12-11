namespace GestionMatos
{
    partial class Materiel
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
            this.comboBoxNom2 = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxMarque = new System.Windows.Forms.ComboBox();
            this.comboBoxNumSerie2 = new System.Windows.Forms.ComboBox();
            this.comboBoxMTBF = new System.Windows.Forms.ComboBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.buttonOk2 = new System.Windows.Forms.Button();
            this.Supp1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxNom2
            // 
            this.comboBoxNom2.FormattingEnabled = true;
            this.comboBoxNom2.Location = new System.Drawing.Point(84, 86);
            this.comboBoxNom2.Name = "comboBoxNom2";
            this.comboBoxNom2.Size = new System.Drawing.Size(121, 28);
            this.comboBoxNom2.TabIndex = 0;
            this.comboBoxNom2.Text = "Nom";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(84, 187);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 28);
            this.comboBoxType.TabIndex = 1;
            this.comboBoxType.Text = "Type";
            // 
            // comboBoxMarque
            // 
            this.comboBoxMarque.FormattingEnabled = true;
            this.comboBoxMarque.Location = new System.Drawing.Point(84, 276);
            this.comboBoxMarque.Name = "comboBoxMarque";
            this.comboBoxMarque.Size = new System.Drawing.Size(121, 28);
            this.comboBoxMarque.TabIndex = 2;
            this.comboBoxMarque.Text = "Marque";
            // 
            // comboBoxNumSerie2
            // 
            this.comboBoxNumSerie2.FormattingEnabled = true;
            this.comboBoxNumSerie2.Location = new System.Drawing.Point(490, 86);
            this.comboBoxNumSerie2.Name = "comboBoxNumSerie2";
            this.comboBoxNumSerie2.Size = new System.Drawing.Size(121, 28);
            this.comboBoxNumSerie2.TabIndex = 3;
            this.comboBoxNumSerie2.Text = "Numéro de série";
            // 
            // comboBoxMTBF
            // 
            this.comboBoxMTBF.FormattingEnabled = true;
            this.comboBoxMTBF.Location = new System.Drawing.Point(490, 187);
            this.comboBoxMTBF.Name = "comboBoxMTBF";
            this.comboBoxMTBF.Size = new System.Drawing.Size(121, 28);
            this.comboBoxMTBF.TabIndex = 4;
            this.comboBoxMTBF.Text = "MTBF";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(490, 276);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(121, 28);
            this.comboBoxClient.TabIndex = 5;
            this.comboBoxClient.Text = "Client";
            // 
            // buttonOk2
            // 
            this.buttonOk2.Location = new System.Drawing.Point(604, 366);
            this.buttonOk2.Name = "buttonOk2";
            this.buttonOk2.Size = new System.Drawing.Size(75, 35);
            this.buttonOk2.TabIndex = 6;
            this.buttonOk2.Text = "OK";
            this.buttonOk2.UseVisualStyleBackColor = true;
            // 
            // Supp1
            // 
            this.Supp1.Location = new System.Drawing.Point(695, 366);
            this.Supp1.Name = "Supp1";
            this.Supp1.Size = new System.Drawing.Size(93, 35);
            this.Supp1.TabIndex = 7;
            this.Supp1.Text = "Supprimer";
            this.Supp1.UseVisualStyleBackColor = true;
            // 
            // Materiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Supp1);
            this.Controls.Add(this.buttonOk2);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.comboBoxMTBF);
            this.Controls.Add(this.comboBoxNumSerie2);
            this.Controls.Add(this.comboBoxMarque);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxNom2);
            this.Name = "Materiel";
            this.Text = "MATERIEL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNom2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxMarque;
        private System.Windows.Forms.ComboBox comboBoxNumSerie2;
        private System.Windows.Forms.ComboBox comboBoxMTBF;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Button buttonOk2;
        private System.Windows.Forms.Button Supp1;
    }
}