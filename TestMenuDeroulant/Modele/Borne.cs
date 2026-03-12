using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestMenuDeroulant.Modele
{
    internal class Borne
    {
        public DataTable ListeBornes()
        {
            DataTable dt = new DataTable();
            try
            {
                string req = "SELECT codeB, nomB, latitudeB, longitudeB FROM borne;";
                using (MySqlCommand cmd = new MySqlCommand(req, Controleur.MaConnexion.MyConnection))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur dans la liste des vélos électriques",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign, true);
            }
            return dt;
        }
    }
}
