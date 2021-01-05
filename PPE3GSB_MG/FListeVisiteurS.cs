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
    public partial class FListeVisiteurS : Form
    {
        bool erreur = false;
        public FListeVisiteurS()
        {
            InitializeComponent();
        }
        private void FListeVisiteurS_Load(object sender, EventArgs e)
        {
            cbListeSecteur.ValueMember = "idSecteur";
            cbListeSecteur.DisplayMember = "libSecteur";
            bsListeSecteur.DataSource = Modele.listeSecteur();
            cbListeSecteur.DataSource = bsListeSecteur;
        }
        private void BsListeSecteur_CurrentChanged(object sender, EventArgs e)
        {
            if (erreur) return;
            /*
            List<Region> RegionS = new List<Region>();
            RegionS = ((Secteur)bsListeSecteur.Current).Region.ToList();
            bsRegion.DataSource = RegionS;
            for (int i = 0; i < RegionS.Count; i++)
            {

                bsVisiteur.DataSource = ((Region)bsRegion.Current).Visiteur1.ToList().OrderBy(x => x.nom).ThenBy(x => x.prenom);
                dgvListeVisiteur.DataSource = bsVisiteur;
                for (int x = 0; x < dgvListeVisiteur.ColumnCount; x++)
                {
                    dgvListeVisiteur.Columns[x].Visible = false;
                }
            }
            dgvListeVisiteur.Columns["idVisiteur"].Visible = true;
            dgvListeVisiteur.Columns["idVisiteur"].HeaderText = "Identifiant";
            dgvListeVisiteur.Columns["idVisiteur"].DisplayIndex = 0;
            dgvListeVisiteur.Columns["nom"].Visible = true;
            dgvListeVisiteur.Columns["nom"].HeaderText = "Nom";
            dgvListeVisiteur.Columns["nom"].DisplayIndex = 0;
            dgvListeVisiteur.Columns["prenom"].Visible = true;
            dgvListeVisiteur.Columns["prenom"].HeaderText = "Prenom";
            dgvListeVisiteur.Columns["prenom"].DisplayIndex = 0;
            */
            textBox1.Text = ((Secteur)bsListeSecteur.Current).Visiteur.idVisiteur;
            textBox2.Text = ((Secteur)bsListeSecteur.Current).Visiteur.nom;
            textBox3.Text = ((Secteur)bsListeSecteur.Current).Visiteur.prenom;
        }
















        private void Button3_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OuvertureRegion));
            t.Start();
            this.Close();
        }
        public static void OuvertureRegion()
        {
            Application.Run(new FListeVisiteurR());
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
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OuvertureHierar));
            t.Start();
            this.Close();
        }
        public static void OuvertureHierar()
        {
            Application.Run(new FHierarchique());
        }

        
    }
}
