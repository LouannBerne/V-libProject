namespace TestMenuDeroulant
{
    partial class FormVelo
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            dgvVelo = new DataGridView();
            btFermer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVelo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 0;
            label1.Text = "Liste des Vélos";
            // 
            // dgvVelo
            // 
            dataGridViewCellStyle2.BackColor = Color.DarkGray;
            dgvVelo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvVelo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVelo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVelo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVelo.Location = new Point(66, 101);
            dgvVelo.MultiSelect = false;
            dgvVelo.Name = "dgvVelo";
            dgvVelo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVelo.Size = new Size(639, 416);
            dgvVelo.TabIndex = 2;
            // 
            // btFermer
            // 
            btFermer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btFermer.Location = new Point(671, 588);
            btFermer.Name = "btFermer";
            btFermer.Size = new Size(98, 36);
            btFermer.TabIndex = 3;
            btFermer.Text = "Fermer";
            btFermer.UseVisualStyleBackColor = true;
            btFermer.Click += btFermer_Click;
            // 
            // FormVelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 650);
            Controls.Add(btFermer);
            Controls.Add(dgvVelo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVelo";
            Text = "FormVelo";
            Load += FormVelo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVelo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvVelo;
        private Button btFermer;
    }
}