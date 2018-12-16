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
            this.lb_MTBF = new System.Windows.Forms.Label();
            this.lb_materiels = new System.Windows.Forms.Label();
            this.lb_clients = new System.Windows.Forms.Label();
            this.dtset_InterventionsMain = new GestionMatos.dtset_InterventionsMain();
            this.lb_mainSites = new System.Windows.Forms.Label();
            this.cmb_sites = new System.Windows.Forms.ComboBox();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtset_Sites = new GestionMatos.dtset_Sites();
            this.cmb_clients = new System.Windows.Forms.ComboBox();
            this.cmb_materiels = new System.Windows.Forms.ComboBox();
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
            this.gestionMatosDataSet = new GestionMatos.GestionMatosDataSet();
            this.interventionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sqls_main = new System.Data.SqlClient.SqlConnection();
            this.sqlcmd_listeinter = new System.Data.SqlClient.SqlCommand();
            this.siteTableAdapter = new GestionMatos.dtset_SitesTableAdapters.SiteTableAdapter();
            this.dgv_ListeInterMain = new System.Windows.Forms.DataGridView();
            this.dtset_InterventionsMain1 = new GestionMatos.dtset_InterventionsMain();
            this.afficherinterventionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.afficher_interventionsTableAdapter = new GestionMatos.dtset_InterventionsMainTableAdapters.afficher_interventionsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInterventionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentaireInterventionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMaterielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTechnicienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsbListMateriel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_InterventionsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Sites)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeInterMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_InterventionsMain1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afficherinterventionsBindingSource)).BeginInit();
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
            this.tabPage1.Controls.Add(this.dgv_ListeInterMain);
            this.tabPage1.Controls.Add(this.lb_MTBF);
            this.tabPage1.Controls.Add(this.lb_materiels);
            this.tabPage1.Controls.Add(this.lb_clients);
            this.tabPage1.Controls.Add(this.lb_mainSites);
            this.tabPage1.Controls.Add(this.cmb_sites);
            this.tabPage1.Controls.Add(this.cmb_clients);
            this.tabPage1.Controls.Add(this.cmb_materiels);
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
            // lb_MTBF
            // 
            this.lb_MTBF.AutoSize = true;
            this.lb_MTBF.Location = new System.Drawing.Point(8, 12);
            this.lb_MTBF.Name = "lb_MTBF";
            this.lb_MTBF.Size = new System.Drawing.Size(36, 13);
            this.lb_MTBF.TabIndex = 14;
            this.lb_MTBF.Text = "MTBF";
            // 
            // lb_materiels
            // 
            this.lb_materiels.AutoSize = true;
            this.lb_materiels.Location = new System.Drawing.Point(91, 12);
            this.lb_materiels.Name = "lb_materiels";
            this.lb_materiels.Size = new System.Drawing.Size(49, 13);
            this.lb_materiels.TabIndex = 13;
            this.lb_materiels.Text = "Materiels";
            // 
            // lb_clients
            // 
            this.lb_clients.AutoSize = true;
            this.lb_clients.Location = new System.Drawing.Point(177, 12);
            this.lb_clients.Name = "lb_clients";
            this.lb_clients.Size = new System.Drawing.Size(38, 13);
            this.lb_clients.TabIndex = 12;
            this.lb_clients.Text = "Clients";
            // 
            // dtset_InterventionsMain
            // 
            this.dtset_InterventionsMain.DataSetName = "dtset_InterventionsMain";
            this.dtset_InterventionsMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lb_mainSites
            // 
            this.lb_mainSites.AutoSize = true;
            this.lb_mainSites.Location = new System.Drawing.Point(263, 12);
            this.lb_mainSites.Name = "lb_mainSites";
            this.lb_mainSites.Size = new System.Drawing.Size(30, 13);
            this.lb_mainSites.TabIndex = 10;
            this.lb_mainSites.Text = "Sites";
            // 
            // cmb_sites
            // 
            this.cmb_sites.DataSource = this.siteBindingSource;
            this.cmb_sites.DisplayMember = "name_Site";
            this.cmb_sites.FormattingEnabled = true;
            this.cmb_sites.Location = new System.Drawing.Point(266, 27);
            this.cmb_sites.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_sites.Name = "cmb_sites";
            this.cmb_sites.Size = new System.Drawing.Size(82, 21);
            this.cmb_sites.TabIndex = 6;
            this.cmb_sites.SelectedValueChanged += new System.EventHandler(this.cmb_sites_SelectedValueChanged);
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataMember = "Site";
            this.siteBindingSource.DataSource = this.dtset_Sites;
            // 
            // dtset_Sites
            // 
            this.dtset_Sites.DataSetName = "dtset_Sites";
            this.dtset_Sites.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_clients
            // 
            this.cmb_clients.FormattingEnabled = true;
            this.cmb_clients.Location = new System.Drawing.Point(180, 27);
            this.cmb_clients.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_clients.Name = "cmb_clients";
            this.cmb_clients.Size = new System.Drawing.Size(82, 21);
            this.cmb_clients.TabIndex = 5;
            this.cmb_clients.Text = "CLIENTS";
            // 
            // cmb_materiels
            // 
            this.cmb_materiels.FormattingEnabled = true;
            this.cmb_materiels.Location = new System.Drawing.Point(94, 27);
            this.cmb_materiels.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_materiels.Name = "cmb_materiels";
            this.cmb_materiels.Size = new System.Drawing.Size(82, 21);
            this.cmb_materiels.TabIndex = 4;
            this.cmb_materiels.Text = "MATERIEL";
            // 
            // cmb_MTBF
            // 
            this.cmb_MTBF.FormattingEnabled = true;
            this.cmb_MTBF.Location = new System.Drawing.Point(8, 27);
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
            // gestionMatosDataSet
            // 
            this.gestionMatosDataSet.DataSetName = "GestionMatosDataSet";
            this.gestionMatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // interventionBindingSource1
            // 
            this.interventionBindingSource1.DataMember = "Intervention";
            this.interventionBindingSource1.DataSource = this.gestionMatosDataSet;
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
            // siteTableAdapter
            // 
            this.siteTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_ListeInterMain
            // 
            this.dgv_ListeInterMain.AllowUserToAddRows = false;
            this.dgv_ListeInterMain.AllowUserToDeleteRows = false;
            this.dgv_ListeInterMain.AutoGenerateColumns = false;
            this.dgv_ListeInterMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeInterMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dateInterventionDataGridViewTextBoxColumn,
            this.commentaireInterventionDataGridViewTextBoxColumn,
            this.nameMaterielDataGridViewTextBoxColumn,
            this.idTechnicienDataGridViewTextBoxColumn,
            this.nameSiteDataGridViewTextBoxColumn,
            this.nameClientDataGridViewTextBoxColumn});
            this.dgv_ListeInterMain.DataSource = this.afficherinterventionsBindingSource;
            this.dgv_ListeInterMain.Location = new System.Drawing.Point(8, 53);
            this.dgv_ListeInterMain.Name = "dgv_ListeInterMain";
            this.dgv_ListeInterMain.ReadOnly = true;
            this.dgv_ListeInterMain.Size = new System.Drawing.Size(776, 334);
            this.dgv_ListeInterMain.TabIndex = 15;
            // 
            // dtset_InterventionsMain1
            // 
            this.dtset_InterventionsMain1.DataSetName = "dtset_InterventionsMain";
            this.dtset_InterventionsMain1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // afficherinterventionsBindingSource
            // 
            this.afficherinterventionsBindingSource.DataMember = "afficher_interventions";
            this.afficherinterventionsBindingSource.DataSource = this.dtset_InterventionsMain1;
            // 
            // afficher_interventionsTableAdapter
            // 
            this.afficher_interventionsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_Intervention";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_Intervention";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateInterventionDataGridViewTextBoxColumn
            // 
            this.dateInterventionDataGridViewTextBoxColumn.DataPropertyName = "date_Intervention";
            this.dateInterventionDataGridViewTextBoxColumn.HeaderText = "date_Intervention";
            this.dateInterventionDataGridViewTextBoxColumn.Name = "dateInterventionDataGridViewTextBoxColumn";
            this.dateInterventionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentaireInterventionDataGridViewTextBoxColumn
            // 
            this.commentaireInterventionDataGridViewTextBoxColumn.DataPropertyName = "commentaire_Intervention";
            this.commentaireInterventionDataGridViewTextBoxColumn.HeaderText = "commentaire_Intervention";
            this.commentaireInterventionDataGridViewTextBoxColumn.Name = "commentaireInterventionDataGridViewTextBoxColumn";
            this.commentaireInterventionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameMaterielDataGridViewTextBoxColumn
            // 
            this.nameMaterielDataGridViewTextBoxColumn.DataPropertyName = "name_Materiel";
            this.nameMaterielDataGridViewTextBoxColumn.HeaderText = "name_Materiel";
            this.nameMaterielDataGridViewTextBoxColumn.Name = "nameMaterielDataGridViewTextBoxColumn";
            this.nameMaterielDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idTechnicienDataGridViewTextBoxColumn
            // 
            this.idTechnicienDataGridViewTextBoxColumn.DataPropertyName = "id_Technicien";
            this.idTechnicienDataGridViewTextBoxColumn.HeaderText = "id_Technicien";
            this.idTechnicienDataGridViewTextBoxColumn.Name = "idTechnicienDataGridViewTextBoxColumn";
            this.idTechnicienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameSiteDataGridViewTextBoxColumn
            // 
            this.nameSiteDataGridViewTextBoxColumn.DataPropertyName = "name_Site";
            this.nameSiteDataGridViewTextBoxColumn.HeaderText = "name_Site";
            this.nameSiteDataGridViewTextBoxColumn.Name = "nameSiteDataGridViewTextBoxColumn";
            this.nameSiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameClientDataGridViewTextBoxColumn
            // 
            this.nameClientDataGridViewTextBoxColumn.DataPropertyName = "name_Client";
            this.nameClientDataGridViewTextBoxColumn.HeaderText = "name_Client";
            this.nameClientDataGridViewTextBoxColumn.Name = "nameClientDataGridViewTextBoxColumn";
            this.nameClientDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_InterventionsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Sites)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeInterMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_InterventionsMain1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afficherinterventionsBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox cmb_sites;
        private System.Windows.Forms.ComboBox cmb_clients;
        private System.Windows.Forms.ComboBox cmb_materiels;
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
        private GestionMatosDataSet gestionMatosDataSet;
        private System.Windows.Forms.BindingSource interventionBindingSource1;
        private dtset_Sites dtset_Sites;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private dtset_SitesTableAdapters.SiteTableAdapter siteTableAdapter;
        private System.Windows.Forms.Label lb_mainSites;
        private System.Windows.Forms.Label lb_clients;
        private System.Windows.Forms.Label lb_MTBF;
        private System.Windows.Forms.Label lb_materiels;
        private dtset_InterventionsMain dtset_InterventionsMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInterventionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgv_ListeInterMain;
        private dtset_InterventionsMain dtset_InterventionsMain1;
        private System.Windows.Forms.BindingSource afficherinterventionsBindingSource;
        private dtset_InterventionsMainTableAdapters.afficher_interventionsTableAdapter afficher_interventionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInterventionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaireInterventionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMaterielDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTechnicienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameClientDataGridViewTextBoxColumn;
    }
}

