using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMenuDeroulant
{
    public partial class FormVelo : Form
    {
        public FormVelo()
        {
            InitializeComponent();
        }

        private void btFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVelo_Load(object sender, EventArgs e)
        {
            remplirComboBorne();
            Modele.Velo listeVelo = new Modele.Velo();
            DataView dv = new DataView(listeVelo.ListeVelos());
            dgvVelo.DataSource = dv;
            dgvVelo.Columns[0].HeaderText = "Numéro Vélo";
            dgvVelo.Columns[1].HeaderText = "Numéro Borne";
            dgvVelo.Columns[2].HeaderText = "Nom de la Borne";
            dgvVelo.Columns[3].HeaderText = "Etat";
            dgvVelo.Refresh();

        }

        private void remplirComboBorne()
        {
            Modele.Borne listeB = new Modele.Borne();
            cbBorne.DataSource = listeB.ListeBornes(); // on récupère le dataTable des borne pour le mettre dans la source de données de la combo
            cbBorne.DisplayMember = "nomB"; //nom de la colonne qui sera affiché
            cbBorne.ValueMember = "codeB"; // nom de la colonne qui sera récupéré réellement
            cbBorne.SelectedIndex = -1; // pour ne pas afficher de valeur sélectionnée au départ
        }

        private void cbBorne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbBorne.SelectedIndex != -1) // si une borne est sélectionnée
            {
                // on récupère la valeur sélectionnée de la combo
                int codeBorne = Convert.ToInt32(cbBorne.SelectedValue);
                Modele.Velo listeVelo = new Modele.Velo();
                // on met à jour le datagridview avec le dataTable retourné
                DataView dv = new DataView(listeVelo.ListeVelosParBorne(codeBorne));
                dgvVelo.DataSource = dv;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            FormVelo_Load(sender, e);
        }
    }
}
