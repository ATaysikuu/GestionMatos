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
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.lb_client = new System.Windows.Forms.Label();
            this.lb_nom = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_client = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(591, 348);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(112, 46);
            this.btn_Edit.TabIndex = 48;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(472, 348);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(112, 46);
            this.btn_Ok.TabIndex = 47;
            this.btn_Ok.Text = "Add";
            this.btn_Ok.UseVisualStyleBackColor = true;
            // 
            // lb_client
            // 
            this.lb_client.AutoSize = true;
            this.lb_client.Location = new System.Drawing.Point(98, 158);
            this.lb_client.Name = "lb_client";
            this.lb_client.Size = new System.Drawing.Size(49, 20);
            this.lb_client.TabIndex = 46;
            this.lb_client.Text = "Client";
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Location = new System.Drawing.Point(98, 57);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(42, 20);
            this.lb_nom.TabIndex = 41;
            this.lb_nom.Text = "Nom";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(102, 80);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(100, 26);
            this.tb_nom.TabIndex = 40;
            this.tb_nom.Text = "Nom";
            // 
            // tb_client
            // 
            this.tb_client.Location = new System.Drawing.Point(102, 181);
            this.tb_client.Name = "tb_client";
            this.tb_client.Size = new System.Drawing.Size(100, 26);
            this.tb_client.TabIndex = 35;
            this.tb_client.Text = "Client";
            // 
            // F_Site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lb_client);
            this.Controls.Add(this.lb_nom);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.tb_client);
            this.Name = "F_Site";
            this.Text = "F_Site";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lb_client;
        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_client;
    }
}