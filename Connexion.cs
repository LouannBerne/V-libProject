public class Connexion
{
    private MySqlConnection myConnection;
    private bool connopen = false;

    public MySqlConnection MyConnection { get => myConnection; set => myConnection = value; }
    public global::System.Boolean Connopen { get => connopen; set => connopen = value; }

    public void seconnecter() {
        string myConnectionString = "Database = lberne_TP3_BDVELIB; Data Source = 192.168.10.16; UserId = lberne; Password = Lilierlouann49!"; 
        myConnection = new MySqlConnection(myConnectionString);
        try // tentative
        {
            myConnection.Open();
            connopen = true;
        }
        catch (Exception err)// gestion des erreurs
        {
            MessageBox.Show("Erreur ouverture bdd : " + err, "PBS connection",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            connopen = false;
        }
    }
    public void sedeconnecter()
    {
        if (!connopen)
            return;
        try
        {
            myConnection.Close();
            myConnection.Dispose();
            connopen = false;
        }
        catch (Exception err)
        {
            MessageBox.Show("Erreur fermeture bdd : " + err, "PBS deconnection",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}