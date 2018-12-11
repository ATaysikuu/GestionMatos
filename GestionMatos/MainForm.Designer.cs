namespace GestionMatos
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
            this.lsbListMateriel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lsb_listeSites = new System.Windows.Forms.ListBox();
            this.btn_editInter = new System.Windows.Forms.Button();
            this.btn_addInter = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.lsbListClients = new System.Windows.Forms.ListBox();
            this.lsbListMaterial = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lsbListSites = new System.Windows.Forms.ListBox();
            this.comboBoxMTBF = new System.Windows.Forms.ComboBox();
            this.comboBoxMateriel = new System.Windows.Forms.ComboBox();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxSites = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxID_Clients = new System.Windows.Forms.ComboBox();
            this.comboBoxNom = new System.Windows.Forms.ComboBox();
            this.comboBoxID_Materiel = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxN_Serie = new System.Windows.Forms.ComboBox();
            this.comboBoxNom2 = new System.Windows.Forms.ComboBox();
            this.comboBoxNom3 = new System.Windows.Forms.ComboBox();
            this.comboBoxAdresse = new System.Windows.Forms.ComboBox();
            this.comboBoxCodePostale = new System.Windows.Forms.ComboBox();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.lsbListMateriel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(1070, 639);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(112, 35);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "CLOSE";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lsbListMateriel
            // 
            this.lsbListMateriel.Controls.Add(this.tabPage1);
            this.lsbListMateriel.Controls.Add(this.tabPage2);
            this.lsbListMateriel.Controls.Add(this.tabPage3);
            this.lsbListMateriel.Controls.Add(this.tabPage4);
            this.lsbListMateriel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbListMateriel.Location = new System.Drawing.Point(0, 0);
            this.lsbListMateriel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsbListMateriel.Name = "lsbListMateriel";
            this.lsbListMateriel.SelectedIndex = 0;
            this.lsbListMateriel.Size = new System.Drawing.Size(1200, 692);
            this.lsbListMateriel.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.comboBoxSites);
            this.tabPage1.Controls.Add(this.comboBoxClients);
            this.tabPage1.Controls.Add(this.comboBoxMateriel);
            this.tabPage1.Controls.Add(this.comboBoxMTBF);
            this.tabPage1.Controls.Add(this.lsb_listeSites);
            this.tabPage1.Controls.Add(this.btn_editInter);
            this.tabPage1.Controls.Add(this.btn_addInter);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1192, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Liste des interventions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lsb_listeSites
            // 
            this.lsb_listeSites.FormattingEnabled = true;
            this.lsb_listeSites.ItemHeight = 20;
            this.lsb_listeSites.Location = new System.Drawing.Point(12, 89);
            this.lsb_listeSites.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsb_listeSites.Name = "lsb_listeSites";
            this.lsb_listeSites.Size = new System.Drawing.Size(1162, 484);
            this.lsb_listeSites.TabIndex = 2;
            // 
            // btn_editInter
            // 
            this.btn_editInter.Location = new System.Drawing.Point(1063, 605);
            this.btn_editInter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_editInter.Name = "btn_editInter";
            this.btn_editInter.Size = new System.Drawing.Size(112, 35);
            this.btn_editInter.TabIndex = 1;
            this.btn_editInter.Text = "Edit";
            this.btn_editInter.UseVisualStyleBackColor = true;
            // 
            // btn_addInter
            // 
            this.btn_addInter.Location = new System.Drawing.Point(942, 605);
            this.btn_addInter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_addInter.Name = "btn_addInter";
            this.btn_addInter.Size = new System.Drawing.Size(112, 35);
            this.btn_addInter.TabIndex = 0;
            this.btn_addInter.Text = "Add";
            this.btn_addInter.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxNom);
            this.tabPage2.Controls.Add(this.comboBoxID_Clients);
            this.tabPage2.Controls.Add(this.lsbListClients);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1192, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Liste Clients";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBoxNom2);
            this.tabPage3.Controls.Add(this.comboBoxN_Serie);
            this.tabPage3.Controls.Add(this.comboBoxType);
            this.tabPage3.Controls.Add(this.comboBoxID_Materiel);
            this.tabPage3.Controls.Add(this.lsbListMaterial);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(1192, 659);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Liste Matériel";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // lsbListClients
            // 
            this.lsbListClients.FormattingEnabled = true;
            this.lsbListClients.ItemHeight = 20;
            this.lsbListClients.Location = new System.Drawing.Point(15, 87);
            this.lsbListClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsbListClients.Name = "lsbListClients";
            this.lsbListClients.Size = new System.Drawing.Size(1162, 484);
            this.lsbListClients.TabIndex = 3;
            this.lsbListClients.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lsbListMaterial
            // 
            this.lsbListMaterial.FormattingEnabled = true;
            this.lsbListMaterial.ItemHeight = 20;
            this.lsbListMaterial.Location = new System.Drawing.Point(15, 87);
            this.lsbListMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsbListMaterial.Name = "lsbListMaterial";
            this.lsbListMaterial.Size = new System.Drawing.Size(1162, 484);
            this.lsbListMaterial.TabIndex = 4;
            this.lsbListMaterial.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.comboBoxVille);
            this.tabPage4.Controls.Add(this.comboBoxCodePostale);
            this.tabPage4.Controls.Add(this.comboBoxAdresse);
            this.tabPage4.Controls.Add(this.comboBoxNom3);
            this.tabPage4.Controls.Add(this.lsbListSites);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1192, 659);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Listes Sites";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // lsbListSites
            // 
            this.lsbListSites.FormattingEnabled = true;
            this.lsbListSites.ItemHeight = 20;
            this.lsbListSites.Location = new System.Drawing.Point(15, 87);
            this.lsbListSites.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsbListSites.Name = "lsbListSites";
            this.lsbListSites.Size = new System.Drawing.Size(1162, 484);
            this.lsbListSites.TabIndex = 3;
            // 
            // comboBoxMTBF
            // 
            this.comboBoxMTBF.FormattingEnabled = true;
            this.comboBoxMTBF.Location = new System.Drawing.Point(39, 0);
            this.comboBoxMTBF.Name = "comboBoxMTBF";
            this.comboBoxMTBF.Size = new System.Drawing.Size(121, 28);
            this.comboBoxMTBF.TabIndex = 3;
            this.comboBoxMTBF.Text = "MTBF";
            // 
            // comboBoxMateriel
            // 
            this.comboBoxMateriel.FormattingEnabled = true;
            this.comboBoxMateriel.Location = new System.Drawing.Point(327, 3);
            this.comboBoxMateriel.Name = "comboBoxMateriel";
            this.comboBoxMateriel.Size = new System.Drawing.Size(121, 28);
            this.comboBoxMateriel.TabIndex = 4;
            this.comboBoxMateriel.Text = "MATERIEL";
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(695, 0);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(121, 28);
            this.comboBoxClients.TabIndex = 5;
            this.comboBoxClients.Text = "CLIENTS";
            // 
            // comboBoxSites
            // 
            this.comboBoxSites.FormattingEnabled = true;
            this.comboBoxSites.Location = new System.Drawing.Point(1034, 0);
            this.comboBoxSites.Name = "comboBoxSites";
            this.comboBoxSites.Size = new System.Drawing.Size(121, 28);
            this.comboBoxSites.TabIndex = 6;
            this.comboBoxSites.Text = "SITE";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxID_Clients
            // 
            this.comboBoxID_Clients.FormattingEnabled = true;
            this.comboBoxID_Clients.Location = new System.Drawing.Point(106, 8);
            this.comboBoxID_Clients.Name = "comboBoxID_Clients";
            this.comboBoxID_Clients.Size = new System.Drawing.Size(121, 28);
            this.comboBoxID_Clients.TabIndex = 4;
            this.comboBoxID_Clients.Text = "ID.Client";
            // 
            // comboBoxNom
            // 
            this.comboBoxNom.FormattingEnabled = true;
            this.comboBoxNom.Location = new System.Drawing.Point(492, 8);
            this.comboBoxNom.Name = "comboBoxNom";
            this.comboBoxNom.Size = new System.Drawing.Size(121, 28);
            this.comboBoxNom.TabIndex = 5;
            this.comboBoxNom.Text = "Nom";
            // 
            // comboBoxID_Materiel
            // 
            this.comboBoxID_Materiel.FormattingEnabled = true;
            this.comboBoxID_Materiel.Location = new System.Drawing.Point(58, 8);
            this.comboBoxID_Materiel.Name = "comboBoxID_Materiel";
            this.comboBoxID_Materiel.Size = new System.Drawing.Size(121, 28);
            this.comboBoxID_Materiel.TabIndex = 5;
            this.comboBoxID_Materiel.Text = "ID.MATERIEL";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(391, 8);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 28);
            this.comboBoxType.TabIndex = 6;
            this.comboBoxType.Text = "TYPE";
            // 
            // comboBoxN_Serie
            // 
            this.comboBoxN_Serie.FormattingEnabled = true;
            this.comboBoxN_Serie.Location = new System.Drawing.Point(722, 8);
            this.comboBoxN_Serie.Name = "comboBoxN_Serie";
            this.comboBoxN_Serie.Size = new System.Drawing.Size(121, 28);
            this.comboBoxN_Serie.TabIndex = 7;
            this.comboBoxN_Serie.Text = "NUMERO DE SERIE";
            // 
            // comboBoxNom2
            // 
            this.comboBoxNom2.FormattingEnabled = true;
            this.comboBoxNom2.Location = new System.Drawing.Point(1008, 8);
            this.comboBoxNom2.Name = "comboBoxNom2";
            this.comboBoxNom2.Size = new System.Drawing.Size(121, 28);
            this.comboBoxNom2.TabIndex = 8;
            this.comboBoxNom2.Text = "NOM";
            // 
            // comboBoxNom3
            // 
            this.comboBoxNom3.FormattingEnabled = true;
            this.comboBoxNom3.Location = new System.Drawing.Point(63, 6);
            this.comboBoxNom3.Name = "comboBoxNom3";
            this.comboBoxNom3.Size = new System.Drawing.Size(121, 28);
            this.comboBoxNom3.TabIndex = 6;
            this.comboBoxNom3.Text = "Nom";
            // 
            // comboBoxAdresse
            // 
            this.comboBoxAdresse.FormattingEnabled = true;
            this.comboBoxAdresse.Location = new System.Drawing.Point(334, 6);
            this.comboBoxAdresse.Name = "comboBoxAdresse";
            this.comboBoxAdresse.Size = new System.Drawing.Size(121, 28);
            this.comboBoxAdresse.TabIndex = 7;
            this.comboBoxAdresse.Text = "ADRESSE";
            // 
            // comboBoxCodePostale
            // 
            this.comboBoxCodePostale.FormattingEnabled = true;
            this.comboBoxCodePostale.Location = new System.Drawing.Point(677, 6);
            this.comboBoxCodePostale.Name = "comboBoxCodePostale";
            this.comboBoxCodePostale.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCodePostale.TabIndex = 8;
            this.comboBoxCodePostale.Text = "CODE POSTALE";
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(981, 6);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(121, 28);
            this.comboBoxVille.TabIndex = 9;
            this.comboBoxVille.Text = "VILLE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lsbListMateriel);
            this.Controls.Add(this.btn_Close);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.lsbListMateriel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TabControl lsbListMateriel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_addInter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lsb_listeSites;
        private System.Windows.Forms.Button btn_editInter;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.ListBox lsbListClients;
        private System.Windows.Forms.ListBox lsbListMaterial;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxSites;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxMateriel;
        private System.Windows.Forms.ComboBox comboBoxMTBF;
        private System.Windows.Forms.ComboBox comboBoxNom;
        private System.Windows.Forms.ComboBox comboBoxID_Clients;
        private System.Windows.Forms.ComboBox comboBoxNom2;
        private System.Windows.Forms.ComboBox comboBoxN_Serie;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxID_Materiel;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.ComboBox comboBoxCodePostale;
        private System.Windows.Forms.ComboBox comboBoxAdresse;
        private System.Windows.Forms.ComboBox comboBoxNom3;
        private System.Windows.Forms.ListBox lsbListSites;
    }
}

