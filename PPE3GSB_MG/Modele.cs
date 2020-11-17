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
        private static Visiteur uti;
        private static connectGSB maConnexion;
        private static bool connexionValide;


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

        public static void Connexion(string id, string mdp)
        {
            uti = ListeID(id);
            if(uti != null)
            {
                if(CryptMDP(mdp)==uti.password)
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
            Visiteur vretour = null;
            var LQuery = MaConnexion.Visiteur.ToList()
                .Where(x => x.identifiant == id);
            if(LQuery.ToList().Count==1)
            {
                vretour = (Visiteur)LQuery.ToList()[0];
            }
            return vretour;    
        }

        public static Visiteur GetAffiche()
        {
            return uti;
            //uppercase pour mettre en majuscule
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

        public static bool EnregistreUser(string nom, string prenom, string rue, string CP, string ville)
        {
            bool vRetour = true;
            try
            {
                uti.nom = nom;
                uti.prenom = prenom;
                uti.rue = rue;
                uti.cp = CP;
                uti.ville = ville;
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("erreur de saisie ! \nErreur système :" + ex.Message);
                vRetour = false;
            }
            return vRetour;
        }

        public static bool EnregistreMDP(string nMDP, string confirmation)
        {
            bool vRetour = true;
            try
            {

                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("erreur de saisie ! \nErreur système :" + ex.Message);
                vRetour = false;
            }
            return vRetour;
        }
    }
}
