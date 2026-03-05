using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestMenuDeroulant
            {
    public partial class Form1 : Form
    {
        private bool _menuExpanded = true;
        private const int ExpandedWidth = 200;
        private const int CollapsedWidth = 60;
        private const int AnimationStep = 12;

        public Form1()
        {
            InitializeComponent();
            ConfigureMenuInitialState();
        }

        public Form activeForm = null;
        /// <summary>
        /// cette méthode permet d'ouvrir un formulaire enfant dans le panelContent
        /// </summary>
        /// <param name="formEnfant"></param>
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            panelContent.Controls.Add(formEnfant);
            panelContent.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }
        private void ConfigureMenuInitialState()
        {
            // Assure l'état initial (ouvert)
            panelMenu.Width = ExpandedWidth;
            UpdateButtonsForState(_menuExpanded);
            btnToggle.Text = "◀"; // permet de fermer
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            // Inverse l'état et lance l'animation
            _menuExpanded = !_menuExpanded;
            timerMenu.Start();
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (_menuExpanded)
            {
                // Ouverture : augmenter la largeur jusqu'à ExpandedWidth
                if (panelMenu.Width < ExpandedWidth)
                {
                    panelMenu.Width = Math.Min(ExpandedWidth, panelMenu.Width + AnimationStep);
                }
                else
                {
                    timerMenu.Stop();
                    UpdateButtonsForState(true);
                    btnToggle.Text = "◀";
                }
            }
            else
            {
                // Fermeture : diminuer la largeur jusqu'à CollapsedWidth
                if (panelMenu.Width > CollapsedWidth)
                {
                    panelMenu.Width = Math.Max(CollapsedWidth, panelMenu.Width - AnimationStep);
                }
                else
                {
                    timerMenu.Stop();
                    UpdateButtonsForState(false);
                    btnToggle.Text = "▶";
                }
            }
        }

        private void UpdateButtonsForState(bool expanded)
        {
            // Quand expanded = true, affiche "emoji + label".
            // Quand expanded = false, n'affiche que l'emoji.
            if (expanded)
            {
                btnItem1.Text = "🚲  Vélo";
                btnItem2.Text = "👤  Profil";
                btnItem3.Text = "⚙️  Paramètres";
                btnItem4.Text = "🔒  Déconnexion";

                // Alignement et style quand développé
                foreach (Control c in panelMenu.Controls)
                {
                    if (c is Button b)
                    {
                        b.TextAlign = ContentAlignment.MiddleLeft;
                        b.Padding = new Padding(12, 0, 0, 0);
                    }
                }
            }
            else
            {
                btnItem1.Text = "🚲";
                btnItem2.Text = "👤";
                btnItem3.Text = "⚙️";
                btnItem4.Text = "🔒";

                foreach (Control c in panelMenu.Controls)
                {
                    if (c is Button b)
                    {
                        b.TextAlign = ContentAlignment.MiddleCenter;
                        b.Padding = new Padding(0);
                    }
                }
            }
        }

        // Exemples d'actions pour les items
        private void btnItem1_Click(object sender, EventArgs e)
        {
            ShowContent("Accueil");
        }

        private void btnItem2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProfil()); // Ouvre un formulaire enfant pour le profil
        }

        private void btnItem3_Click(object sender, EventArgs e)
        {
            ShowContent("Paramètres");
        }

        private void btnItem4_Click(object sender, EventArgs e)
        {
            ShowContent("Déconnexion");
            Application.Exit(); // Ferme l'application
        }

        private void ShowContent(string name)
        {
            panelContent.Controls.Clear();
            var lbl = new Label
            {
                Text = $"Écran : {name}",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 16, FontStyle.Bold)
            };
            panelContent.Controls.Add(lbl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
