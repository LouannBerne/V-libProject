using System;

public static class Controleur
{
	private model.Connexion maConnexion;

    public Controleur()
	{
	}

    public model.Connexion MaConnexion { get => maConnexion; set => maConnexion = value; }
}
