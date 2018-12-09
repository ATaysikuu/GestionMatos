namespace GestionMatos
{
    partial class LoginForm
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
            this.lb_gestionmatos = new System.Windows.Forms.Label();
            this.lb_idlogin = new System.Windows.Forms.Label();
            this.lb_passlogin = new System.Windows.Forms.Label();
            this.tb_idlogin = new System.Windows.Forms.TextBox();
            this.tb_passlogin = new System.Windows.Forms.TextBox();
            this.btn_connectlogin = new System.Windows.Forms.Button();
            this.sql_loginconnstring = new System.Data.SqlClient.SqlConnection();
            this.sqlcmd_login = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // lb_gestionmatos
            // 
            this.lb_gestionmatos.AutoSize = true;
            this.lb_gestionmatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gestionmatos.Location = new System.Drawing.Point(16, 11);
            this.lb_gestionmatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_gestionmatos.Name = "lb_gestionmatos";
            this.lb_gestionmatos.Size = new System.Drawing.Size(226, 39);
            this.lb_gestionmatos.TabIndex = 0;
            this.lb_gestionmatos.Text = "GestionMatos";
            // 
            // lb_idlogin
            // 
            this.lb_idlogin.AutoSize = true;
            this.lb_idlogin.Location = new System.Drawing.Point(141, 119);
            this.lb_idlogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_idlogin.Name = "lb_idlogin";
            this.lb_idlogin.Size = new System.Drawing.Size(69, 17);
            this.lb_idlogin.TabIndex = 1;
            this.lb_idlogin.Text = "Identifiant";
            // 
            // lb_passlogin
            // 
            this.lb_passlogin.AutoSize = true;
            this.lb_passlogin.Location = new System.Drawing.Point(117, 151);
            this.lb_passlogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_passlogin.Name = "lb_passlogin";
            this.lb_passlogin.Size = new System.Drawing.Size(93, 17);
            this.lb_passlogin.TabIndex = 2;
            this.lb_passlogin.Text = "Mot de passe";
            // 
            // tb_idlogin
            // 
            this.tb_idlogin.Location = new System.Drawing.Point(225, 110);
            this.tb_idlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_idlogin.Name = "tb_idlogin";
            this.tb_idlogin.Size = new System.Drawing.Size(132, 22);
            this.tb_idlogin.TabIndex = 3;
            // 
            // tb_passlogin
            // 
            this.tb_passlogin.Location = new System.Drawing.Point(225, 143);
            this.tb_passlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_passlogin.Name = "tb_passlogin";
            this.tb_passlogin.PasswordChar = '*';
            this.tb_passlogin.Size = new System.Drawing.Size(132, 22);
            this.tb_passlogin.TabIndex = 4;
            // 
            // btn_connectlogin
            // 
            this.btn_connectlogin.Location = new System.Drawing.Point(259, 175);
            this.btn_connectlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_connectlogin.Name = "btn_connectlogin";
            this.btn_connectlogin.Size = new System.Drawing.Size(100, 28);
            this.btn_connectlogin.TabIndex = 5;
            this.btn_connectlogin.Text = "Connexion";
            this.btn_connectlogin.UseVisualStyleBackColor = true;
            this.btn_connectlogin.Click += new System.EventHandler(this.btn_connectlogin_Click);
            // 
            // sql_loginconnstring
            // 
            this.sql_loginconnstring.ConnectionString = "Data Source=DESKTOP-L5O173O;Initial Catalog=GestionMatos;Integrated Security=True" +
    "";
            this.sql_loginconnstring.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlcmd_login
            // 
            this.sqlcmd_login.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlcmd_login.Connection = this.sql_loginconnstring;
            this.sqlcmd_login.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("Parameter1", System.Data.SqlDbType.NVarChar),
            new System.Data.SqlClient.SqlParameter("Parameter2", System.Data.SqlDbType.NVarChar)});
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 321);
            this.Controls.Add(this.btn_connectlogin);
            this.Controls.Add(this.tb_passlogin);
            this.Controls.Add(this.tb_idlogin);
            this.Controls.Add(this.lb_passlogin);
            this.Controls.Add(this.lb_idlogin);
            this.Controls.Add(this.lb_gestionmatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - GestionMatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_gestionmatos;
        private System.Windows.Forms.Label lb_idlogin;
        private System.Windows.Forms.Label lb_passlogin;
        private System.Windows.Forms.TextBox tb_idlogin;
        private System.Windows.Forms.TextBox tb_passlogin;
        private System.Windows.Forms.Button btn_connectlogin;
        private System.Data.SqlClient.SqlConnection sql_loginconnstring;
        private System.Data.SqlClient.SqlCommand sqlcmd_login;
    }
}