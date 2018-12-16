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
            this.components = new System.ComponentModel.Container();
            this.dtpicker_dateinter = new System.Windows.Forms.DateTimePicker();
            this.cmb_IDTechnicien = new System.Windows.Forms.ComboBox();
            this.technicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtset_techos = new GestionMatos.dtset_techos();
            this.cmb_listeClients = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtset_Clients = new GestionMatos.GestionMatosDataSet1();
            this.cmb_listeSites = new System.Windows.Forms.ComboBox();
            this.sitefromclientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtset_SiteFromClient = new GestionMatos.dtset_SiteFromClient();
            this.affichersitesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gestionMatosDataSet3 = new GestionMatos.GestionMatosDataSet3();
            this.cmb_listeMateriel = new System.Windows.Forms.ComboBox();
            this.materielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtset_Materiel = new GestionMatos.dtset_Materiel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.lb_dateIntervention = new System.Windows.Forms.Label();
            this.lb_technicien = new System.Windows.Forms.Label();
            this.sqls_intervention = new System.Data.SqlClient.SqlConnection();
            this.sqlcmd_addinter = new System.Data.SqlClient.SqlCommand();
            this.rtb_commIntervention = new System.Windows.Forms.RichTextBox();
            this.lb_commIntervention = new System.Windows.Forms.Label();
            this.sqlcmd_listeclients = new System.Data.SqlClient.SqlCommand();
            this.clientsTableAdapter = new GestionMatos.GestionMatosDataSet1TableAdapters.ClientsTableAdapter();
            this.sqlcmd_listetechniciens = new System.Data.SqlClient.SqlCommand();
            this.gestionMatosDataSet2 = new GestionMatos.GestionMatosDataSet2();
            this.affichersitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.afficher_sitesTableAdapter = new GestionMatos.GestionMatosDataSet2TableAdapters.afficher_sitesTableAdapter();
            this.afficher_sitesTableAdapter1 = new GestionMatos.GestionMatosDataSet3TableAdapters.afficher_sitesTableAdapter();
            this.materielTableAdapter = new GestionMatos.dtset_MaterielTableAdapters.MaterielTableAdapter();
            this.lb_sites = new System.Windows.Forms.Label();
            this.lb_listeclients = new System.Windows.Forms.Label();
            this.lb_listemateriel = new System.Windows.Forms.Label();
            this.technicianTableAdapter = new GestionMatos.dtset_techosTableAdapters.TechnicianTableAdapter();
            this.sqlcmd_insertIntervention = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_getIntervention = new System.Data.SqlClient.SqlCommand();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.sqlcmd_updateIntervention = new System.Data.SqlClient.SqlCommand();
            this.site_from_clientTableAdapter = new GestionMatos.dtset_SiteFromClientTableAdapters.site_from_clientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_techos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitefromclientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_SiteFromClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affichersitesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Materiel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affichersitesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpicker_dateinter
            // 
            this.dtpicker_dateinter.Location = new System.Drawing.Point(11, 20);
            this.dtpicker_dateinter.Margin = new System.Windows.Forms.Padding(2);
            this.dtpicker_dateinter.Name = "dtpicker_dateinter";
            this.dtpicker_dateinter.Size = new System.Drawing.Size(135, 20);
            this.dtpicker_dateinter.TabIndex = 0;
            // 
            // cmb_IDTechnicien
            // 
            this.cmb_IDTechnicien.DataSource = this.technicianBindingSource;
            this.cmb_IDTechnicien.DisplayMember = "name_Technicien";
            this.cmb_IDTechnicien.FormattingEnabled = true;
            this.cmb_IDTechnicien.Location = new System.Drawing.Point(12, 67);
            this.cmb_IDTechnicien.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_IDTechnicien.Name = "cmb_IDTechnicien";
            this.cmb_IDTechnicien.Size = new System.Drawing.Size(135, 21);
            this.cmb_IDTechnicien.TabIndex = 2;
            // 
            // technicianBindingSource
            // 
            this.technicianBindingSource.DataMember = "Technician";
            this.technicianBindingSource.DataSource = this.dtset_techos;
            // 
            // dtset_techos
            // 
            this.dtset_techos.DataSetName = "dtset_techos";
            this.dtset_techos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_listeClients
            // 
            this.cmb_listeClients.DataSource = this.clientsBindingSource;
            this.cmb_listeClients.DisplayMember = "id_Client";
            this.cmb_listeClients.FormattingEnabled = true;
            this.cmb_listeClients.Location = new System.Drawing.Point(150, 19);
            this.cmb_listeClients.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_listeClients.Name = "cmb_listeClients";
            this.cmb_listeClients.Size = new System.Drawing.Size(121, 21);
            this.cmb_listeClients.TabIndex = 3;
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
            // cmb_listeSites
            // 
            this.cmb_listeSites.DataSource = this.sitefromclientBindingSource;
            this.cmb_listeSites.DisplayMember = "name_Site";
            this.cmb_listeSites.FormattingEnabled = true;
            this.cmb_listeSites.Location = new System.Drawing.Point(275, 19);
            this.cmb_listeSites.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_listeSites.Name = "cmb_listeSites";
            this.cmb_listeSites.Size = new System.Drawing.Size(121, 21);
            this.cmb_listeSites.TabIndex = 4;
            // 
            // sitefromclientBindingSource
            // 
            this.sitefromclientBindingSource.DataMember = "site_from_client";
            this.sitefromclientBindingSource.DataSource = this.dtset_SiteFromClient;
            // 
            // dtset_SiteFromClient
            // 
            this.dtset_SiteFromClient.DataSetName = "dtset_SiteFromClient";
            this.dtset_SiteFromClient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // affichersitesBindingSource1
            // 
            this.affichersitesBindingSource1.DataMember = "afficher_sites";
            this.affichersitesBindingSource1.DataSource = this.gestionMatosDataSet3;
            // 
            // gestionMatosDataSet3
            // 
            this.gestionMatosDataSet3.DataSetName = "GestionMatosDataSet3";
            this.gestionMatosDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_listeMateriel
            // 
            this.cmb_listeMateriel.DataSource = this.materielBindingSource;
            this.cmb_listeMateriel.DisplayMember = "name_Materiel";
            this.cmb_listeMateriel.FormattingEnabled = true;
            this.cmb_listeMateriel.Location = new System.Drawing.Point(151, 67);
            this.cmb_listeMateriel.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_listeMateriel.Name = "cmb_listeMateriel";
            this.cmb_listeMateriel.Size = new System.Drawing.Size(121, 21);
            this.cmb_listeMateriel.TabIndex = 5;
            this.cmb_listeMateriel.ValueMember = "id_Materiel";
            // 
            // materielBindingSource
            // 
            this.materielBindingSource.DataMember = "Materiel";
            this.materielBindingSource.DataSource = this.dtset_Materiel;
            // 
            // dtset_Materiel
            // 
            this.dtset_Materiel.DataSetName = "dtset_Materiel";
            this.dtset_Materiel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(322, 220);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 30);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Add";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // lb_dateIntervention
            // 
            this.lb_dateIntervention.AutoSize = true;
            this.lb_dateIntervention.Location = new System.Drawing.Point(11, 5);
            this.lb_dateIntervention.Name = "lb_dateIntervention";
            this.lb_dateIntervention.Size = new System.Drawing.Size(96, 13);
            this.lb_dateIntervention.TabIndex = 7;
            this.lb_dateIntervention.Text = "Date d\'intervention";
            // 
            // lb_technicien
            // 
            this.lb_technicien.AutoSize = true;
            this.lb_technicien.Location = new System.Drawing.Point(12, 52);
            this.lb_technicien.Name = "lb_technicien";
            this.lb_technicien.Size = new System.Drawing.Size(99, 13);
            this.lb_technicien.TabIndex = 8;
            this.lb_technicien.Text = "Technicien assigné";
            // 
            // sqls_intervention
            // 
            this.sqls_intervention.ConnectionString = "Data Source=.;Initial Catalog=GestionMatos;Integrated Security=True";
            this.sqls_intervention.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlcmd_addinter
            // 
            this.sqlcmd_addinter.CommandText = "add_intervention";
            this.sqlcmd_addinter.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlcmd_addinter.Connection = this.sqls_intervention;
            // 
            // rtb_commIntervention
            // 
            this.rtb_commIntervention.Location = new System.Drawing.Point(15, 119);
            this.rtb_commIntervention.Name = "rtb_commIntervention";
            this.rtb_commIntervention.Size = new System.Drawing.Size(382, 96);
            this.rtb_commIntervention.TabIndex = 9;
            this.rtb_commIntervention.Text = "";
            // 
            // lb_commIntervention
            // 
            this.lb_commIntervention.AutoSize = true;
            this.lb_commIntervention.Location = new System.Drawing.Point(15, 100);
            this.lb_commIntervention.Name = "lb_commIntervention";
            this.lb_commIntervention.Size = new System.Drawing.Size(68, 13);
            this.lb_commIntervention.TabIndex = 10;
            this.lb_commIntervention.Text = "Commentaire";
            // 
            // sqlcmd_listeclients
            // 
            this.sqlcmd_listeclients.CommandText = "afficher_clients";
            this.sqlcmd_listeclients.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlcmd_listeclients.Connection = this.sqls_intervention;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // sqlcmd_listetechniciens
            // 
            this.sqlcmd_listetechniciens.CommandText = "afficher_sites";
            this.sqlcmd_listetechniciens.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlcmd_listetechniciens.Connection = this.sqls_intervention;
            // 
            // gestionMatosDataSet2
            // 
            this.gestionMatosDataSet2.DataSetName = "GestionMatosDataSet2";
            this.gestionMatosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // affichersitesBindingSource
            // 
            this.affichersitesBindingSource.DataMember = "afficher_sites";
            this.affichersitesBindingSource.DataSource = this.gestionMatosDataSet2;
            // 
            // afficher_sitesTableAdapter
            // 
            this.afficher_sitesTableAdapter.ClearBeforeFill = true;
            // 
            // afficher_sitesTableAdapter1
            // 
            this.afficher_sitesTableAdapter1.ClearBeforeFill = true;
            // 
            // materielTableAdapter
            // 
            this.materielTableAdapter.ClearBeforeFill = true;
            // 
            // lb_sites
            // 
            this.lb_sites.AutoSize = true;
            this.lb_sites.Location = new System.Drawing.Point(272, 4);
            this.lb_sites.Name = "lb_sites";
            this.lb_sites.Size = new System.Drawing.Size(30, 13);
            this.lb_sites.TabIndex = 11;
            this.lb_sites.Text = "Sites";
            // 
            // lb_listeclients
            // 
            this.lb_listeclients.AutoSize = true;
            this.lb_listeclients.Location = new System.Drawing.Point(148, 5);
            this.lb_listeclients.Name = "lb_listeclients";
            this.lb_listeclients.Size = new System.Drawing.Size(38, 13);
            this.lb_listeclients.TabIndex = 12;
            this.lb_listeclients.Text = "Clients";
            // 
            // lb_listemateriel
            // 
            this.lb_listemateriel.AutoSize = true;
            this.lb_listemateriel.Location = new System.Drawing.Point(148, 52);
            this.lb_listemateriel.Name = "lb_listemateriel";
            this.lb_listemateriel.Size = new System.Drawing.Size(49, 13);
            this.lb_listemateriel.TabIndex = 13;
            this.lb_listemateriel.Text = "Matériels";
            // 
            // technicianTableAdapter
            // 
            this.technicianTableAdapter.ClearBeforeFill = true;
            // 
            // sqlcmd_insertIntervention
            // 
            this.sqlcmd_insertIntervention.CommandText = "add_intervention";
            this.sqlcmd_insertIntervention.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlcmd_insertIntervention.Connection = this.sqls_intervention;
            // 
            // sqlcmd_getIntervention
            // 
            this.sqlcmd_getIntervention.CommandText = "get_intervention";
            this.sqlcmd_getIntervention.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlcmd_getIntervention.Connection = this.sqls_intervention;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(401, 220);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 30);
            this.btn_Edit.TabIndex = 14;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // sqlcmd_updateIntervention
            // 
            this.sqlcmd_updateIntervention.CommandText = "modify_intervention";
            this.sqlcmd_updateIntervention.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlcmd_updateIntervention.Connection = this.sqls_intervention;
            // 
            // site_from_clientTableAdapter
            // 
            this.site_from_clientTableAdapter.ClearBeforeFill = true;
            // 
            // F_Intervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.lb_listemateriel);
            this.Controls.Add(this.lb_listeclients);
            this.Controls.Add(this.lb_sites);
            this.Controls.Add(this.lb_commIntervention);
            this.Controls.Add(this.rtb_commIntervention);
            this.Controls.Add(this.lb_technicien);
            this.Controls.Add(this.lb_dateIntervention);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.cmb_listeMateriel);
            this.Controls.Add(this.cmb_listeSites);
            this.Controls.Add(this.cmb_listeClients);
            this.Controls.Add(this.cmb_IDTechnicien);
            this.Controls.Add(this.dtpicker_dateinter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_Intervention";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Intervention";
            this.Load += new System.EventHandler(this.F_Intervention_Load);
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_techos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitefromclientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_SiteFromClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affichersitesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Materiel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionMatosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affichersitesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpicker_dateinter;
        private System.Windows.Forms.ComboBox cmb_IDTechnicien;
        private System.Windows.Forms.ComboBox cmb_listeClients;
        private System.Windows.Forms.ComboBox cmb_listeSites;
        private System.Windows.Forms.ComboBox cmb_listeMateriel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label lb_dateIntervention;
        private System.Windows.Forms.Label lb_technicien;
        private System.Data.SqlClient.SqlConnection sqls_intervention;
        private System.Data.SqlClient.SqlCommand sqlcmd_addinter;
        private System.Windows.Forms.RichTextBox rtb_commIntervention;
        private System.Windows.Forms.Label lb_commIntervention;
        private System.Data.SqlClient.SqlCommand sqlcmd_listeclients;
        private GestionMatosDataSet1 dtset_Clients;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private GestionMatosDataSet1TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Data.SqlClient.SqlCommand sqlcmd_listetechniciens;
        private GestionMatosDataSet2 gestionMatosDataSet2;
        private System.Windows.Forms.BindingSource affichersitesBindingSource;
        private GestionMatosDataSet2TableAdapters.afficher_sitesTableAdapter afficher_sitesTableAdapter;
        private GestionMatosDataSet3 gestionMatosDataSet3;
        private System.Windows.Forms.BindingSource affichersitesBindingSource1;
        private GestionMatosDataSet3TableAdapters.afficher_sitesTableAdapter afficher_sitesTableAdapter1;
        private dtset_Materiel dtset_Materiel;
        private System.Windows.Forms.BindingSource materielBindingSource;
        private dtset_MaterielTableAdapters.MaterielTableAdapter materielTableAdapter;
        private System.Windows.Forms.Label lb_sites;
        private System.Windows.Forms.Label lb_listeclients;
        private System.Windows.Forms.Label lb_listemateriel;
        private dtset_techos dtset_techos;
        private System.Windows.Forms.BindingSource technicianBindingSource;
        private dtset_techosTableAdapters.TechnicianTableAdapter technicianTableAdapter;
        private System.Data.SqlClient.SqlCommand sqlcmd_insertIntervention;
        private System.Data.SqlClient.SqlCommand sqlcmd_getIntervention;
        private System.Windows.Forms.Button btn_Edit;
        private System.Data.SqlClient.SqlCommand sqlcmd_updateIntervention;
        private System.Windows.Forms.BindingSource sitefromclientBindingSource;
        private dtset_SiteFromClient dtset_SiteFromClient;
        private dtset_SiteFromClientTableAdapters.site_from_clientTableAdapter site_from_clientTableAdapter;
    }
}