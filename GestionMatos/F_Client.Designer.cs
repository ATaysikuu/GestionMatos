namespace GestionMatos
{
    partial class F_Client
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
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.tb_code_postal = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.lb_nom = new System.Windows.Forms.Label();
            this.lb_tel = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_adresse = new System.Windows.Forms.Label();
            this.lb_code_postal = new System.Windows.Forms.Label();
            this.lb_ville = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.sqls_client = new System.Data.SqlClient.SqlConnection();
            this.sqlcmd_addClient = new System.Data.SqlClient.SqlCommand();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(244, 169);
            this.tb_ville.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(233, 20);
            this.tb_ville.TabIndex = 7;
            // 
            // tb_code_postal
            // 
            this.tb_code_postal.Location = new System.Drawing.Point(244, 109);
            this.tb_code_postal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_code_postal.Name = "tb_code_postal";
            this.tb_code_postal.Size = new System.Drawing.Size(233, 20);
            this.tb_code_postal.TabIndex = 8;
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(244, 44);
            this.tb_adresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(233, 20);
            this.tb_adresse.TabIndex = 9;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(8, 169);
            this.tb_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(233, 20);
            this.tb_email.TabIndex = 10;
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(8, 109);
            this.tb_tel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(233, 20);
            this.tb_tel.TabIndex = 11;
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(8, 44);
            this.tb_nom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(233, 20);
            this.tb_nom.TabIndex = 12;
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Location = new System.Drawing.Point(5, 19);
            this.lb_nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(29, 13);
            this.lb_nom.TabIndex = 13;
            this.lb_nom.Text = "Nom";
            // 
            // lb_tel
            // 
            this.lb_tel.AutoSize = true;
            this.lb_tel.Location = new System.Drawing.Point(5, 85);
            this.lb_tel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tel.Name = "lb_tel";
            this.lb_tel.Size = new System.Drawing.Size(58, 13);
            this.lb_tel.TabIndex = 14;
            this.lb_tel.Text = "Téléphone";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(5, 142);
            this.lb_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(32, 13);
            this.lb_email.TabIndex = 15;
            this.lb_email.Text = "Email";
            // 
            // lb_adresse
            // 
            this.lb_adresse.AutoSize = true;
            this.lb_adresse.Location = new System.Drawing.Point(241, 19);
            this.lb_adresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_adresse.Name = "lb_adresse";
            this.lb_adresse.Size = new System.Drawing.Size(45, 13);
            this.lb_adresse.TabIndex = 16;
            this.lb_adresse.Text = "Adresse";
            this.lb_adresse.Click += new System.EventHandler(this.lb_adresse_Click);
            // 
            // lb_code_postal
            // 
            this.lb_code_postal.AutoSize = true;
            this.lb_code_postal.Location = new System.Drawing.Point(241, 85);
            this.lb_code_postal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_code_postal.Name = "lb_code_postal";
            this.lb_code_postal.Size = new System.Drawing.Size(64, 13);
            this.lb_code_postal.TabIndex = 17;
            this.lb_code_postal.Text = "Code Postal";
            this.lb_code_postal.Click += new System.EventHandler(this.lb_code_postal_Click);
            // 
            // lb_ville
            // 
            this.lb_ville.AutoSize = true;
            this.lb_ville.Location = new System.Drawing.Point(241, 142);
            this.lb_ville.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ville.Name = "lb_ville";
            this.lb_ville.Size = new System.Drawing.Size(26, 13);
            this.lb_ville.TabIndex = 18;
            this.lb_ville.Text = "Ville";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(332, 218);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 30);
            this.btn_Edit.TabIndex = 20;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(253, 218);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 30);
            this.btn_Ok.TabIndex = 19;
            this.btn_Ok.Text = "Add";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // sqls_client
            // 
            this.sqls_client.ConnectionString = "Data Source=.;Initial Catalog=GestionMatos;Integrated Security=True";
            this.sqls_client.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlcmd_addClient
            // 
            this.sqlcmd_addClient.CommandText = "add_client";
            this.sqlcmd_addClient.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlcmd_addClient.Connection = this.sqls_client;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(411, 218);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(65, 30);
            this.btn_cancel.TabIndex = 21;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // F_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lb_ville);
            this.Controls.Add(this.lb_code_postal);
            this.Controls.Add(this.lb_adresse);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_tel);
            this.Controls.Add(this.lb_nom);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(this.tb_code_postal);
            this.Controls.Add(this.tb_ville);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Clients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.TextBox tb_code_postal;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.Label lb_tel;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_adresse;
        private System.Windows.Forms.Label lb_code_postal;
        private System.Windows.Forms.Label lb_ville;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Ok;
        private System.Data.SqlClient.SqlConnection sqls_client;
        private System.Data.SqlClient.SqlCommand sqlcmd_addClient;
        private System.Windows.Forms.Button btn_cancel;
    }
}