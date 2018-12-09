﻿namespace GestionMatos
{
    partial class MainForm
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.tabC_listeInter = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lsb_listeInter = new System.Windows.Forms.ListBox();
            this.btn_editInter = new System.Windows.Forms.Button();
            this.btn_addInter = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.tabC_listeInter.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(951, 511);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(100, 28);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "CLOSE";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // tabC_listeInter
            // 
            this.tabC_listeInter.Controls.Add(this.tabPage1);
            this.tabC_listeInter.Controls.Add(this.tab);
            this.tabC_listeInter.Controls.Add(this.tabPage2);
            this.tabC_listeInter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabC_listeInter.Location = new System.Drawing.Point(0, 0);
            this.tabC_listeInter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabC_listeInter.Name = "tabC_listeInter";
            this.tabC_listeInter.SelectedIndex = 0;
            this.tabC_listeInter.Size = new System.Drawing.Size(1067, 554);
            this.tabC_listeInter.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lsb_listeInter);
            this.tabPage1.Controls.Add(this.btn_editInter);
            this.tabPage1.Controls.Add(this.btn_addInter);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1059, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Liste des interventions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lsb_listeInter
            // 
            this.lsb_listeInter.FormattingEnabled = true;
            this.lsb_listeInter.ItemHeight = 16;
            this.lsb_listeInter.Location = new System.Drawing.Point(11, 71);
            this.lsb_listeInter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsb_listeInter.Name = "lsb_listeInter";
            this.lsb_listeInter.Size = new System.Drawing.Size(1033, 388);
            this.lsb_listeInter.TabIndex = 2;
            // 
            // btn_editInter
            // 
            this.btn_editInter.Location = new System.Drawing.Point(945, 484);
            this.btn_editInter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_editInter.Name = "btn_editInter";
            this.btn_editInter.Size = new System.Drawing.Size(100, 28);
            this.btn_editInter.TabIndex = 1;
            this.btn_editInter.Text = "Edit";
            this.btn_editInter.UseVisualStyleBackColor = true;
            // 
            // btn_addInter
            // 
            this.btn_addInter.Location = new System.Drawing.Point(837, 484);
            this.btn_addInter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addInter.Name = "btn_addInter";
            this.btn_addInter.Size = new System.Drawing.Size(100, 28);
            this.btn_addInter.TabIndex = 0;
            this.btn_addInter.Text = "Add";
            this.btn_addInter.UseVisualStyleBackColor = true;
            // 
            // tab
            // 
            this.tab.Location = new System.Drawing.Point(4, 25);
            this.tab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab.Name = "tab";
            this.tab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab.Size = new System.Drawing.Size(1059, 525);
            this.tab.TabIndex = 1;
            this.tab.Text = "Liste Clients";
            this.tab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1059, 525);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Liste Matériel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-L5O173O;Initial Catalog=GestionMatos;Integrated Security=True" +
    "";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "afficher_interventions";
            this.sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabC_listeInter);
            this.Controls.Add(this.btn_Close);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabC_listeInter.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TabControl tabC_listeInter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_addInter;
        private System.Windows.Forms.TabPage tab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lsb_listeInter;
        private System.Windows.Forms.Button btn_editInter;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
    }
}

