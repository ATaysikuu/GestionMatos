namespace GestionMatos
{
    partial class F_Intervention
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
            this.comboBoxID_Technicien = new System.Windows.Forms.ComboBox();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxListeSites = new System.Windows.Forms.ComboBox();
            this.comboBoxMateriels = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.lb_dateIntervention = new System.Windows.Forms.Label();
            this.lb_technicien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(53, 56);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // comboBoxID_Technicien
            // 
            this.comboBoxID_Technicien.FormattingEnabled = true;
            this.comboBoxID_Technicien.Location = new System.Drawing.Point(53, 119);
            this.comboBoxID_Technicien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxID_Technicien.Name = "comboBoxID_Technicien";
            this.comboBoxID_Technicien.Size = new System.Drawing.Size(135, 21);
            this.comboBoxID_Technicien.TabIndex = 2;
            this.comboBoxID_Technicien.Text = "ID technicien";
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(279, 34);
            this.comboBoxClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClients.TabIndex = 3;
            this.comboBoxClients.Text = "Liste des clients";
            // 
            // comboBoxListeSites
            // 
            this.comboBoxListeSites.FormattingEnabled = true;
            this.comboBoxListeSites.Location = new System.Drawing.Point(279, 83);
            this.comboBoxListeSites.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxListeSites.Name = "comboBoxListeSites";
            this.comboBoxListeSites.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListeSites.TabIndex = 4;
            this.comboBoxListeSites.Text = "Liste de sites";
            // 
            // comboBoxMateriels
            // 
            this.comboBoxMateriels.FormattingEnabled = true;
            this.comboBoxMateriels.Location = new System.Drawing.Point(279, 138);
            this.comboBoxMateriels.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxMateriels.Name = "comboBoxMateriels";
            this.comboBoxMateriels.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMateriels.TabIndex = 5;
            this.comboBoxMateriels.Text = "Liste de matériels";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(398, 220);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 30);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // lb_dateIntervention
            // 
            this.lb_dateIntervention.AutoSize = true;
            this.lb_dateIntervention.Location = new System.Drawing.Point(53, 41);
            this.lb_dateIntervention.Name = "lb_dateIntervention";
            this.lb_dateIntervention.Size = new System.Drawing.Size(96, 13);
            this.lb_dateIntervention.TabIndex = 7;
            this.lb_dateIntervention.Text = "Date d\'intervention";
            // 
            // lb_technicien
            // 
            this.lb_technicien.AutoSize = true;
            this.lb_technicien.Location = new System.Drawing.Point(53, 104);
            this.lb_technicien.Name = "lb_technicien";
            this.lb_technicien.Size = new System.Drawing.Size(99, 13);
            this.lb_technicien.TabIndex = 8;
            this.lb_technicien.Text = "Technicien assigné";
            // 
            // Intervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.lb_technicien);
            this.Controls.Add(this.lb_dateIntervention);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxMateriels);
            this.Controls.Add(this.comboBoxListeSites);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.comboBoxID_Technicien);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Intervention";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Intervention";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxID_Technicien;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxListeSites;
        private System.Windows.Forms.ComboBox comboBoxMateriels;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label lb_dateIntervention;
        private System.Windows.Forms.Label lb_technicien;
    }
}