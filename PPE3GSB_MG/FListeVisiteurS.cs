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
        public FListeVisiteurS()
        {
            InitializeComponent();
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
