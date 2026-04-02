using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace TestMenuDeroulant
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();

            // Permet de redessiner le dégradé si la fenêtre change de taille
            this.Resize += (s, e) => this.Invalidate();
        }

        // Création du fond avec un dégradé vert
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (this.ClientRectangle.Width > 0 && this.ClientRectangle.Height > 0)
            {
                // Un dégradé vert clair vers vert foncé (90° = de haut en bas)
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    this.ClientRectangle,
                    Color.FromArgb(120, 200, 120), // Vert clair
                    Color.FromArgb(30, 100, 30),   // Vert foncé
                    90F))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtId.Text;
            string password = txtMdp.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Veuillez saisir votre nom d'utilisateur et votre mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupérer le compte sous forme de DataTable (tableau)
            Modele.Utilisateur loginUtlisateur = new Modele.Utilisateur();
            DataTable dtCompte = loginUtlisateur.loginUtilisateur(username);

            // Vérifier si un compte a été trouvé
            if (dtCompte.Rows.Count > 0)
            {
                // Extraire les données de la première ligne (index 0) du DataTable
                string recupLogin = dtCompte.Rows[0]["loginUt"].ToString();
                string recupMdp = dtCompte.Rows[0]["passwordUt"].ToString();
                string recupType = dtCompte.Rows[0]["droit"].ToString();

                // Comparer le mot de passe (si le mot de passe n'est pas haché dans la BDD - ce qui n'est pas recommandé pour la sécurité)
                if (BC.Verify(password, recupMdp))
                {
                    if (recupType == "1")
                    {
                        (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).enablebtn(true);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Permission utilisateur insufisante. Veuillez en referer a votre administrateur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Le nom d'utilisateur n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}