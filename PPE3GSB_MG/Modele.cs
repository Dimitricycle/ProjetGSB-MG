using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PPE3GSB_MG
{
    class Modele
    {
        private static connectGSB maConnexion;
        private static bool connexionValide;
        private static string identite;


        public static connectGSB MaConnexion { get => maConnexion; set => maConnexion = value; }


        public static void init()
        {
            MaConnexion = new connectGSB();
            connexionValide = false;
        }

        public static List<Visiteur> listeVisiteur()
        {
            return MaConnexion.Visiteur.ToList();
        }

        public static List<RAPPORT> ListeRapport()
        {
            return maConnexion.RAPPORT.ToList();
        }

        public static void Connexion(string id, string mdp)
        {
            Visiteur vi = ListeID(id);
            if(vi != null)
            {
                if(CryptMDP(mdp)==vi.password)
                {
                    connexionValide = true;
                }
            }
        }

        public static bool ValidationConnexion()
        {
            return connexionValide;
        }

        public static Visiteur ListeID(string id)
        {
            identite = id;
            Visiteur vretour = null;
            var LQuery = MaConnexion.Visiteur.ToList()
                .Where(x => x.identifiant == id);
            if(LQuery.ToList().Count==1)
            {
                vretour = (Visiteur)LQuery.ToList()[0];
            }
            return vretour;    
        }

        public static string Affiche()
        {
            return identite;
        }

        private static string CryptMDP(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

    }
}
