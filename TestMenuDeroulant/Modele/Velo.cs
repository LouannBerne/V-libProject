using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMenuDeroulant.Modele
{
    public class Velo
    {
        public DataTable ListeVelos()
        {
            DataTable dt = new DataTable();
            try
            {
                string req = "SELECT numV, numB, nomB, etatV FROM veloelectrique left join borne ON codeB = numB";
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
