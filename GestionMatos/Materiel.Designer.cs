namespace GestionMatos
{
    partial class Materiel
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
            this.lb_client = new System.Windows.Forms.Label();
            this.lb_MTBF = new System.Windows.Forms.Label();
            this.lb_numero_serie = new System.Windows.Forms.Label();
            this.lb_marque = new System.Windows.Forms.Label();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_nom = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.tb_marque = new System.Windows.Forms.TextBox();
            this.tb_numero_serie = new System.Windows.Forms.TextBox();
            this.tb_MTBF = new System.Windows.Forms.TextBox();
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
            this.btn_Ok.Location = new System.Drawing.Point(378, 344);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(112, 46);
            this.btn_Ok.TabIndex = 33;
            this.btn_Ok.Text = "Add";
            this.btn_Ok.UseVisualStyleBackColor = true;
            // 
            // lb_client
            // 
            this.lb_client.AutoSize = true;
            this.lb_client.Location = new System.Drawing.Point(374, 224);
            this.lb_client.Name = "lb_client";
            this.lb_client.Size = new System.Drawing.Size(49, 20);
            this.lb_client.TabIndex = 32;
            this.lb_client.Text = "Client";
            // 
            // lb_MTBF
            // 
            this.lb_MTBF.AutoSize = true;
            this.lb_MTBF.Location = new System.Drawing.Point(374, 131);
            this.lb_MTBF.Name = "lb_MTBF";
            this.lb_MTBF.Size = new System.Drawing.Size(52, 20);
            this.lb_MTBF.TabIndex = 31;
            this.lb_MTBF.Text = "MTBF";
            this.lb_MTBF.Click += new System.EventHandler(this.lb_MTBF_Click);
            // 
            // lb_numero_serie
            // 
            this.lb_numero_serie.AutoSize = true;
            this.lb_numero_serie.Location = new System.Drawing.Point(374, 34);
            this.lb_numero_serie.Name = "lb_numero_serie";
            this.lb_numero_serie.Size = new System.Drawing.Size(125, 20);
            this.lb_numero_serie.TabIndex = 30;
            this.lb_numero_serie.Text = "Numéro de série";
            // 
            // lb_marque
            // 
            this.lb_marque.AutoSize = true;
            this.lb_marque.Location = new System.Drawing.Point(8, 224);
            this.lb_marque.Name = "lb_marque";
            this.lb_marque.Size = new System.Drawing.Size(63, 20);
            this.lb_marque.TabIndex = 29;
            this.lb_marque.Text = "Marque";
            this.lb_marque.Click += new System.EventHandler(this.lb_marque_Click);
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(8, 131);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(43, 20);
            this.lb_type.TabIndex = 28;
            this.lb_type.Text = "Type";
            this.lb_type.Click += new System.EventHandler(this.lb_type_Click);
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Location = new System.Drawing.Point(8, 34);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(42, 20);
            this.lb_nom.TabIndex = 27;
            this.lb_nom.Text = "Nom";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(12, 68);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(328, 26);
            this.tb_nom.TabIndex = 26;
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(12, 168);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(328, 26);
            this.tb_type.TabIndex = 25;
            // 
            // tb_marque
            // 
            this.tb_marque.Location = new System.Drawing.Point(12, 259);
            this.tb_marque.Name = "tb_marque";
            this.tb_marque.Size = new System.Drawing.Size(328, 26);
            this.tb_marque.TabIndex = 24;
            // 
            // tb_numero_serie
            // 
            this.tb_numero_serie.Location = new System.Drawing.Point(378, 68);
            this.tb_numero_serie.Name = "tb_numero_serie";
            this.tb_numero_serie.Size = new System.Drawing.Size(335, 26);
            this.tb_numero_serie.TabIndex = 23;
            // 
            // tb_MTBF
            // 
            this.tb_MTBF.Location = new System.Drawing.Point(378, 168);
            this.tb_MTBF.Name = "tb_MTBF";
            this.tb_MTBF.Size = new System.Drawing.Size(335, 26);
            this.tb_MTBF.TabIndex = 22;
            // 
            // cmb_clientList
            // 
            this.cmb_clientList.DataSource = this.clientsBindingSource;
            this.cmb_clientList.DisplayMember = "name_Client";
            this.cmb_clientList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_clientList.FormattingEnabled = true;
            this.cmb_clientList.Location = new System.Drawing.Point(378, 257);
            this.cmb_clientList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_clientList.Name = "cmb_clientList";
            this.cmb_clientList.Size = new System.Drawing.Size(335, 28);
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
            // Materiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 402);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cmb_clientList);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lb_client);
            this.Controls.Add(this.lb_MTBF);
            this.Controls.Add(this.lb_numero_serie);
            this.Controls.Add(this.lb_marque);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.lb_nom);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.tb_marque);
            this.Controls.Add(this.tb_numero_serie);
            this.Controls.Add(this.tb_MTBF);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Materiel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Matériel";
            this.Load += new System.EventHandler(this.Materiel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtset_Clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lb_client;
        private System.Windows.Forms.Label lb_MTBF;
        private System.Windows.Forms.Label lb_numero_serie;
        private System.Windows.Forms.Label lb_marque;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.TextBox tb_marque;
        private System.Windows.Forms.TextBox tb_numero_serie;
        private System.Windows.Forms.TextBox tb_MTBF;
        private System.Windows.Forms.ComboBox cmb_clientList;
        private dtset_Clients dtset_Clients;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private dtset_ClientsTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Button btn_cancel;
    }
}