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

        public DataTable ListeVelosParBorne(int codeBorne)
        {
            DataTable dt = new DataTable();
            try
            {
                // on crée la requête avec un paramètre
                string req = "select numV, numB, nomB, etatV from veloelectrique inner join borne on codeB = numB where numB = " + @codeBorne;
                using (MySqlCommand cmd = new MySqlCommand(req, Controleur.MaConnexion.MyConnection))
                {
                    // on met à jour le paramètre de la requête avec le paramètre de la méthode
                    cmd.Parameters.AddWithValue("@codeBorne", "%" + codeBorne + "%");
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur dans la liste des vélos électriques par borne", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign, true);
            }
            return dt;
        }

        public DataTable recupVelo(int num)
        {
            DataTable dt = new DataTable();
            try
            {
                string req = "SELECT numV, numB, nomB, etatV FROM veloelectrique left join borne ON codeB = numB WHERE numV = " + @num;
                using (MySqlCommand cmd = new MySqlCommand(req, Controleur.MaConnexion.MyConnection))
                {
                    cmd.Parameters.AddWithValue("@num", "%" + num + "%");
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

        public bool insertVelo(int numB, int etatV)
        {
            bool ajout = false;
            try
            {
                string req = "INSERT INTO veloelectrique (numV, numB, etatV) VALUES (NULL, @numB, @etatV)";
            MySqlCommand cmd = new MySqlCommand(req,
            Controleur.MaConnexion.MyConnection);
                cmd.Parameters.AddWithValue("@numB", numB);
                cmd.Parameters.AddWithValue("@etatV", etatV);
                cmd.ExecuteNonQuery();
                ajout = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur lors de l'insertion d'un vélo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign, true);
            }
            return ajout;
        }

        public bool updateVelo(int numV, int numB, int etatV)
        {
            bool ajout = false;
            try
            {
                string req = $"INSERT INTO veloelectrique (numV, numB, etatV) VALUES ({@numV}, {@numB}, {@etatV})";
                MySqlCommand cmd = new MySqlCommand(req,
                Controleur.MaConnexion.MyConnection);
                cmd.Parameters.AddWithValue("@numB", numB);
                cmd.Parameters.AddWithValue("@etatV", etatV);
                cmd.Parameters.AddWithValue("@numV", numV);
                cmd.ExecuteNonQuery();
                ajout = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur lors de l'insertion d'un vélo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign, true);
            }
            return ajout;
        }

        public bool deleteVelo(int numV)
        {
            bool ajout = false;
            try
            {
                string req = $"DELETE FROM veloelectrique WHERE numV = {@numV}";
                MySqlCommand cmd = new MySqlCommand(req,
                Controleur.MaConnexion.MyConnection);
                cmd.Parameters.AddWithValue("@numV", numV);
                cmd.ExecuteNonQuery();
                ajout = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur lors de l'insertion d'un vélo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign, true);
            }
            return ajout;
        }
    }
}
