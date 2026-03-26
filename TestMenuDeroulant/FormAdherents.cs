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
    public partial class FormAdherents : Form
    {
        public FormAdherents()
        {
            InitializeComponent();
        }

        private void FormProfil_Load(object sender, EventArgs e)
        {
            Modele.Adherant adherant = new Modele.Adherant();
            DataView da = new DataView(adherant.ListeAdherant());
            dgvAdherant.DataSource = da;
            dgvAdherant.Columns[0].HeaderText = "Numero Adherant";
            dgvAdherant.Columns[1].HeaderText = "Nom";
            dgvAdherant.Columns[2].HeaderText = "Prenom";
            dgvAdherant.Columns[3].HeaderText = "Email";
            dgvAdherant.Columns[4].HeaderText = "Telephone";
            dgvAdherant.Refresh();
        }

        private void btFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void suprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
