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
    public partial class FListeVisiteurR : Form
    {
        bool erreur = false;
        public FListeVisiteurR()
        {
            InitializeComponent();

        }
        private void FListeVisiteurR_Load(object sender, EventArgs e)
        {
            cbListeRegion.ValueMember = "idRegion";
            cbListeRegion.DisplayMember = "libRegion";
            bsListeRegion.DataSource = Modele.listeRegion();
            cbListeRegion.DataSource = bsListeRegion;
        }
        private void BsListeRegion_CurrentChanged(object sender, EventArgs e)
        {
            if (erreur) return;
            i = Visiteur.Tolist();
            bsVisiteur.DataSource = ((Region)bsListeRegion.Current).Visiteur.ToList().OrderBy(x => x.nomVisiteur).ThenBy(x => x.prenomVisiteur);
            dgvListeVisiteur.DataSource = bsVisiteur;
            for (int i = 0; i < dgvListeVisiteur.ColumnCount; i++)
            {
                dgvListeVisiteur.Columns[i].Visible = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(Quitter));
            t.Start();
            this.Close();
        }
        public static void Quitter()
        {
            Application.Run(new FMenu());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OuvertureSecteur));
            t.Start();
            this.Close();
        }
        public static void OuvertureSecteur()
        {
            Application.Run(new FListeVisiteurS());
        }

        
    }
}
