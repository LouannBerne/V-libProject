namespace TestMenuDeroulant
{
    partial class FormConnexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlCentre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnLogin;

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
            this.pnlCentre = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            
            this.pnlCentre.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // pnlCentre (Le carré blanc au milieu)
            // 
            this.pnlCentre.Anchor = System.Windows.Forms.AnchorStyles.None; // Reste au centre même si form redimensionnée
            this.pnlCentre.BackColor = System.Drawing.Color.White;
            this.pnlCentre.Controls.Add(this.btnLogin);
            this.pnlCentre.Controls.Add(this.txtMdp);
            this.pnlCentre.Controls.Add(this.lblMdp);
            this.pnlCentre.Controls.Add(this.txtId);
            this.pnlCentre.Controls.Add(this.lblId);
            this.pnlCentre.Controls.Add(this.lblTitre);
            this.pnlCentre.Location = new System.Drawing.Point(250, 75); // Centré par rapport aux 800x450 standards
            this.pnlCentre.Name = "pnlCentre";
            this.pnlCentre.Size = new System.Drawing.Size(300, 300);
            this.pnlCentre.TabIndex = 0;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(30, 100, 30);
            this.lblTitre.Location = new System.Drawing.Point(85, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(125, 30);
            this.lblTitre.TabIndex = 5;
            this.lblTitre.Text = "Connexion";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(30, 80);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(67, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Identifiant";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(30, 100);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(240, 27);
            this.txtId.TabIndex = 1;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMdp.Location = new System.Drawing.Point(30, 145);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(77, 15);
            this.lblMdp.TabIndex = 2;
            this.lblMdp.Text = "Mot de passe";
            // 
            // txtMdp
            // 
            this.txtMdp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMdp.Location = new System.Drawing.Point(30, 165);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '●';
            this.txtMdp.Size = new System.Drawing.Size(240, 27);
            this.txtMdp.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(30, 220);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(240, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "SE CONNECTER";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450); // Taille par défaut de Form1
            this.Controls.Add(this.pnlCentre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Désactive les bordures 
            this.Name = "FormConnexion";
            this.Text = "Connexion";
            this.DoubleBuffered = true; // Empêche le clignotement lors du dessin du fond
            
            this.pnlCentre.ResumeLayout(false);
            this.pnlCentre.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}