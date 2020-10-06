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
            label1.Text = Modele.Affiche();
        }

        private void RVisite_Click(object sender, EventArgs e)
        {
            //FVILLE ouverture = new FVILLE();
            //ouverture.Show();
        }
    }
}
