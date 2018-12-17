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
            this.lb_clientList = new System.Windows.Forms.Label();
            this.lb_zip = new System.Windows.Forms.Label();
            this.lb_nom = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_zip = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.cmb_clientList = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtset_Clients = new GestionMatos.dtset_Clients();
            this.clientsTableAdapter = new GestionMatos.dtset_ClientsTableAdapters.ClientsTableAdapter();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Clients)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(497, 344);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(112, 46);
            this.btn_Edit.TabIndex = 34;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(379, 344);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(112, 46);
            this.btn_Ok.TabIndex = 33;
            this.btn_Ok.Text = "Add";
            this.btn_Ok.UseVisualStyleBackColor = true;
            // 
            // lb_ville
            // 
            this.lb_ville.AutoSize = true;
            this.lb_ville.Location = new System.Drawing.Point(399, 114);
            this.lb_ville.Name = "lb_ville";
            this.lb_ville.Size = new System.Drawing.Size(38, 20);
            this.lb_ville.TabIndex = 31;
            this.lb_ville.Text = "Ville";
            this.lb_ville.Click += new System.EventHandler(this.lb_ville_Click);
            // 
            // lb_adresse
            // 
            this.lb_adresse.AutoSize = true;
            this.lb_adresse.Location = new System.Drawing.Point(400, 19);
            this.lb_adresse.Name = "lb_adresse";
            this.lb_adresse.Size = new System.Drawing.Size(68, 20);
            this.lb_adresse.TabIndex = 30;
            this.lb_adresse.Text = "Adresse";
            // 
            // lb_clientList
            // 
            this.lb_clientList.AutoSize = true;
            this.lb_clientList.Location = new System.Drawing.Point(12, 211);
            this.lb_clientList.Name = "lb_clientList";
            this.lb_clientList.Size = new System.Drawing.Size(49, 20);
            this.lb_clientList.TabIndex = 29;
            this.lb_clientList.Text = "Client";
            // 
            // lb_zip
            // 
            this.lb_zip.AutoSize = true;
            this.lb_zip.Location = new System.Drawing.Point(8, 114);
            this.lb_zip.Name = "lb_zip";
            this.lb_zip.Size = new System.Drawing.Size(95, 20);
            this.lb_zip.TabIndex = 28;
            this.lb_zip.Text = "Code Postal";
            this.lb_zip.Click += new System.EventHandler(this.lb_zip_Click);
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Location = new System.Drawing.Point(8, 19);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(42, 20);
            this.lb_nom.TabIndex = 27;
            this.lb_nom.Text = "Nom";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(12, 57);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(353, 26);
            this.tb_nom.TabIndex = 26;
            // 
            // tb_zip
            // 
            this.tb_zip.Location = new System.Drawing.Point(13, 157);
            this.tb_zip.Name = "tb_zip";
            this.tb_zip.Size = new System.Drawing.Size(352, 26);
            this.tb_zip.TabIndex = 25;
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(403, 57);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(310, 26);
            this.tb_adresse.TabIndex = 23;
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(403, 157);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(310, 26);
            this.tb_ville.TabIndex = 22;
            // 
            // cmb_clientList
            // 
            this.cmb_clientList.DataSource = this.clientsBindingSource;
            this.cmb_clientList.DisplayMember = "name_Client";
            this.cmb_clientList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_clientList.FormattingEnabled = true;
            this.cmb_clientList.Location = new System.Drawing.Point(13, 257);
            this.cmb_clientList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_clientList.Name = "cmb_clientList";
            this.cmb_clientList.Size = new System.Drawing.Size(700, 28);
            this.cmb_clientList.TabIndex = 35;
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
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(615, 344);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(98, 46);
            this.btn_cancel.TabIndex = 36;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // F_Site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 402);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cmb_clientList);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lb_ville);
            this.Controls.Add(this.lb_adresse);
            this.Controls.Add(this.lb_clientList);
            this.Controls.Add(this.lb_zip);
            this.Controls.Add(this.lb_nom);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.tb_zip);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(this.tb_ville);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Site";
            this.Text = "Site";
            this.Load += new System.EventHandler(this.F_Site_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lb_ville;
        private System.Windows.Forms.Label lb_adresse;
        private System.Windows.Forms.Label lb_clientList;
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
        private System.Windows.Forms.Button btn_cancel;
    }
}