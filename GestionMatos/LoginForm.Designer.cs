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
            this.lb_idlogin = new System.Windows.Forms.Label();
            this.lb_passlogin = new System.Windows.Forms.Label();
            this.tb_idlogin = new System.Windows.Forms.TextBox();
            this.tb_passlogin = new System.Windows.Forms.TextBox();
            this.btn_connectlogin = new System.Windows.Forms.Button();
            this.sql_loginconnstring = new System.Data.SqlClient.SqlConnection();
            this.sqlcmd_login = new System.Data.SqlClient.SqlCommand();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_idlogin
            // 
            this.lb_idlogin.AutoSize = true;
            this.lb_idlogin.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idlogin.Location = new System.Drawing.Point(28, 86);
            this.lb_idlogin.Name = "lb_idlogin";
            this.lb_idlogin.Size = new System.Drawing.Size(69, 20);
            this.lb_idlogin.TabIndex = 1;
            this.lb_idlogin.Text = "Identifiant";
            // 
            // lb_passlogin
            // 
            this.lb_passlogin.AutoSize = true;
            this.lb_passlogin.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_passlogin.Location = new System.Drawing.Point(28, 117);
            this.lb_passlogin.Name = "lb_passlogin";
            this.lb_passlogin.Size = new System.Drawing.Size(92, 20);
            this.lb_passlogin.TabIndex = 2;
            this.lb_passlogin.Text = "Mot de passe";
            // 
            // tb_idlogin
            // 
            this.tb_idlogin.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idlogin.Location = new System.Drawing.Point(130, 86);
            this.tb_idlogin.Name = "tb_idlogin";
            this.tb_idlogin.Size = new System.Drawing.Size(150, 27);
            this.tb_idlogin.TabIndex = 3;
            // 
            // tb_passlogin
            // 
            this.tb_passlogin.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passlogin.Location = new System.Drawing.Point(130, 119);
            this.tb_passlogin.Name = "tb_passlogin";
            this.tb_passlogin.PasswordChar = '*';
            this.tb_passlogin.Size = new System.Drawing.Size(150, 27);
            this.tb_passlogin.TabIndex = 4;
            // 
            // btn_connectlogin
            // 
            this.btn_connectlogin.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connectlogin.Location = new System.Drawing.Point(180, 152);
            this.btn_connectlogin.Name = "btn_connectlogin";
            this.btn_connectlogin.Size = new System.Drawing.Size(100, 30);
            this.btn_connectlogin.TabIndex = 5;
            this.btn_connectlogin.Text = "Connexion";
            this.btn_connectlogin.UseVisualStyleBackColor = true;
            this.btn_connectlogin.Click += new System.EventHandler(this.btn_connectlogin_Click);
            // 
            // sql_loginconnstring
            // 
            this.sql_loginconnstring.ConnectionString = "Data Source=.;Initial Catalog=GestionMatos;Integrated Security=True";
            this.sql_loginconnstring.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlcmd_login
            // 
            this.sqlcmd_login.CommandText = "loginUser";
            this.sqlcmd_login.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlcmd_login.Connection = this.sql_loginconnstring;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestionMatos.Properties.Resources.logo_mfc;
            this.pictureBox2.Location = new System.Drawing.Point(130, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lb_idlogin);
            this.panel1.Controls.Add(this.btn_connectlogin);
            this.panel1.Controls.Add(this.lb_passlogin);
            this.panel1.Controls.Add(this.tb_passlogin);
            this.panel1.Controls.Add(this.tb_idlogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 211);
            this.panel1.TabIndex = 8;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - GestionMatos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_idlogin;
        private System.Windows.Forms.Label lb_passlogin;
        private System.Windows.Forms.TextBox tb_idlogin;
        private System.Windows.Forms.TextBox tb_passlogin;
        private System.Windows.Forms.Button btn_connectlogin;
        private System.Data.SqlClient.SqlConnection sql_loginconnstring;
        private System.Data.SqlClient.SqlCommand sqlcmd_login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}