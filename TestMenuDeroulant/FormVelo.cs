using MySql.Data.MySqlClient;
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
            Modele.Velo listeVelo = new Modele.Velo();
            DataView dv = new DataView(listeVelo.ListeVelos());
            dgvVelo.DataSource = dv;

        }

    }
}
