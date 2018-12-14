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
            this.components = new System.ComponentModel.Container();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lsbListMateriel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_listeinter = new System.Windows.Forms.DataGridView();
            this.idInterventionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInterventionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentaireInterventionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMaterielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTechnicienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interventionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gestionMatosDataSet = new GestionMatos.GestionMatosDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxSites = new System.Windows.Forms.ComboBox();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxMateriel = new System.Windows.Forms.ComboBox();
            this.cmb_MTBF = new System.Windows.Forms.ComboBox();
            this.btn_editInter = new System.Windows.Forms.Button();
            this.btn_addInter = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxNom = new System.Windows.Forms.ComboBox();
            this.comboBoxID_Clients = new System.Windows.Forms.ComboBox();
            this.lsbListClients = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBoxNom2 = new System.Windows.Forms.ComboBox();
            this.comboBoxN_Serie = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxID_Materiel = new System.Windows.Forms.ComboBox();
            this.lsbListMaterial = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.comboBoxCodePostale = new System.Windows.Forms.ComboBox();
            this.comboBoxAdresse = new System.Windows.Forms.ComboBox();
            this.comboBoxNom3 = new System.Windows.Forms.ComboBox();
            this.lsbListSites = new System.Windows.Forms.ListBox();
            this.sqls_main = new System.Data.SqlClient.SqlConnection();
            this.sqlcmd_listeinter = new System.Data.SqlClient.SqlCommand();
            this.interventionTableAdapter = new GestionMatos.GestionMatosDataSetTableAdapters.InterventionTableAdapter();
            this.afficherinterventionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.afficher_interventionsTableAdapter = new GestionMatos.GestionMatosDataSetTableAdapters.afficher_interventionsTableAdapter();
            this.interventionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lsbListMateriel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afficherinterventionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(713, 415);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
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
            this.lsbListMateriel.Name = "lsbListMateriel";
            this.lsbListMateriel.SelectedIndex = 0;
            this.lsbListMateriel.Size = new System.Drawing.Size(800, 450);
            this.lsbListMateriel.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_listeinter);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.comboBoxSites);
            this.tabPage1.Controls.Add(this.comboBoxClients);
            this.tabPage1.Controls.Add(this.comboBoxMateriel);
            this.tabPage1.Controls.Add(this.cmb_MTBF);
            this.tabPage1.Controls.Add(this.btn_editInter);
            this.tabPage1.Controls.Add(this.btn_addInter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Liste des interventions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_listeinter
            // 
            this.dgv_listeinter.AllowUserToAddRows = false;
            this.dgv_listeinter.AllowUserToDeleteRows = false;
            this.dgv_listeinter.AllowUserToOrderColumns = true;
            this.dgv_listeinter.AutoGenerateColumns = false;
            this.dgv_listeinter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeinter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInterventionDataGridViewTextBoxColumn,
            this.dateInterventionDataGridViewTextBoxColumn,
            this.commentaireInterventionDataGridViewTextBoxColumn,
            this.idMaterielDataGridViewTextBoxColumn,
            this.idTechnicienDataGridViewTextBoxColumn});
            this.dgv_listeinter.DataSource = this.interventionBindingSource1;
            this.dgv_listeinter.Location = new System.Drawing.Point(11, 28);
            this.dgv_listeinter.Name = "dgv_listeinter";
            this.dgv_listeinter.Size = new System.Drawing.Size(778, 359);
            this.dgv_listeinter.TabIndex = 9;
            // 
            // idInterventionDataGridViewTextBoxColumn
            // 
            this.idInterventionDataGridViewTextBoxColumn.DataPropertyName = "id_Intervention";
            this.idInterventionDataGridViewTextBoxColumn.HeaderText = "id_Intervention";
            this.idInterventionDataGridViewTextBoxColumn.Name = "idInterventionDataGridViewTextBoxColumn";
            this.idInterventionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateInterventionDataGridViewTextBoxColumn
            // 
            this.dateInterventionDataGridViewTextBoxColumn.DataPropertyName = "date_Intervention";
            this.dateInterventionDataGridViewTextBoxColumn.HeaderText = "date_Intervention";
            this.dateInterventionDataGridViewTextBoxColumn.Name = "dateInterventionDataGridViewTextBoxColumn";
            // 
            // commentaireInterventionDataGridViewTextBoxColumn
            // 
            this.commentaireInterventionDataGridViewTextBoxColumn.DataPropertyName = "commentaire_Intervention";
            this.commentaireInterventionDataGridViewTextBoxColumn.HeaderText = "commentaire_Intervention";
            this.commentaireInterventionDataGridViewTextBoxColumn.Name = "commentaireInterventionDataGridViewTextBoxColumn";
            // 
            // idMaterielDataGridViewTextBoxColumn
            // 
            this.idMaterielDataGridViewTextBoxColumn.DataPropertyName = "id_Materiel";
            this.idMaterielDataGridViewTextBoxColumn.HeaderText = "id_Materiel";
            this.idMaterielDataGridViewTextBoxColumn.Name = "idMaterielDataGridViewTextBoxColumn";
            // 
            // idTechnicienDataGridViewTextBoxColumn
            // 
            this.idTechnicienDataGridViewTextBoxColumn.DataPropertyName = "id_Technicien";
            this.idTechnicienDataGridViewTextBoxColumn.HeaderText = "id_Technicien";
            this.idTechnicienDataGridViewTextBoxColumn.Name = "idTechnicienDataGridViewTextBoxColumn";
            // 
            // interventionBindingSource1
            // 
            this.interventionBindingSource1.DataMember = "Intervention";
            this.interventionBindingSource1.DataSource = this.gestionMatosDataSet;
            // 
            // gestionMatosDataSet
            // 
            this.gestionMatosDataSet.DataSetName = "GestionMatosDataSet";
            this.gestionMatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(5, 5);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxSites
            // 
            this.comboBoxSites.FormattingEnabled = true;
            this.comboBoxSites.Location = new System.Drawing.Point(689, 0);
            this.comboBoxSites.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSites.Name = "comboBoxSites";
            this.comboBoxSites.Size = new System.Drawing.Size(82, 21);
            this.comboBoxSites.TabIndex = 6;
            this.comboBoxSites.Text = "SITE";
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(463, 0);
            this.comboBoxClients.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(82, 21);
            this.comboBoxClients.TabIndex = 5;
            this.comboBoxClients.Text = "CLIENTS";
            // 
            // comboBoxMateriel
            // 
            this.comboBoxMateriel.FormattingEnabled = true;
            this.comboBoxMateriel.Location = new System.Drawing.Point(218, 2);
            this.comboBoxMateriel.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMateriel.Name = "comboBoxMateriel";
            this.comboBoxMateriel.Size = new System.Drawing.Size(82, 21);
            this.comboBoxMateriel.TabIndex = 4;
            this.comboBoxMateriel.Text = "MATERIEL";
            // 
            // cmb_MTBF
            // 
            this.cmb_MTBF.DataSource = this.afficherinterventionsBindingSource;
            this.cmb_MTBF.DisplayMember = "date_Intervention";
            this.cmb_MTBF.FormattingEnabled = true;
            this.cmb_MTBF.Location = new System.Drawing.Point(26, 0);
            this.cmb_MTBF.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_MTBF.Name = "cmb_MTBF";
            this.cmb_MTBF.Size = new System.Drawing.Size(82, 21);
            this.cmb_MTBF.TabIndex = 3;
            this.cmb_MTBF.SelectedIndexChanged += new System.EventHandler(this.cmb_MTBF_SelectedIndexChanged);
            // 
            // btn_editInter
            // 
            this.btn_editInter.Location = new System.Drawing.Point(709, 393);
            this.btn_editInter.Name = "btn_editInter";
            this.btn_editInter.Size = new System.Drawing.Size(75, 23);
            this.btn_editInter.TabIndex = 1;
            this.btn_editInter.Text = "Edit";
            this.btn_editInter.UseVisualStyleBackColor = true;
            this.btn_editInter.Click += new System.EventHandler(this.btn_editInter_Click);
            // 
            // btn_addInter
            // 
            this.btn_addInter.Location = new System.Drawing.Point(628, 393);
            this.btn_addInter.Name = "btn_addInter";
            this.btn_addInter.Size = new System.Drawing.Size(75, 23);
            this.btn_addInter.TabIndex = 0;
            this.btn_addInter.Text = "Add";
            this.btn_addInter.UseVisualStyleBackColor = true;
            this.btn_addInter.Click += new System.EventHandler(this.btn_addInter_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxNom);
            this.tabPage2.Controls.Add(this.comboBoxID_Clients);
            this.tabPage2.Controls.Add(this.lsbListClients);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Liste Clients";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxNom
            // 
            this.comboBoxNom.FormattingEnabled = true;
            this.comboBoxNom.Location = new System.Drawing.Point(328, 5);
            this.comboBoxNom.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNom.Name = "comboBoxNom";
            this.comboBoxNom.Size = new System.Drawing.Size(82, 21);
            this.comboBoxNom.TabIndex = 5;
            this.comboBoxNom.Text = "Nom";
            // 
            // comboBoxID_Clients
            // 
            this.comboBoxID_Clients.FormattingEnabled = true;
            this.comboBoxID_Clients.Location = new System.Drawing.Point(71, 5);
            this.comboBoxID_Clients.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxID_Clients.Name = "comboBoxID_Clients";
            this.comboBoxID_Clients.Size = new System.Drawing.Size(82, 21);
            this.comboBoxID_Clients.TabIndex = 4;
            this.comboBoxID_Clients.Text = "ID.Client";
            // 
            // lsbListClients
            // 
            this.lsbListClients.FormattingEnabled = true;
            this.lsbListClients.Location = new System.Drawing.Point(10, 57);
            this.lsbListClients.Name = "lsbListClients";
            this.lsbListClients.Size = new System.Drawing.Size(776, 316);
            this.lsbListClients.TabIndex = 3;
            this.lsbListClients.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBoxNom2);
            this.tabPage3.Controls.Add(this.comboBoxN_Serie);
            this.tabPage3.Controls.Add(this.comboBoxType);
            this.tabPage3.Controls.Add(this.comboBoxID_Materiel);
            this.tabPage3.Controls.Add(this.lsbListMaterial);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Liste Matériel";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBoxNom2
            // 
            this.comboBoxNom2.FormattingEnabled = true;
            this.comboBoxNom2.Location = new System.Drawing.Point(672, 5);
            this.comboBoxNom2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNom2.Name = "comboBoxNom2";
            this.comboBoxNom2.Size = new System.Drawing.Size(82, 21);
            this.comboBoxNom2.TabIndex = 8;
            this.comboBoxNom2.Text = "NOM";
            // 
            // comboBoxN_Serie
            // 
            this.comboBoxN_Serie.FormattingEnabled = true;
            this.comboBoxN_Serie.Location = new System.Drawing.Point(481, 5);
            this.comboBoxN_Serie.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxN_Serie.Name = "comboBoxN_Serie";
            this.comboBoxN_Serie.Size = new System.Drawing.Size(82, 21);
            this.comboBoxN_Serie.TabIndex = 7;
            this.comboBoxN_Serie.Text = "NUMERO DE SERIE";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(261, 5);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(82, 21);
            this.comboBoxType.TabIndex = 6;
            this.comboBoxType.Text = "TYPE";
            // 
            // comboBoxID_Materiel
            // 
            this.comboBoxID_Materiel.FormattingEnabled = true;
            this.comboBoxID_Materiel.Location = new System.Drawing.Point(39, 5);
            this.comboBoxID_Materiel.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxID_Materiel.Name = "comboBoxID_Materiel";
            this.comboBoxID_Materiel.Size = new System.Drawing.Size(82, 21);
            this.comboBoxID_Materiel.TabIndex = 5;
            this.comboBoxID_Materiel.Text = "ID.MATERIEL";
            // 
            // lsbListMaterial
            // 
            this.lsbListMaterial.FormattingEnabled = true;
            this.lsbListMaterial.Location = new System.Drawing.Point(10, 57);
            this.lsbListMaterial.Name = "lsbListMaterial";
            this.lsbListMaterial.Size = new System.Drawing.Size(776, 316);
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
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Listes Sites";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(654, 4);
            this.comboBoxVille.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(82, 21);
            this.comboBoxVille.TabIndex = 9;
            this.comboBoxVille.Text = "VILLE";
            // 
            // comboBoxCodePostale
            // 
            this.comboBoxCodePostale.FormattingEnabled = true;
            this.comboBoxCodePostale.Location = new System.Drawing.Point(451, 4);
            this.comboBoxCodePostale.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCodePostale.Name = "comboBoxCodePostale";
            this.comboBoxCodePostale.Size = new System.Drawing.Size(82, 21);
            this.comboBoxCodePostale.TabIndex = 8;
            this.comboBoxCodePostale.Text = "CODE POSTALE";
            // 
            // comboBoxAdresse
            // 
            this.comboBoxAdresse.FormattingEnabled = true;
            this.comboBoxAdresse.Location = new System.Drawing.Point(223, 4);
            this.comboBoxAdresse.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAdresse.Name = "comboBoxAdresse";
            this.comboBoxAdresse.Size = new System.Drawing.Size(82, 21);
            this.comboBoxAdresse.TabIndex = 7;
            this.comboBoxAdresse.Text = "ADRESSE";
            // 
            // comboBoxNom3
            // 
            this.comboBoxNom3.FormattingEnabled = true;
            this.comboBoxNom3.Location = new System.Drawing.Point(42, 4);
            this.comboBoxNom3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNom3.Name = "comboBoxNom3";
            this.comboBoxNom3.Size = new System.Drawing.Size(82, 21);
            this.comboBoxNom3.TabIndex = 6;
            this.comboBoxNom3.Text = "Nom";
            // 
            // lsbListSites
            // 
            this.lsbListSites.FormattingEnabled = true;
            this.lsbListSites.Location = new System.Drawing.Point(10, 57);
            this.lsbListSites.Name = "lsbListSites";
            this.lsbListSites.Size = new System.Drawing.Size(776, 316);
            this.lsbListSites.TabIndex = 3;
            // 
            // sqls_main
            // 
            this.sqls_main.ConnectionString = "Data Source=.;Initial Catalog=GestionMatos;Integrated Security=True";
            this.sqls_main.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlcmd_listeinter
            // 
            this.sqlcmd_listeinter.CommandText = "afficher_interventions";
            this.sqlcmd_listeinter.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlcmd_listeinter.Connection = this.sqls_main;
            // 
            // interventionTableAdapter
            // 
            this.interventionTableAdapter.ClearBeforeFill = true;
            // 
            // afficherinterventionsBindingSource
            // 
            this.afficherinterventionsBindingSource.DataMember = "afficher_interventions";
            this.afficherinterventionsBindingSource.DataSource = this.gestionMatosDataSet;
            // 
            // afficher_interventionsTableAdapter
            // 
            this.afficher_interventionsTableAdapter.ClearBeforeFill = true;
            // 
            // interventionBindingSource
            // 
            this.interventionBindingSource.DataSource = typeof(GestionMatos.Intervention);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbListMateriel);
            this.Controls.Add(this.btn_Close);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.lsbListMateriel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.afficherinterventionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TabControl lsbListMateriel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_addInter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_editInter;
        private System.Data.SqlClient.SqlConnection sqls_main;
        private System.Data.SqlClient.SqlCommand sqlcmd_listeinter;
        private System.Windows.Forms.ListBox lsbListClients;
        private System.Windows.Forms.ListBox lsbListMaterial;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxSites;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxMateriel;
        private System.Windows.Forms.ComboBox cmb_MTBF;
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
        private System.Windows.Forms.BindingSource interventionBindingSource;
        private System.Windows.Forms.DataGridView dgv_listeinter;
        private GestionMatosDataSet gestionMatosDataSet;
        private System.Windows.Forms.BindingSource interventionBindingSource1;
        private GestionMatosDataSetTableAdapters.InterventionTableAdapter interventionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInterventionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInterventionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaireInterventionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterielDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTechnicienDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource afficherinterventionsBindingSource;
        private GestionMatosDataSetTableAdapters.afficher_interventionsTableAdapter afficher_interventionsTableAdapter;
    }
}

