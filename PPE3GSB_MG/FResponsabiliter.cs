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
    public partial class FResponsabiliter : Form
    {
        public FResponsabiliter()
        {
            InitializeComponent();
        }

        private void FResponsabiliter_Load(object sender, EventArgs e)
        {
            bsGlobal.DataSource = Modele.GetAffiche();
        }

        private void BsGlobal_CurrentChanged(object sender, EventArgs e)
        {
            bool dgv = false;
            foreach(Region r in Modele.listeRegion())
            {
                if(r.idVisiteur== ((Visiteur)bsGlobal.Current).idVisiteur.ToString())
                {
                    dgv = true;
                }
            }

            if (dgv)
            {
                label2.Text = "Vos Regions :";
                bsDGV.DataSource = (((Visiteur)bsGlobal.Current).Region.ToList());
                dgvSouR.DataSource = bsDGV;
                for (int i = 0; i < dgvSouR.ColumnCount; i++)
                {
                    dgvSouR.Columns[i].Visible = false;
                }
                dgvSouR.Columns["idRegion"].Visible = true;
                dgvSouR.Columns["idRegion"].HeaderText = "Numero";
                dgvSouR.Columns["idRegion"].DisplayIndex = 0;
                dgvSouR.Columns["libRegion"].Visible = true;
                dgvSouR.Columns["libRegion"].HeaderText = "Region";
                dgvSouR.Columns["libRegion"].DisplayIndex = 0;
            }
            else
            {
                label2.Text = "Vos Secteurs :";
                bsDGV.DataSource = ((Visiteur)bsGlobal.Current).Secteur.ToList();
                dgvSouR.DataSource = bsDGV;
                for (int i = 0; i < dgvSouR.ColumnCount; i++)
                {
                    dgvSouR.Columns[i].Visible = false;
                }
                dgvSouR.Columns["idSecteur"].Visible = true;
                dgvSouR.Columns["idSecteur"].HeaderText = "Numero";
                dgvSouR.Columns["idSecteur"].DisplayIndex = 0;
                dgvSouR.Columns["libSecteur"].Visible = true;
                dgvSouR.Columns["libSecteur"].HeaderText = "Secteur";
                dgvSouR.Columns["libSecteur"].DisplayIndex = 0;
            }
        }




        private void Button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OuvertureMenu));
            t.Start();
            this.Close();
        }
        public static void OuvertureMenu()
        {
            Application.Run(new FMenu());
        }

        
    }
    
}
