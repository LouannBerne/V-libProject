using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMenuDeroulant
{
    public partial class FormGestionVelo : Form
    {
        private EtatGestion etatGestion;
        private int numV;
        public FormGestionVelo(EtatGestion etatGestion, int numV)
        {
            InitializeComponent();
            this.etatGestion = etatGestion;
            if (etatGestion == EtatGestion.Update || etatGestion == EtatGestion.Delete)
                this.numV = numV;

        }

        private void FormGestionVelo_Load(object sender, EventArgs e)
        {
            remplirComboBorne();

            if (etatGestion == EtatGestion.Create)
            {
                lbGrandTitre.Text = "Ajouter un vélo";
                btModifier.Text = "Ajouter";
            }
            if (etatGestion == EtatGestion.Delete)
            {
                lbSuprimer.Visible = true;
                img1j1q.Visible = true;
                imgAttention.Visible = true;
                lbGrandTitre.Text = "Supprimer un vélo";
                btModifier.Text = "Supprimer";
                cbBorne.Enabled = false;
                cbEtat.Enabled = false;
            }

            if (etatGestion == EtatGestion.Delete || etatGestion == EtatGestion.Update)
            {
                Modele.Velo unVelo = new Modele.Velo();
                DataTable dt = unVelo.recupVelo(numV);
                tbNVelo.Text = numV.ToString();
                if (dt.Rows.Count > 0)
                {
                    cbBorne.SelectedValue = Convert.ToInt32(dt.Rows[0]["numB"]);
                    cbEtat.SelectedIndex = Convert.ToInt32(dt.Rows[0]["etatV"]);
                }
            }

            if (etatGestion == EtatGestion.Create)
            {
                // Code pour créer un nouveau vélo
                if (cbBorne.SelectedIndex != -1 && cbEtat.SelectedIndex != -1)
                {
                    int codeBorne = Convert.ToInt32(cbBorne.SelectedValue);
                    Modele.Velo unVelo = new Modele.Velo();
                    if (unVelo.insertVelo(codeBorne, cbEtat.SelectedIndex))
                    {
                        MessageBox.Show("Vélo ajouté avec succès !");
                        // peut-être remettre à vide les champs pour un prochain ajout
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'ajout du vélo.");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une borne et un état pour le vélo.");
                }
            }

            if (etatGestion == EtatGestion.Update)
            {
                
            }

            if (etatGestion == EtatGestion.Delete)
            {

            }
        }

        private void btFermer_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).openChildForm(new FormVelo());
        }

        private void remplirComboBorne()
        {
            Modele.Borne listeB = new Modele.Borne();
            cbBorne.DataSource = listeB.ListeBornes(); // on récupère le dataTable des borne pour le mettre dans la source de données de la combo
            cbBorne.DisplayMember = "nomB"; //nom de la colonne qui sera affiché
            cbBorne.ValueMember = "codeB"; // nom de la colonne qui sera récupéré réellement
            cbBorne.SelectedIndex = -1; // pour ne pas afficher de valeur sélectionnée au départ
        }
    }
}
