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
    public partial class FHierarchique : Form
    {
        public FHierarchique()
        {
            InitializeComponent();
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
    }
}
