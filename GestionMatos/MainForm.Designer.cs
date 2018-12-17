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
            this.btn_deconnexion = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_listeClientsNames = new System.Windows.Forms.Label();
            this.btn_editClient = new System.Windows.Forms.Button();
            this.btn_addClient = new System.Windows.Forms.Button();
            this.dgv_listeClientsMain = new System.Windows.Forms.DataGridView();
            this.id_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameClientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtset_Clients = new GestionMatos.dtset_Clients();
            this.comboBoxNom = new System.Windows.Forms.ComboBox();
            this.comboBoxID_Clients = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_editMateriel = new System.Windows.Forms.Button();
            this.btn_addMateriel = new System.Windows.Forms.Button();
            this.dgv_listeMaterielsMain = new System.Windows.Forms.DataGridView();
            this.nameMaterielDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialMaterielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtbfMaterielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypesMaterielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSiteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtset_Materiels = new GestionMatos.dtset_Materiels();
            this.comboBoxNom2 = new System.Windows.Forms.ComboBox();
            this.comboBoxN_Serie = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxID_Materiel = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_editSite = new System.Windows.Forms.Button();
            this.btn_addSite = new System.Windows.Forms.Button();
            this.dgv_listeSitesMain = new System.Windows.Forms.DataGridView();
            this.name_Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipcode_Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city_Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtsetSitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.clientsTableAdapter = new GestionMatos.dtset_ClientsTableAdapters.ClientsTableAdapter();
            this.dtset_Materiel = new GestionMatos.dtset_Materiel();
            this.materielTableAdapter = new GestionMatos.dtset_MaterielsTableAdapters.MaterielTableAdapter();
            this.lsbListMateriel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeInterMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afficherinterventionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_InterventionsMain1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Sites)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeClientsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Clients)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeMaterielsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Materiels)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeSitesMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetSitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_InterventionsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Materiel)).BeginInit();
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
            this.tabPage1.Controls.Add(this.btn_deconnexion);
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
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Liste des interventions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.Location = new System.Drawing.Point(9, 393);
            this.btn_deconnexion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(81, 23);
            this.btn_deconnexion.TabIndex = 16;
            this.btn_deconnexion.Text = "Deconection";
            this.btn_deconnexion.UseVisualStyleBackColor = true;
            this.btn_deconnexion.Click += new System.EventHandler(this.btn_deconnexion_Click);
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
            this.lb_MTBF.Location = new System.Drawing.Point(6, 3);
            this.lb_MTBF.Name = "lb_MTBF";
            this.lb_MTBF.Size = new System.Drawing.Size(36, 13);
            this.lb_MTBF.TabIndex = 14;
            this.lb_MTBF.Text = "MTBF";
            this.lb_MTBF.Click += new System.EventHandler(this.lb_MTBF_Click);
            // 
            // lb_materiels
            // 
            this.lb_materiels.AutoSize = true;
            this.lb_materiels.Location = new System.Drawing.Point(237, 3);
            this.lb_materiels.Name = "lb_materiels";
            this.lb_materiels.Size = new System.Drawing.Size(49, 13);
            this.lb_materiels.TabIndex = 13;
            this.lb_materiels.Text = "Materiels";
            // 
            // lb_clients
            // 
            this.lb_clients.AutoSize = true;
            this.lb_clients.Location = new System.Drawing.Point(447, 3);
            this.lb_clients.Name = "lb_clients";
            this.lb_clients.Size = new System.Drawing.Size(38, 13);
            this.lb_clients.TabIndex = 12;
            this.lb_clients.Text = "Clients";
            // 
            // lb_mainSites
            // 
            this.lb_mainSites.AutoSize = true;
            this.lb_mainSites.Location = new System.Drawing.Point(625, 3);
            this.lb_mainSites.Name = "lb_mainSites";
            this.lb_mainSites.Size = new System.Drawing.Size(30, 13);
            this.lb_mainSites.TabIndex = 10;
            this.lb_mainSites.Text = "Sites";
            // 
            // cmb_sites
            // 
            this.cmb_sites.DataSource = this.siteBindingSource1;
            this.cmb_sites.DisplayMember = "name_Site";
            this.cmb_sites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sites.FormattingEnabled = true;
            this.cmb_sites.Location = new System.Drawing.Point(623, 27);
            this.cmb_sites.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_sites.Name = "cmb_sites";
            this.cmb_sites.Size = new System.Drawing.Size(162, 21);
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
            this.cmb_clients.DataSource = this.clientsBindingSource;
            this.cmb_clients.DisplayMember = "name_Client";
            this.cmb_clients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_clients.FormattingEnabled = true;
            this.cmb_clients.Location = new System.Drawing.Point(450, 27);
            this.cmb_clients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_clients.Name = "cmb_clients";
            this.cmb_clients.Size = new System.Drawing.Size(171, 21);
            this.cmb_clients.TabIndex = 5;
            this.cmb_clients.ValueMember = "id_Client";
            this.cmb_clients.SelectedIndexChanged += new System.EventHandler(this.cmb_clients_SelectedIndexChanged);
            // 
            // cmb_materiels
            // 
            this.cmb_materiels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_materiels.FormattingEnabled = true;
            this.cmb_materiels.Items.AddRange(new object[] {
            "tour1",
            "tour2",
            "tour de sauron",
            "tour de france",
            "gandalf",
            "gollum"});
            this.cmb_materiels.Location = new System.Drawing.Point(239, 27);
            this.cmb_materiels.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_materiels.Name = "cmb_materiels";
            this.cmb_materiels.Size = new System.Drawing.Size(208, 21);
            this.cmb_materiels.TabIndex = 4;
            // 
            // cmb_MTBF
            // 
            this.cmb_MTBF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MTBF.FormattingEnabled = true;
            this.cmb_MTBF.Location = new System.Drawing.Point(8, 27);
            this.cmb_MTBF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_MTBF.Name = "cmb_MTBF";
            this.cmb_MTBF.Size = new System.Drawing.Size(229, 21);
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
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lb_listeClientsNames);
            this.tabPage2.Controls.Add(this.btn_editClient);
            this.tabPage2.Controls.Add(this.btn_addClient);
            this.tabPage2.Controls.Add(this.dgv_listeClientsMain);
            this.tabPage2.Controls.Add(this.comboBoxNom);
            this.tabPage2.Controls.Add(this.comboBoxID_Clients);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Liste Clients";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 396);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Deconection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_listeClientsNames
            // 
            this.lb_listeClientsNames.AutoSize = true;
            this.lb_listeClientsNames.Location = new System.Drawing.Point(6, 3);
            this.lb_listeClientsNames.Name = "lb_listeClientsNames";
            this.lb_listeClientsNames.Size = new System.Drawing.Size(38, 13);
            this.lb_listeClientsNames.TabIndex = 9;
            this.lb_listeClientsNames.Text = "Clients";
            // 
            // btn_editClient
            // 
            this.btn_editClient.Location = new System.Drawing.Point(709, 393);
            this.btn_editClient.Name = "btn_editClient";
            this.btn_editClient.Size = new System.Drawing.Size(75, 23);
            this.btn_editClient.TabIndex = 8;
            this.btn_editClient.Text = "Edit";
            this.btn_editClient.UseVisualStyleBackColor = true;
            this.btn_editClient.Click += new System.EventHandler(this.btn_editClient_Click);
            // 
            // btn_addClient
            // 
            this.btn_addClient.Location = new System.Drawing.Point(628, 393);
            this.btn_addClient.Name = "btn_addClient";
            this.btn_addClient.Size = new System.Drawing.Size(75, 23);
            this.btn_addClient.TabIndex = 7;
            this.btn_addClient.Text = "Add";
            this.btn_addClient.UseVisualStyleBackColor = true;
            this.btn_addClient.Click += new System.EventHandler(this.btn_addClient_Click);
            // 
            // dgv_listeClientsMain
            // 
            this.dgv_listeClientsMain.AllowUserToAddRows = false;
            this.dgv_listeClientsMain.AllowUserToDeleteRows = false;
            this.dgv_listeClientsMain.AutoGenerateColumns = false;
            this.dgv_listeClientsMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeClientsMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Client,
            this.nameClientDataGridViewTextBoxColumn1,
            this.addressClientDataGridViewTextBoxColumn,
            this.zipClientDataGridViewTextBoxColumn,
            this.cityClientDataGridViewTextBoxColumn,
            this.telClientDataGridViewTextBoxColumn,
            this.emailClientDataGridViewTextBoxColumn});
            this.dgv_listeClientsMain.DataSource = this.clientsBindingSource;
            this.dgv_listeClientsMain.Location = new System.Drawing.Point(8, 53);
            this.dgv_listeClientsMain.Name = "dgv_listeClientsMain";
            this.dgv_listeClientsMain.ReadOnly = true;
            this.dgv_listeClientsMain.Size = new System.Drawing.Size(776, 334);
            this.dgv_listeClientsMain.TabIndex = 6;
            // 
            // id_Client
            // 
            this.id_Client.DataPropertyName = "id_Client";
            this.id_Client.HeaderText = "id_Client";
            this.id_Client.Name = "id_Client";
            this.id_Client.ReadOnly = true;
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
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.dtset_Clients;
            // 
            // dtset_Clients
            // 
            this.dtset_Clients.DataSetName = "dtset_Clients";
            this.dtset_Clients.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxNom
            // 
            this.comboBoxNom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNom.FormattingEnabled = true;
            this.comboBoxNom.Location = new System.Drawing.Point(411, 27);
            this.comboBoxNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxNom.Name = "comboBoxNom";
            this.comboBoxNom.Size = new System.Drawing.Size(374, 21);
            this.comboBoxNom.TabIndex = 5;
            // 
            // comboBoxID_Clients
            // 
            this.comboBoxID_Clients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID_Clients.FormattingEnabled = true;
            this.comboBoxID_Clients.Location = new System.Drawing.Point(8, 27);
            this.comboBoxID_Clients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxID_Clients.Name = "comboBoxID_Clients";
            this.comboBoxID_Clients.Size = new System.Drawing.Size(355, 21);
            this.comboBoxID_Clients.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.btn_editMateriel);
            this.tabPage3.Controls.Add(this.btn_addMateriel);
            this.tabPage3.Controls.Add(this.dgv_listeMaterielsMain);
            this.tabPage3.Controls.Add(this.comboBoxNom2);
            this.tabPage3.Controls.Add(this.comboBoxN_Serie);
            this.tabPage3.Controls.Add(this.comboBoxType);
            this.tabPage3.Controls.Add(this.comboBoxID_Materiel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Liste Matériel";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 396);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Deconection";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.btn_addMateriel.Click += new System.EventHandler(this.btn_addMateriel_Click);
            // 
            // dgv_listeMaterielsMain
            // 
            this.dgv_listeMaterielsMain.AllowUserToAddRows = false;
            this.dgv_listeMaterielsMain.AllowUserToDeleteRows = false;
            this.dgv_listeMaterielsMain.AutoGenerateColumns = false;
            this.dgv_listeMaterielsMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeMaterielsMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameMaterielDataGridViewTextBoxColumn1,
            this.serialMaterielDataGridViewTextBoxColumn,
            this.mtbfMaterielDataGridViewTextBoxColumn,
            this.idTypesMaterielDataGridViewTextBoxColumn,
            this.idSiteDataGridViewTextBoxColumn1,
            this.idClientDataGridViewTextBoxColumn1,
            this.idBrandDataGridViewTextBoxColumn});
            this.dgv_listeMaterielsMain.DataSource = this.materielBindingSource;
            this.dgv_listeMaterielsMain.Location = new System.Drawing.Point(8, 53);
            this.dgv_listeMaterielsMain.Name = "dgv_listeMaterielsMain";
            this.dgv_listeMaterielsMain.ReadOnly = true;
            this.dgv_listeMaterielsMain.Size = new System.Drawing.Size(775, 339);
            this.dgv_listeMaterielsMain.TabIndex = 9;
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
            // materielBindingSource
            // 
            this.materielBindingSource.DataMember = "Materiel";
            this.materielBindingSource.DataSource = this.dtset_Materiels;
            // 
            // dtset_Materiels
            // 
            this.dtset_Materiels.DataSetName = "dtset_Materiels";
            this.dtset_Materiels.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxNom2
            // 
            this.comboBoxNom2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNom2.FormattingEnabled = true;
            this.comboBoxNom2.Location = new System.Drawing.Point(589, 27);
            this.comboBoxNom2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxNom2.Name = "comboBoxNom2";
            this.comboBoxNom2.Size = new System.Drawing.Size(195, 21);
            this.comboBoxNom2.TabIndex = 8;
            // 
            // comboBoxN_Serie
            // 
            this.comboBoxN_Serie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxN_Serie.FormattingEnabled = true;
            this.comboBoxN_Serie.Location = new System.Drawing.Point(381, 27);
            this.comboBoxN_Serie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxN_Serie.Name = "comboBoxN_Serie";
            this.comboBoxN_Serie.Size = new System.Drawing.Size(205, 21);
            this.comboBoxN_Serie.TabIndex = 7;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(195, 27);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(183, 21);
            this.comboBoxType.TabIndex = 6;
            // 
            // comboBoxID_Materiel
            // 
            this.comboBoxID_Materiel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID_Materiel.FormattingEnabled = true;
            this.comboBoxID_Materiel.Location = new System.Drawing.Point(7, 27);
            this.comboBoxID_Materiel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxID_Materiel.Name = "comboBoxID_Materiel";
            this.comboBoxID_Materiel.Size = new System.Drawing.Size(186, 21);
            this.comboBoxID_Materiel.TabIndex = 5;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.btn_editSite);
            this.tabPage4.Controls.Add(this.btn_addSite);
            this.tabPage4.Controls.Add(this.dgv_listeSitesMain);
            this.tabPage4.Controls.Add(this.comboBoxVille);
            this.tabPage4.Controls.Add(this.comboBoxCodePostale);
            this.tabPage4.Controls.Add(this.comboBoxAdresse);
            this.tabPage4.Controls.Add(this.comboBoxNom3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Listes Sites";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 396);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Deconection";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // dgv_listeSitesMain
            // 
            this.dgv_listeSitesMain.AllowUserToAddRows = false;
            this.dgv_listeSitesMain.AllowUserToDeleteRows = false;
            this.dgv_listeSitesMain.AutoGenerateColumns = false;
            this.dgv_listeSitesMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeSitesMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_Site,
            this.address_Site,
            this.zipcode_Site,
            this.city_Site,
            this.idClientDataGridViewTextBoxColumn2});
            this.dgv_listeSitesMain.DataSource = this.siteBindingSource1;
            this.dgv_listeSitesMain.Location = new System.Drawing.Point(5, 53);
            this.dgv_listeSitesMain.Name = "dgv_listeSitesMain";
            this.dgv_listeSitesMain.ReadOnly = true;
            this.dgv_listeSitesMain.Size = new System.Drawing.Size(776, 334);
            this.dgv_listeSitesMain.TabIndex = 12;
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
            // idClientDataGridViewTextBoxColumn2
            // 
            this.idClientDataGridViewTextBoxColumn2.DataPropertyName = "id_Client";
            this.idClientDataGridViewTextBoxColumn2.HeaderText = "id_Client";
            this.idClientDataGridViewTextBoxColumn2.Name = "idClientDataGridViewTextBoxColumn2";
            this.idClientDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // siteBindingSource1
            // 
            this.siteBindingSource1.DataMember = "Site";
            this.siteBindingSource1.DataSource = this.dtsetSitesBindingSource;
            // 
            // dtsetSitesBindingSource
            // 
            this.dtsetSitesBindingSource.DataSource = this.dtset_Sites;
            this.dtsetSitesBindingSource.Position = 0;
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(606, 27);
            this.comboBoxVille.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(176, 21);
            this.comboBoxVille.TabIndex = 9;
            // 
            // comboBoxCodePostale
            // 
            this.comboBoxCodePostale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCodePostale.FormattingEnabled = true;
            this.comboBoxCodePostale.Location = new System.Drawing.Point(414, 27);
            this.comboBoxCodePostale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCodePostale.Name = "comboBoxCodePostale";
            this.comboBoxCodePostale.Size = new System.Drawing.Size(189, 21);
            this.comboBoxCodePostale.TabIndex = 8;
            // 
            // comboBoxAdresse
            // 
            this.comboBoxAdresse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdresse.FormattingEnabled = true;
            this.comboBoxAdresse.Location = new System.Drawing.Point(209, 27);
            this.comboBoxAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAdresse.Name = "comboBoxAdresse";
            this.comboBoxAdresse.Size = new System.Drawing.Size(202, 21);
            this.comboBoxAdresse.TabIndex = 7;
            // 
            // comboBoxNom3
            // 
            this.comboBoxNom3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNom3.FormattingEnabled = true;
            this.comboBoxNom3.Location = new System.Drawing.Point(8, 27);
            this.comboBoxNom3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxNom3.Name = "comboBoxNom3";
            this.comboBoxNom3.Size = new System.Drawing.Size(199, 21);
            this.comboBoxNom3.TabIndex = 6;
            this.comboBoxNom3.SelectedIndexChanged += new System.EventHandler(this.comboBoxNom3_SelectedIndexChanged);
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
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // dtset_Materiel
            // 
            this.dtset_Materiel.DataSetName = "dtset_Materiel";
            this.dtset_Materiel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materielTableAdapter
            // 
            this.materielTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbListMateriel);
            this.Controls.Add(this.btn_Close);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "-";
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
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeClientsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Clients)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeMaterielsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Materiels)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeSitesMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetSitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_InterventionsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Materiel)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_listeClientsMain;
        private dtset_Clients dtset_Clients;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private dtset_ClientsTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Button btn_editClient;
        private System.Windows.Forms.Button btn_addClient;
        private System.Windows.Forms.Button btn_editMateriel;
        private System.Windows.Forms.Button btn_addMateriel;
        private System.Windows.Forms.DataGridView dgv_listeMaterielsMain;
        private dtset_Materiel dtset_Materiel;
        private dtset_Materiels dtset_Materiels;
        private System.Windows.Forms.BindingSource materielBindingSource;
        private dtset_MaterielsTableAdapters.MaterielTableAdapter materielTableAdapter;
        private System.Windows.Forms.Button btn_editSite;
        private System.Windows.Forms.Button btn_addSite;
        private System.Windows.Forms.DataGridView dgv_listeSitesMain;
        private System.Windows.Forms.BindingSource dtsetSitesBindingSource;
        private System.Windows.Forms.BindingSource siteBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_listeClientsNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMaterielDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialMaterielDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtbfMaterielDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypesMaterielDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSiteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipcode_Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn city_Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameClientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_deconnexion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

