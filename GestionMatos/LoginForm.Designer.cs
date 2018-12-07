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
            this.SuspendLayout();
            // 
            // lb_gestionmatos
            // 
            this.lb_gestionmatos.AutoSize = true;
            this.lb_gestionmatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gestionmatos.Location = new System.Drawing.Point(12, 9);
            this.lb_gestionmatos.Name = "lb_gestionmatos";
            this.lb_gestionmatos.Size = new System.Drawing.Size(182, 31);
            this.lb_gestionmatos.TabIndex = 0;
            this.lb_gestionmatos.Text = "GestionMatos";
            // 
            // lb_idlogin
            // 
            this.lb_idlogin.AutoSize = true;
            this.lb_idlogin.Location = new System.Drawing.Point(106, 97);
            this.lb_idlogin.Name = "lb_idlogin";
            this.lb_idlogin.Size = new System.Drawing.Size(53, 13);
            this.lb_idlogin.TabIndex = 1;
            this.lb_idlogin.Text = "Identifiant";
            // 
            // lb_passlogin
            // 
            this.lb_passlogin.AutoSize = true;
            this.lb_passlogin.Location = new System.Drawing.Point(88, 123);
            this.lb_passlogin.Name = "lb_passlogin";
            this.lb_passlogin.Size = new System.Drawing.Size(71, 13);
            this.lb_passlogin.TabIndex = 2;
            this.lb_passlogin.Text = "Mot de passe";
            // 
            // tb_idlogin
            // 
            this.tb_idlogin.Location = new System.Drawing.Point(169, 89);
            this.tb_idlogin.Name = "tb_idlogin";
            this.tb_idlogin.Size = new System.Drawing.Size(100, 20);
            this.tb_idlogin.TabIndex = 3;
            // 
            // tb_passlogin
            // 
            this.tb_passlogin.Location = new System.Drawing.Point(169, 116);
            this.tb_passlogin.Name = "tb_passlogin";
            this.tb_passlogin.PasswordChar = '*';
            this.tb_passlogin.Size = new System.Drawing.Size(100, 20);
            this.tb_passlogin.TabIndex = 4;
            // 
            // btn_connectlogin
            // 
            this.btn_connectlogin.Location = new System.Drawing.Point(194, 142);
            this.btn_connectlogin.Name = "btn_connectlogin";
            this.btn_connectlogin.Size = new System.Drawing.Size(75, 23);
            this.btn_connectlogin.TabIndex = 5;
            this.btn_connectlogin.Text = "Connexion";
            this.btn_connectlogin.UseVisualStyleBackColor = true;
            this.btn_connectlogin.Click += new System.EventHandler(this.btn_connectlogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btn_connectlogin);
            this.Controls.Add(this.tb_passlogin);
            this.Controls.Add(this.tb_idlogin);
            this.Controls.Add(this.lb_passlogin);
            this.Controls.Add(this.lb_idlogin);
            this.Controls.Add(this.lb_gestionmatos);
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
    }
}