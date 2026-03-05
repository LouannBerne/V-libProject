using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TestMenuDeroulant
{
    partial class Form1
    {
        private IContainer components = null;
        private Panel panelMenu;
        private Panel panelContent;
        private Button btnToggle;
        private Button btnItem1;
        private Button btnItem2;
        private Button btnItem3;
        private Button btnItem4;
        private System.Windows.Forms.Timer timerMenu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            panelMenu = new Panel();
            btnItem4 = new Button();
            btnItem3 = new Button();
            btnItem2 = new Button();
            btnItem1 = new Button();
            btnToggle = new Button();
            panelContent = new Panel();
            timerMenu = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(33, 37, 43);
            panelMenu.Controls.Add(btnItem4);
            panelMenu.Controls.Add(btnItem3);
            panelMenu.Controls.Add(btnItem2);
            panelMenu.Controls.Add(btnItem1);
            panelMenu.Controls.Add(btnToggle);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(229, 867);
            panelMenu.TabIndex = 1;
            // 
            // btnItem4
            // 
            btnItem4.BackColor = Color.FromArgb(33, 37, 43);
            btnItem4.Dock = DockStyle.Top;
            btnItem4.FlatAppearance.BorderSize = 0;
            btnItem4.FlatStyle = FlatStyle.Flat;
            btnItem4.Font = new Font("Segoe UI", 10F);
            btnItem4.ForeColor = Color.White;
            btnItem4.Location = new Point(0, 256);
            btnItem4.Margin = new Padding(3, 4, 3, 4);
            btnItem4.Name = "btnItem4";
            btnItem4.Padding = new Padding(14, 0, 0, 0);
            btnItem4.Size = new Size(229, 64);
            btnItem4.TabIndex = 0;
            btnItem4.Text = "🔒  Déconnexion";
            btnItem4.TextAlign = ContentAlignment.MiddleLeft;
            btnItem4.UseVisualStyleBackColor = false;
            btnItem4.Click += btnItem4_Click;
            // 
            // btnItem3
            // 
            btnItem3.BackColor = Color.FromArgb(33, 37, 43);
            btnItem3.Dock = DockStyle.Top;
            btnItem3.FlatAppearance.BorderSize = 0;
            btnItem3.FlatStyle = FlatStyle.Flat;
            btnItem3.Font = new Font("Segoe UI", 10F);
            btnItem3.ForeColor = Color.White;
            btnItem3.Location = new Point(0, 192);
            btnItem3.Margin = new Padding(3, 4, 3, 4);
            btnItem3.Name = "btnItem3";
            btnItem3.Padding = new Padding(14, 0, 0, 0);
            btnItem3.Size = new Size(229, 64);
            btnItem3.TabIndex = 1;
            btnItem3.Text = "⚙️  Paramètres";
            btnItem3.TextAlign = ContentAlignment.MiddleLeft;
            btnItem3.UseVisualStyleBackColor = false;
            btnItem3.Click += btnItem3_Click;
            // 
            // btnItem2
            // 
            btnItem2.BackColor = Color.FromArgb(33, 37, 43);
            btnItem2.Dock = DockStyle.Top;
            btnItem2.FlatAppearance.BorderSize = 0;
            btnItem2.FlatStyle = FlatStyle.Flat;
            btnItem2.Font = new Font("Segoe UI", 10F);
            btnItem2.ForeColor = Color.White;
            btnItem2.Location = new Point(0, 128);
            btnItem2.Margin = new Padding(3, 4, 3, 4);
            btnItem2.Name = "btnItem2";
            btnItem2.Padding = new Padding(14, 0, 0, 0);
            btnItem2.Size = new Size(229, 64);
            btnItem2.TabIndex = 2;
            btnItem2.Text = "👤  Profil";
            btnItem2.TextAlign = ContentAlignment.MiddleLeft;
            btnItem2.UseVisualStyleBackColor = false;
            btnItem2.Click += btnItem2_Click;
            // 
            // btnItem1
            // 
            btnItem1.BackColor = Color.FromArgb(33, 37, 43);
            btnItem1.Dock = DockStyle.Top;
            btnItem1.FlatAppearance.BorderSize = 0;
            btnItem1.FlatStyle = FlatStyle.Flat;
            btnItem1.Font = new Font("Segoe UI", 10F);
            btnItem1.ForeColor = Color.White;
            btnItem1.Location = new Point(0, 64);
            btnItem1.Margin = new Padding(3, 4, 3, 4);
            btnItem1.Name = "btnItem1";
            btnItem1.Padding = new Padding(14, 0, 0, 0);
            btnItem1.Size = new Size(229, 64);
            btnItem1.TabIndex = 3;
            btnItem1.Text = "🏠  Accueil";
            btnItem1.TextAlign = ContentAlignment.MiddleLeft;
            btnItem1.UseVisualStyleBackColor = false;
            btnItem1.Click += btnItem1_Click;
            // 
            // btnToggle
            // 
            btnToggle.BackColor = Color.FromArgb(45, 49, 56);
            btnToggle.Dock = DockStyle.Top;
            btnToggle.FlatAppearance.BorderSize = 0;
            btnToggle.FlatStyle = FlatStyle.Flat;
            btnToggle.Font = new Font("Segoe UI", 11F);
            btnToggle.ForeColor = Color.White;
            btnToggle.Location = new Point(0, 0);
            btnToggle.Margin = new Padding(3, 4, 3, 4);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(229, 64);
            btnToggle.TabIndex = 4;
            btnToggle.Text = "◀";
            btnToggle.UseVisualStyleBackColor = false;
            btnToggle.Click += btnToggle_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.WhiteSmoke;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(229, 0);
            panelContent.Margin = new Padding(3, 4, 3, 4);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(914, 867);
            panelContent.TabIndex = 0;
            // 
            // timerMenu
            // 
            timerMenu.Interval = 15;
            timerMenu.Tick += timerMenu_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 867);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu déroulant gauche";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}