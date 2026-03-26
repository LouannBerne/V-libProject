namespace TestMenuDeroulant
{
    partial class FormGestionVelo
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
            lbGrandTitre = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbBorne = new ComboBox();
            cbEtat = new ComboBox();
            btModifier = new Button();
            btFermer = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tbNVelo = new TextBox();
            imgAttention = new PictureBox();
            lbSuprimer = new Label();
            img1j1q = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgAttention).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img1j1q).BeginInit();
            SuspendLayout();
            // 
            // lbGrandTitre
            // 
            lbGrandTitre.AutoSize = true;
            lbGrandTitre.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbGrandTitre.Location = new Point(13, 9);
            lbGrandTitre.Margin = new Padding(4, 0, 4, 0);
            lbGrandTitre.Name = "lbGrandTitre";
            lbGrandTitre.Size = new Size(205, 32);
            lbGrandTitre.TabIndex = 1;
            lbGrandTitre.Text = "Modifier un vélo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 124);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 2;
            label2.Text = "Numéro du vélo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 163);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 2;
            label3.Text = "Borne d'affiliation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(102, 204);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 2;
            label4.Text = "Etat du vélo";
            // 
            // cbBorne
            // 
            cbBorne.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBorne.FormattingEnabled = true;
            cbBorne.Location = new Point(268, 164);
            cbBorne.Name = "cbBorne";
            cbBorne.Size = new Size(121, 23);
            cbBorne.TabIndex = 3;
            // 
            // cbEtat
            // 
            cbEtat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEtat.FormattingEnabled = true;
            cbEtat.Items.AddRange(new object[] { "En maintenance", "En service", "En recharge" });
            cbEtat.Location = new Point(268, 204);
            cbEtat.Name = "cbEtat";
            cbEtat.Size = new Size(121, 23);
            cbEtat.TabIndex = 3;
            // 
            // btModifier
            // 
            btModifier.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btModifier.Location = new Point(549, 604);
            btModifier.Name = "btModifier";
            btModifier.Size = new Size(90, 34);
            btModifier.TabIndex = 4;
            btModifier.Text = "Modifier";
            btModifier.UseVisualStyleBackColor = true;
            // 
            // btFermer
            // 
            btFermer.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btFermer.Location = new Point(677, 604);
            btFermer.Name = "btFermer";
            btFermer.Size = new Size(90, 34);
            btFermer.TabIndex = 4;
            btFermer.Text = "Fermer";
            btFermer.UseVisualStyleBackColor = true;
            btFermer.Click += btFermer_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.R;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(533, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 220);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.jeune_homme_tomber_de_facon_spectaculaire_a_velo_c3h2w0;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(102, 273);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(319, 254);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // tbNVelo
            // 
            tbNVelo.Location = new Point(268, 124);
            tbNVelo.Name = "tbNVelo";
            tbNVelo.ReadOnly = true;
            tbNVelo.Size = new Size(121, 23);
            tbNVelo.TabIndex = 6;
            // 
            // imgAttention
            // 
            imgAttention.BackgroundImage = Properties.Resources.R__1_;
            imgAttention.BackgroundImageLayout = ImageLayout.Zoom;
            imgAttention.InitialImage = null;
            imgAttention.Location = new Point(433, 471);
            imgAttention.Name = "imgAttention";
            imgAttention.Size = new Size(129, 110);
            imgAttention.TabIndex = 5;
            imgAttention.TabStop = false;
            imgAttention.Visible = false;
            // 
            // lbSuprimer
            // 
            lbSuprimer.AutoSize = true;
            lbSuprimer.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSuprimer.ForeColor = Color.Crimson;
            lbSuprimer.Location = new Point(568, 471);
            lbSuprimer.Name = "lbSuprimer";
            lbSuprimer.Size = new Size(220, 20);
            lbSuprimer.TabIndex = 2;
            lbSuprimer.Text = "ATTENTION TU VAS SUPPRIMER";
            lbSuprimer.Visible = false;
            // 
            // img1j1q
            // 
            img1j1q.BackgroundImage = Properties.Resources.OIP;
            img1j1q.BackgroundImageLayout = ImageLayout.Zoom;
            img1j1q.InitialImage = null;
            img1j1q.Location = new Point(600, 494);
            img1j1q.Name = "img1j1q";
            img1j1q.Size = new Size(129, 104);
            img1j1q.TabIndex = 5;
            img1j1q.TabStop = false;
            img1j1q.Visible = false;
            // 
            // FormGestionVelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(800, 650);
            Controls.Add(tbNVelo);
            Controls.Add(img1j1q);
            Controls.Add(imgAttention);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btFermer);
            Controls.Add(btModifier);
            Controls.Add(cbEtat);
            Controls.Add(cbBorne);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbSuprimer);
            Controls.Add(label2);
            Controls.Add(lbGrandTitre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionVelo";
            Text = "FormGestionVelo";
            Load += FormGestionVelo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgAttention).EndInit();
            ((System.ComponentModel.ISupportInitialize)img1j1q).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbGrandTitre;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbBorne;
        private ComboBox cbEtat;
        private Button btModifier;
        private Button btFermer;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox tbNVelo;
        private PictureBox imgAttention;
        private Label lbSuprimer;
        private PictureBox img1j1q;
    }
}