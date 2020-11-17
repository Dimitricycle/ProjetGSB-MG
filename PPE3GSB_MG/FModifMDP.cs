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
    public partial class FModifMDP : Form
    {
        public FModifMDP()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            if (Modele.EnregistreMDP(textBox1.Text, textBox2.Text))
            {
                label4.Text = "Information enregistrées";
            }
            else
            {
                label4.Text = "Erreur enregistrement";
            }
            
        }
    }
}
