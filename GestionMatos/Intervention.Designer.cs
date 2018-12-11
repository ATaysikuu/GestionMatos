namespace GestionMatos
{
    partial class Intervention
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxID_Technicien = new System.Windows.Forms.ComboBox();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxListeSites = new System.Windows.Forms.ComboBox();
            this.comboBoxMateriels = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(192, 33);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Date d\'intervention";
            // 
            // comboBoxID_Technicien
            // 
            this.comboBoxID_Technicien.FormattingEnabled = true;
            this.comboBoxID_Technicien.Location = new System.Drawing.Point(12, 232);
            this.comboBoxID_Technicien.Name = "comboBoxID_Technicien";
            this.comboBoxID_Technicien.Size = new System.Drawing.Size(121, 28);
            this.comboBoxID_Technicien.TabIndex = 2;
            this.comboBoxID_Technicien.Text = "ID technicien";
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(522, 49);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(179, 28);
            this.comboBoxClients.TabIndex = 3;
            this.comboBoxClients.Text = "Liste des clients";
            // 
            // comboBoxListeSites
            // 
            this.comboBoxListeSites.FormattingEnabled = true;
            this.comboBoxListeSites.Location = new System.Drawing.Point(522, 172);
            this.comboBoxListeSites.Name = "comboBoxListeSites";
            this.comboBoxListeSites.Size = new System.Drawing.Size(167, 28);
            this.comboBoxListeSites.TabIndex = 4;
            this.comboBoxListeSites.Text = "Liste de sites";
            // 
            // comboBoxMateriels
            // 
            this.comboBoxMateriels.FormattingEnabled = true;
            this.comboBoxMateriels.Location = new System.Drawing.Point(522, 317);
            this.comboBoxMateriels.Name = "comboBoxMateriels";
            this.comboBoxMateriels.Size = new System.Drawing.Size(167, 28);
            this.comboBoxMateriels.TabIndex = 5;
            this.comboBoxMateriels.Text = "Liste de matériels";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(653, 391);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 47);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // Intervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxMateriels);
            this.Controls.Add(this.comboBoxListeSites);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.comboBoxID_Technicien);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Intervention";
            this.Text = "Intervention";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBoxID_Technicien;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxListeSites;
        private System.Windows.Forms.ComboBox comboBoxMateriels;
        private System.Windows.Forms.Button buttonOk;
    }
}