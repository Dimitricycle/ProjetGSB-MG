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
    public partial class FInformation : Form
    {
        public FInformation()
        {
            InitializeComponent();
        }

        private void FInformation_Load(object sender, EventArgs e)
        {
            BsVisiteur.DataSource = Modele.listeVisiteur().Where(x => x.identifiant == Modele.Affiche());
        }

        private void BsVisiteur_CurrentChanged(object sender, EventArgs e)
        {
            textBox1.Text = ((Visiteur)BsVisiteur.Current).nom.ToString();
            textBox2.Text = ((Visiteur)BsVisiteur.Current).prenom.ToString();
            textBox3.Text = ((Visiteur)BsVisiteur.Current).rue.ToString();
            textBox4.Text = ((Visiteur)BsVisiteur.Current).cp.ToString();
            textBox5.Text = ((Visiteur)BsVisiteur.Current).ville.ToString();
            textBox6.Text = ((Visiteur)BsVisiteur.Current).identifiant.ToString();
        }
    }
}
