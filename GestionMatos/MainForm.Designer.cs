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
            this.dgv_ListeInterMain = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInterventionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentaireInterventionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMaterielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTechnicienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afficherinterventionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtset_InterventionsMain1 = new GestionMatos.dtset_InterventionsMain();
            this.lb_MTBF = new System.Windows.Forms.Label();
            this.lb_materiels = new System.Windows.Forms.Label();
            this.lb_clients = new System.Windows.Forms.Label();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBoxNom2 = new System.Windows.Forms.ComboBox();
            this.comboBoxN_Serie = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxID_Materiel = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.comboBoxCodePostale = new System.Windows.Forms.ComboBox();
            this.comboBoxAdresse = new System.Windows.Forms.ComboBox();
            this.comboBoxNom3 = new System.Windows.Forms.ComboBox();
            this.dtset_InterventionsMain = new GestionMatos.dtset_InterventionsMain();
            this.gestionMatosDataSet = new GestionMatos.GestionMatosDataSet();
            this.interventionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sqls_main = new System.Data.SqlClient.SqlConnection();
            this.sqlcmd_listeinter = new System.Data.SqlClient.SqlCommand();
            this.siteTableAdapter = new GestionMatos.dtset_SitesTableAdapters.SiteTableAdapter();
            this.afficher_interventionsTableAdapter = new GestionMatos.dtset_InterventionsMainTableAdapters.afficher_interventionsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtset_Clients = new GestionMatos.dtset_Clients();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new GestionMatos.dtset_ClientsTableAdapters.ClientsTableAdapter();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameClientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_editClient = new System.Windows.Forms.Button();
            this.lb_addClient = new System.Windows.Forms.Button();
            this.btn_editMateriel = new System.Windows.Forms.Button();
            this.btn_addMateriel = new System.Windows.Forms.Button();
            this.dgv_listeMateriels = new System.Windows.Forms.DataGridView();
            this.dtset_Materiel = new GestionMatos.dtset_Materiel();
            this.dtset_Materiels = new GestionMatos.dtset_Materiels();
            this.materielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materielTableAdapter = new GestionMatos.dtset_MaterielsTableAdapters.MaterielTableAdapter();
            this.idMaterielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMaterielDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialMaterielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtbfMaterielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypesMaterielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSiteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editSite = new System.Windows.Forms.Button();
            this.btn_addSite = new System.Windows.Forms.Button();
            this.dgv_listeSites = new System.Windows.Forms.DataGridView();
            this.name_Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipcode_Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city_Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtsetSitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idSiteDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSiteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressSiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipcodeSiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citySiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsbListMateriel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeInterMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afficherinterventionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_InterventionsMain1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Sites)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_InterventionsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeMateriels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Materiel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Materiels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeSites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetSitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource1)).BeginInit();
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
            // afficherinterventionsBindingSource
            // 
            this.afficherinterventionsBindingSource.DataMember = "afficher_interventions";
            this.afficherinterventionsBindingSource.DataSource = this.dtset_InterventionsMain1;
            // 
            // dtset_InterventionsMain1
            // 
            this.dtset_InterventionsMain1.DataSetName = "dtset_InterventionsMain";
            this.dtset_InterventionsMain1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tabPage2.Controls.Add(this.lb_editClient);
            this.tabPage2.Controls.Add(this.lb_addClient);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.comboBoxNom);
            this.tabPage2.Controls.Add(this.comboBoxID_Clients);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_editMateriel);
            this.tabPage3.Controls.Add(this.btn_addMateriel);
            this.tabPage3.Controls.Add(this.dgv_listeMateriels);
            this.tabPage3.Controls.Add(this.comboBoxNom2);
            this.tabPage3.Controls.Add(this.comboBoxN_Serie);
            this.tabPage3.Controls.Add(this.comboBoxType);
            this.tabPage3.Controls.Add(this.comboBoxID_Materiel);
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_editSite);
            this.tabPage4.Controls.Add(this.btn_addSite);
            this.tabPage4.Controls.Add(this.dgv_listeSites);
            this.tabPage4.Controls.Add(this.comboBoxVille);
            this.tabPage4.Controls.Add(this.comboBoxCodePostale);
            this.tabPage4.Controls.Add(this.comboBoxAdresse);
            this.tabPage4.Controls.Add(this.comboBoxNom3);
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
            // dtset_InterventionsMain
            // 
            this.dtset_InterventionsMain.DataSetName = "dtset_InterventionsMain";
            this.dtset_InterventionsMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // afficher_interventionsTableAdapter
            // 
            this.afficher_interventionsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientDataGridViewTextBoxColumn,
            this.nameClientDataGridViewTextBoxColumn1,
            this.addressClientDataGridViewTextBoxColumn,
            this.zipClientDataGridViewTextBoxColumn,
            this.cityClientDataGridViewTextBoxColumn,
            this.telClientDataGridViewTextBoxColumn,
            this.emailClientDataGridViewTextBoxColumn,
            this.idSiteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 339);
            this.dataGridView1.TabIndex = 6;
            // 
            // dtset_Clients
            // 
            this.dtset_Clients.DataSetName = "dtset_Clients";
            this.dtset_Clients.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.dtset_Clients;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "id_Client";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "id_Client";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameClientDataGridViewTextBoxColumn1
            // 
            this.nameClientDataGridViewTextBoxColumn1.DataPropertyName = "name_Client";
            this.nameClientDataGridViewTextBoxColumn1.HeaderText = "name_Client";
            this.nameClientDataGridViewTextBoxColumn1.Name = "nameClientDataGridViewTextBoxColumn1";
            this.nameClientDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // addressClientDataGridViewTextBoxColumn
            // 
            this.addressClientDataGridViewTextBoxColumn.DataPropertyName = "address_Client";
            this.addressClientDataGridViewTextBoxColumn.HeaderText = "address_Client";
            this.addressClientDataGridViewTextBoxColumn.Name = "addressClientDataGridViewTextBoxColumn";
            this.addressClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zipClientDataGridViewTextBoxColumn
            // 
            this.zipClientDataGridViewTextBoxColumn.DataPropertyName = "zip_Client";
            this.zipClientDataGridViewTextBoxColumn.HeaderText = "zip_Client";
            this.zipClientDataGridViewTextBoxColumn.Name = "zipClientDataGridViewTextBoxColumn";
            this.zipClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityClientDataGridViewTextBoxColumn
            // 
            this.cityClientDataGridViewTextBoxColumn.DataPropertyName = "city_Client";
            this.cityClientDataGridViewTextBoxColumn.HeaderText = "city_Client";
            this.cityClientDataGridViewTextBoxColumn.Name = "cityClientDataGridViewTextBoxColumn";
            this.cityClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telClientDataGridViewTextBoxColumn
            // 
            this.telClientDataGridViewTextBoxColumn.DataPropertyName = "tel_Client";
            this.telClientDataGridViewTextBoxColumn.HeaderText = "tel_Client";
            this.telClientDataGridViewTextBoxColumn.Name = "telClientDataGridViewTextBoxColumn";
            this.telClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailClientDataGridViewTextBoxColumn
            // 
            this.emailClientDataGridViewTextBoxColumn.DataPropertyName = "email_Client";
            this.emailClientDataGridViewTextBoxColumn.HeaderText = "email_Client";
            this.emailClientDataGridViewTextBoxColumn.Name = "emailClientDataGridViewTextBoxColumn";
            this.emailClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSiteDataGridViewTextBoxColumn
            // 
            this.idSiteDataGridViewTextBoxColumn.DataPropertyName = "id_Site";
            this.idSiteDataGridViewTextBoxColumn.HeaderText = "id_Site";
            this.idSiteDataGridViewTextBoxColumn.Name = "idSiteDataGridViewTextBoxColumn";
            this.idSiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lb_editClient
            // 
            this.lb_editClient.Location = new System.Drawing.Point(709, 393);
            this.lb_editClient.Name = "lb_editClient";
            this.lb_editClient.Size = new System.Drawing.Size(75, 23);
            this.lb_editClient.TabIndex = 8;
            this.lb_editClient.Text = "Edit";
            this.lb_editClient.UseVisualStyleBackColor = true;
            // 
            // lb_addClient
            // 
            this.lb_addClient.Location = new System.Drawing.Point(628, 393);
            this.lb_addClient.Name = "lb_addClient";
            this.lb_addClient.Size = new System.Drawing.Size(75, 23);
            this.lb_addClient.TabIndex = 7;
            this.lb_addClient.Text = "Add";
            this.lb_addClient.UseVisualStyleBackColor = true;
            // 
            // btn_editMateriel
            // 
            this.btn_editMateriel.Location = new System.Drawing.Point(709, 393);
            this.btn_editMateriel.Name = "btn_editMateriel";
            this.btn_editMateriel.Size = new System.Drawing.Size(75, 23);
            this.btn_editMateriel.TabIndex = 11;
            this.btn_editMateriel.Text = "Edit";
            this.btn_editMateriel.UseVisualStyleBackColor = true;
            // 
            // btn_addMateriel
            // 
            this.btn_addMateriel.Location = new System.Drawing.Point(628, 393);
            this.btn_addMateriel.Name = "btn_addMateriel";
            this.btn_addMateriel.Size = new System.Drawing.Size(75, 23);
            this.btn_addMateriel.TabIndex = 10;
            this.btn_addMateriel.Text = "Add";
            this.btn_addMateriel.UseVisualStyleBackColor = true;
            // 
            // dgv_listeMateriels
            // 
            this.dgv_listeMateriels.AllowUserToAddRows = false;
            this.dgv_listeMateriels.AllowUserToDeleteRows = false;
            this.dgv_listeMateriels.AutoGenerateColumns = false;
            this.dgv_listeMateriels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeMateriels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMaterielDataGridViewTextBoxColumn,
            this.nameMaterielDataGridViewTextBoxColumn1,
            this.serialMaterielDataGridViewTextBoxColumn,
            this.mtbfMaterielDataGridViewTextBoxColumn,
            this.idTypesMaterielDataGridViewTextBoxColumn,
            this.idSiteDataGridViewTextBoxColumn1,
            this.idClientDataGridViewTextBoxColumn1,
            this.idBrandDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2});
            this.dgv_listeMateriels.DataSource = this.materielBindingSource;
            this.dgv_listeMateriels.Location = new System.Drawing.Point(9, 48);
            this.dgv_listeMateriels.Name = "dgv_listeMateriels";
            this.dgv_listeMateriels.ReadOnly = true;
            this.dgv_listeMateriels.Size = new System.Drawing.Size(775, 339);
            this.dgv_listeMateriels.TabIndex = 9;
            // 
            // dtset_Materiel
            // 
            this.dtset_Materiel.DataSetName = "dtset_Materiel";
            this.dtset_Materiel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtset_Materiels
            // 
            this.dtset_Materiels.DataSetName = "dtset_Materiels";
            this.dtset_Materiels.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materielBindingSource
            // 
            this.materielBindingSource.DataMember = "Materiel";
            this.materielBindingSource.DataSource = this.dtset_Materiels;
            // 
            // materielTableAdapter
            // 
            this.materielTableAdapter.ClearBeforeFill = true;
            // 
            // idMaterielDataGridViewTextBoxColumn
            // 
            this.idMaterielDataGridViewTextBoxColumn.DataPropertyName = "id_Materiel";
            this.idMaterielDataGridViewTextBoxColumn.HeaderText = "id_Materiel";
            this.idMaterielDataGridViewTextBoxColumn.Name = "idMaterielDataGridViewTextBoxColumn";
            this.idMaterielDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameMaterielDataGridViewTextBoxColumn1
            // 
            this.nameMaterielDataGridViewTextBoxColumn1.DataPropertyName = "name_Materiel";
            this.nameMaterielDataGridViewTextBoxColumn1.HeaderText = "name_Materiel";
            this.nameMaterielDataGridViewTextBoxColumn1.Name = "nameMaterielDataGridViewTextBoxColumn1";
            this.nameMaterielDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // serialMaterielDataGridViewTextBoxColumn
            // 
            this.serialMaterielDataGridViewTextBoxColumn.DataPropertyName = "serial_Materiel";
            this.serialMaterielDataGridViewTextBoxColumn.HeaderText = "serial_Materiel";
            this.serialMaterielDataGridViewTextBoxColumn.Name = "serialMaterielDataGridViewTextBoxColumn";
            this.serialMaterielDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mtbfMaterielDataGridViewTextBoxColumn
            // 
            this.mtbfMaterielDataGridViewTextBoxColumn.DataPropertyName = "mtbf_Materiel";
            this.mtbfMaterielDataGridViewTextBoxColumn.HeaderText = "mtbf_Materiel";
            this.mtbfMaterielDataGridViewTextBoxColumn.Name = "mtbfMaterielDataGridViewTextBoxColumn";
            this.mtbfMaterielDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idTypesMaterielDataGridViewTextBoxColumn
            // 
            this.idTypesMaterielDataGridViewTextBoxColumn.DataPropertyName = "id_TypesMateriel";
            this.idTypesMaterielDataGridViewTextBoxColumn.HeaderText = "id_TypesMateriel";
            this.idTypesMaterielDataGridViewTextBoxColumn.Name = "idTypesMaterielDataGridViewTextBoxColumn";
            this.idTypesMaterielDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSiteDataGridViewTextBoxColumn1
            // 
            this.idSiteDataGridViewTextBoxColumn1.DataPropertyName = "id_Site";
            this.idSiteDataGridViewTextBoxColumn1.HeaderText = "id_Site";
            this.idSiteDataGridViewTextBoxColumn1.Name = "idSiteDataGridViewTextBoxColumn1";
            this.idSiteDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idClientDataGridViewTextBoxColumn1
            // 
            this.idClientDataGridViewTextBoxColumn1.DataPropertyName = "id_Client";
            this.idClientDataGridViewTextBoxColumn1.HeaderText = "id_Client";
            this.idClientDataGridViewTextBoxColumn1.Name = "idClientDataGridViewTextBoxColumn1";
            this.idClientDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idBrandDataGridViewTextBoxColumn
            // 
            this.idBrandDataGridViewTextBoxColumn.DataPropertyName = "id_Brand";
            this.idBrandDataGridViewTextBoxColumn.HeaderText = "id_Brand";
            this.idBrandDataGridViewTextBoxColumn.Name = "idBrandDataGridViewTextBoxColumn";
            this.idBrandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_Intervention";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_Intervention";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btn_editSite
            // 
            this.btn_editSite.Location = new System.Drawing.Point(708, 393);
            this.btn_editSite.Name = "btn_editSite";
            this.btn_editSite.Size = new System.Drawing.Size(75, 23);
            this.btn_editSite.TabIndex = 14;
            this.btn_editSite.Text = "Edit";
            this.btn_editSite.UseVisualStyleBackColor = true;
            // 
            // btn_addSite
            // 
            this.btn_addSite.Location = new System.Drawing.Point(627, 393);
            this.btn_addSite.Name = "btn_addSite";
            this.btn_addSite.Size = new System.Drawing.Size(75, 23);
            this.btn_addSite.TabIndex = 13;
            this.btn_addSite.Text = "Add";
            this.btn_addSite.UseVisualStyleBackColor = true;
            // 
            // dgv_listeSites
            // 
            this.dgv_listeSites.AllowUserToAddRows = false;
            this.dgv_listeSites.AllowUserToDeleteRows = false;
            this.dgv_listeSites.AutoGenerateColumns = false;
            this.dgv_listeSites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeSites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_Site,
            this.address_Site,
            this.zipcode_Site,
            this.city_Site,
            this.idSiteDataGridViewTextBoxColumn2,
            this.nameSiteDataGridViewTextBoxColumn1,
            this.addressSiteDataGridViewTextBoxColumn,
            this.zipcodeSiteDataGridViewTextBoxColumn,
            this.citySiteDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn2});
            this.dgv_listeSites.DataSource = this.siteBindingSource1;
            this.dgv_listeSites.Location = new System.Drawing.Point(8, 48);
            this.dgv_listeSites.Name = "dgv_listeSites";
            this.dgv_listeSites.ReadOnly = true;
            this.dgv_listeSites.Size = new System.Drawing.Size(775, 339);
            this.dgv_listeSites.TabIndex = 12;
            // 
            // name_Site
            // 
            this.name_Site.DataPropertyName = "name_Site";
            this.name_Site.HeaderText = "name_Site";
            this.name_Site.Name = "name_Site";
            this.name_Site.ReadOnly = true;
            // 
            // address_Site
            // 
            this.address_Site.DataPropertyName = "address_Site";
            this.address_Site.HeaderText = "address_Site";
            this.address_Site.Name = "address_Site";
            this.address_Site.ReadOnly = true;
            // 
            // zipcode_Site
            // 
            this.zipcode_Site.DataPropertyName = "zipcode_Site";
            this.zipcode_Site.HeaderText = "zipcode_Site";
            this.zipcode_Site.Name = "zipcode_Site";
            this.zipcode_Site.ReadOnly = true;
            // 
            // city_Site
            // 
            this.city_Site.DataPropertyName = "city_Site";
            this.city_Site.HeaderText = "city_Site";
            this.city_Site.Name = "city_Site";
            this.city_Site.ReadOnly = true;
            // 
            // dtsetSitesBindingSource
            // 
            this.dtsetSitesBindingSource.DataSource = this.dtset_Sites;
            this.dtsetSitesBindingSource.Position = 0;
            // 
            // siteBindingSource1
            // 
            this.siteBindingSource1.DataMember = "Site";
            this.siteBindingSource1.DataSource = this.dtsetSitesBindingSource;
            // 
            // idSiteDataGridViewTextBoxColumn2
            // 
            this.idSiteDataGridViewTextBoxColumn2.DataPropertyName = "id_Site";
            this.idSiteDataGridViewTextBoxColumn2.HeaderText = "id_Site";
            this.idSiteDataGridViewTextBoxColumn2.Name = "idSiteDataGridViewTextBoxColumn2";
            this.idSiteDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameSiteDataGridViewTextBoxColumn1
            // 
            this.nameSiteDataGridViewTextBoxColumn1.DataPropertyName = "name_Site";
            this.nameSiteDataGridViewTextBoxColumn1.HeaderText = "name_Site";
            this.nameSiteDataGridViewTextBoxColumn1.Name = "nameSiteDataGridViewTextBoxColumn1";
            this.nameSiteDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // addressSiteDataGridViewTextBoxColumn
            // 
            this.addressSiteDataGridViewTextBoxColumn.DataPropertyName = "address_Site";
            this.addressSiteDataGridViewTextBoxColumn.HeaderText = "address_Site";
            this.addressSiteDataGridViewTextBoxColumn.Name = "addressSiteDataGridViewTextBoxColumn";
            this.addressSiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zipcodeSiteDataGridViewTextBoxColumn
            // 
            this.zipcodeSiteDataGridViewTextBoxColumn.DataPropertyName = "zipcode_Site";
            this.zipcodeSiteDataGridViewTextBoxColumn.HeaderText = "zipcode_Site";
            this.zipcodeSiteDataGridViewTextBoxColumn.Name = "zipcodeSiteDataGridViewTextBoxColumn";
            this.zipcodeSiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // citySiteDataGridViewTextBoxColumn
            // 
            this.citySiteDataGridViewTextBoxColumn.DataPropertyName = "city_Site";
            this.citySiteDataGridViewTextBoxColumn.HeaderText = "city_Site";
            this.citySiteDataGridViewTextBoxColumn.Name = "citySiteDataGridViewTextBoxColumn";
            this.citySiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClientDataGridViewTextBoxColumn2
            // 
            this.idClientDataGridViewTextBoxColumn2.DataPropertyName = "id_Client";
            this.idClientDataGridViewTextBoxColumn2.HeaderText = "id_Client";
            this.idClientDataGridViewTextBoxColumn2.Name = "idClientDataGridViewTextBoxColumn2";
            this.idClientDataGridViewTextBoxColumn2.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeInterMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afficherinterventionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_InterventionsMain1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Sites)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtset_InterventionsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeMateriels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Materiel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Materiels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeSites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetSitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private dtset_Clients dtset_Clients;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private dtset_ClientsTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Button lb_editClient;
        private System.Windows.Forms.Button lb_addClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameClientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_editMateriel;
        private System.Windows.Forms.Button btn_addMateriel;
        private System.Windows.Forms.DataGridView dgv_listeMateriels;
        private dtset_Materiel dtset_Materiel;
        private dtset_Materiels dtset_Materiels;
        private System.Windows.Forms.BindingSource materielBindingSource;
        private dtset_MaterielsTableAdapters.MaterielTableAdapter materielTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterielDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMaterielDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialMaterielDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtbfMaterielDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypesMaterielDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSiteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btn_editSite;
        private System.Windows.Forms.Button btn_addSite;
        private System.Windows.Forms.DataGridView dgv_listeSites;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipcode_Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn city_Site;
        private System.Windows.Forms.BindingSource dtsetSitesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSiteDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSiteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressSiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipcodeSiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citySiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource siteBindingSource1;
    }
}

