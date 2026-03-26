namespace TestMenuDeroulant
{
    partial class FormAdherents
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            btFermer = new Button();
            dgvAdherant = new DataGridView();
            cmsEdition = new ContextMenuStrip(components);
            ajouterToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            suprimerToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvAdherant).BeginInit();
            cmsEdition.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(9, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 32);
            label1.TabIndex = 0;
            label1.Text = "Gestion des Adhérents";
            // 
            // btFermer
            // 
            btFermer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btFermer.Location = new Point(690, 602);
            btFermer.Margin = new Padding(2);
            btFermer.Name = "btFermer";
            btFermer.Size = new Size(98, 36);
            btFermer.TabIndex = 2;
            btFermer.Text = "Fermer";
            btFermer.UseVisualStyleBackColor = true;
            btFermer.Click += btFermer_Click;
            // 
            // dgvAdherant
            // 
            dgvAdherant.AllowUserToAddRows = false;
            dgvAdherant.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.DarkGray;
            dgvAdherant.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAdherant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdherant.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAdherant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdherant.ContextMenuStrip = cmsEdition;
            dgvAdherant.Location = new Point(12, 124);
            dgvAdherant.Margin = new Padding(2);
            dgvAdherant.MultiSelect = false;
            dgvAdherant.Name = "dgvAdherant";
            dgvAdherant.ReadOnly = true;
            dgvAdherant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdherant.Size = new Size(776, 450);
            dgvAdherant.TabIndex = 3;
            // 
            // cmsEdition
            // 
            cmsEdition.Items.AddRange(new ToolStripItem[] { ajouterToolStripMenuItem, modifierToolStripMenuItem, suprimerToolStripMenuItem });
            cmsEdition.Name = "cmsEdition";
            cmsEdition.Size = new Size(181, 92);
            // 
            // ajouterToolStripMenuItem
            // 
            ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            ajouterToolStripMenuItem.Size = new Size(180, 22);
            ajouterToolStripMenuItem.Text = "Ajouter";
            ajouterToolStripMenuItem.Click += ajouterToolStripMenuItem_Click;
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(180, 22);
            modifierToolStripMenuItem.Text = "Modifier";
            modifierToolStripMenuItem.Click += modifierToolStripMenuItem_Click;
            // 
            // suprimerToolStripMenuItem
            // 
            suprimerToolStripMenuItem.Name = "suprimerToolStripMenuItem";
            suprimerToolStripMenuItem.Size = new Size(180, 22);
            suprimerToolStripMenuItem.Text = "Suprimer";
            suprimerToolStripMenuItem.Click += suprimerToolStripMenuItem_Click;
            // 
            // FormAdherents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 650);
            Controls.Add(dgvAdherant);
            Controls.Add(btFermer);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAdherents";
            Text = "FormProfil";
            Load += FormProfil_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdherant).EndInit();
            cmsEdition.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btFermer;
        private DataGridView dgvAdherant;
        private ContextMenuStrip cmsEdition;
        private ToolStripMenuItem ajouterToolStripMenuItem;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem suprimerToolStripMenuItem;
    }
}