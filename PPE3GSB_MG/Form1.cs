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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Modele.Connexion(idPersonne.Text, mdpPersonne.Text);
            if(Modele.ValidationConnexion())
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                t.Start();
                this.Close();
            }
        }

        public static void ThreadProc()
        {
            Application.Run(new FMenu());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            idPersonne.Text = "dandre";
            mdpPersonne.Text = "oppg5";
        }
    }
}
