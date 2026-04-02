using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TestMenuDeroulant.Modele
{
    internal class Utilisateur
    {
        public DataTable loginUtilisateur(string login)
        {
            DataTable dt = new DataTable();
            try
            {
                string req = "SELECT  idUtilisateur, droit, loginUt, passwordUt FROM utilisateur WHERE loginUt = @login";
                using (MySqlCommand cmd = new MySqlCommand(req, Controleur.MaConnexion.MyConnection))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur dans la liste des utilisateur",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign, true);
            }
            return dt;
        }
    }
}
