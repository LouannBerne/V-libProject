using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMenuDeroulant.Modele;

namespace TestMenuDeroulant
{
    public static class Controleur
    {
        private static Modele.Connexion maConnexion;

        public static Connexion MaConnexion { get => maConnexion; set => maConnexion = value; }

        public static void init()
        {
            maConnexion = new Modele.Connexion();
        }
    }
}
