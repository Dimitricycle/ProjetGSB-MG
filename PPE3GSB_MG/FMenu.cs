using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3GSB_MG
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void FMenu_Load(object sender, EventArgs e)
        {
            label1.Text = "Bonjour " + Modele.GetAffiche().prenom;
        }

        private void Information_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OuvertureInfo));
            t.Start();
            this.Close();
        }
        public static void OuvertureInfo()
        {
            Application.Run(new FInformation());
        }

        private void Responsable_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OuvertureRes));
            t.Start();
            this.Close();
        }
        public static void OuvertureRes()
        {
            Application.Run(new FResponsabiliter());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LVisiteur_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OuvertureListeVisiteur));
            t.Start();
            this.Close();
        }
        public static void OuvertureListeVisiteur()
        {
            Application.Run(new FListeVisiteurR());
        }

        
        private void Responsable_VisibleChanged(object sender, EventArgs e)
        {
            int droit = 0;
            foreach (Region r in Modele.listeRegion())
            {
                if (r.idVisiteur == Modele.GetAffiche().idVisiteur)
                {
                    droit = 1;
                }
            }

            foreach (Secteur s in Modele.listeSecteur())
            {
                if (s.idVisiteur == Modele.GetAffiche().idVisiteur)
                {
                    droit = 1;
                }
            }

            if (droit == 0)
            {
                Responsable.Visible = false;
                Budget.Visible = false;
            }
        }
    }
}
