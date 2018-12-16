namespace GestionMatos
{
    partial class F_Site
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
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.lb_ville = new System.Windows.Forms.Label();
            this.lb_adresse = new System.Windows.Forms.Label();
            this.lb_client = new System.Windows.Forms.Label();
            this.lb_zip = new System.Windows.Forms.Label();
            this.lb_nom = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_zip = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.cmb_clientList = new System.Windows.Forms.ComboBox();
            this.dtset_Clients = new GestionMatos.dtset_Clients();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new GestionMatos.dtset_ClientsTableAdapters.ClientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(398, 220);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 30);
            this.btn_Edit.TabIndex = 34;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(319, 220);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 30);
            this.btn_Ok.TabIndex = 33;
            this.btn_Ok.Text = "Add";
            this.btn_Ok.UseVisualStyleBackColor = true;
            // 
            // lb_ville
            // 
            this.lb_ville.AutoSize = true;
            this.lb_ville.Location = new System.Drawing.Point(307, 87);
            this.lb_ville.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ville.Name = "lb_ville";
            this.lb_ville.Size = new System.Drawing.Size(26, 13);
            this.lb_ville.TabIndex = 31;
            this.lb_ville.Text = "Ville";
            // 
            // lb_adresse
            // 
            this.lb_adresse.AutoSize = true;
            this.lb_adresse.Location = new System.Drawing.Point(307, 22);
            this.lb_adresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_adresse.Name = "lb_adresse";
            this.lb_adresse.Size = new System.Drawing.Size(45, 13);
            this.lb_adresse.TabIndex = 30;
            this.lb_adresse.Text = "Adresse";
            // 
            // lb_client
            // 
            this.lb_client.AutoSize = true;
            this.lb_client.Location = new System.Drawing.Point(61, 147);
            this.lb_client.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_client.Name = "lb_client";
            this.lb_client.Size = new System.Drawing.Size(32, 13);
            this.lb_client.TabIndex = 29;
            this.lb_client.Text = "Email";
            // 
            // lb_zip
            // 
            this.lb_zip.AutoSize = true;
            this.lb_zip.Location = new System.Drawing.Point(61, 87);
            this.lb_zip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_zip.Name = "lb_zip";
            this.lb_zip.Size = new System.Drawing.Size(64, 13);
            this.lb_zip.TabIndex = 28;
            this.lb_zip.Text = "Code Postal";
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Location = new System.Drawing.Point(61, 22);
            this.lb_nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(29, 13);
            this.lb_nom.TabIndex = 27;
            this.lb_nom.Text = "Nom";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(63, 37);
            this.tb_nom.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(121, 20);
            this.tb_nom.TabIndex = 26;
            // 
            // tb_zip
            // 
            this.tb_zip.Location = new System.Drawing.Point(63, 102);
            this.tb_zip.Margin = new System.Windows.Forms.Padding(2);
            this.tb_zip.Name = "tb_zip";
            this.tb_zip.Size = new System.Drawing.Size(121, 20);
            this.tb_zip.TabIndex = 25;
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(310, 37);
            this.tb_adresse.Margin = new System.Windows.Forms.Padding(2);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(121, 20);
            this.tb_adresse.TabIndex = 23;
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(310, 102);
            this.tb_ville.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(121, 20);
            this.tb_ville.TabIndex = 22;
            // 
            // cmb_clientList
            // 
            this.cmb_clientList.DataSource = this.clientsBindingSource;
            this.cmb_clientList.DisplayMember = "name_Client";
            this.cmb_clientList.FormattingEnabled = true;
            this.cmb_clientList.Location = new System.Drawing.Point(63, 164);
            this.cmb_clientList.Name = "cmb_clientList";
            this.cmb_clientList.Size = new System.Drawing.Size(121, 21);
            this.cmb_clientList.TabIndex = 35;
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
            // F_Site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.cmb_clientList);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lb_ville);
            this.Controls.Add(this.lb_adresse);
            this.Controls.Add(this.lb_client);
            this.Controls.Add(this.lb_zip);
            this.Controls.Add(this.lb_nom);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.tb_zip);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(this.tb_ville);
            this.Name = "F_Site";
            this.Text = "Site";
            this.Load += new System.EventHandler(this.F_Site_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lb_ville;
        private System.Windows.Forms.Label lb_adresse;
        private System.Windows.Forms.Label lb_client;
        private System.Windows.Forms.Label lb_zip;
        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_zip;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.ComboBox cmb_clientList;
        private dtset_Clients dtset_Clients;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private dtset_ClientsTableAdapters.ClientsTableAdapter clientsTableAdapter;
    }
}