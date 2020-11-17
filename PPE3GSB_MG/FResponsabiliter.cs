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
            bsRegion.DataSource = ((Visiteur)bsGlobal.Current).Region.ToList();
            dgvRegion.DataSource = bsRegion;
            for (int i = 0; i < dgvRegion.ColumnCount; i++)
            {
                dgvRegion.Columns[i].Visible = false;
            }
            dgvRegion.Columns["libRegion"].Visible = true;
            dgvRegion.Columns["libRegion"].HeaderText = "Region";
            dgvRegion.Columns["libRegion"].DisplayIndex = 0;
            dgvRegion.Columns["idRegion"].Visible = true;
            dgvRegion.Columns["idRegion"].HeaderText = "Numero";
            dgvRegion.Columns["idRegion"].DisplayIndex = 0;

            bsSecteur.DataSource = ((Visiteur)bsGlobal.Current).Secteur.ToList();
            dgvSecteur.DataSource = bsSecteur;
            for (int i = 0; i < dgvSecteur.ColumnCount; i++)
            {
                dgvRegion.Columns[i].Visible = false;
            }
            dgvSecteur.Columns["idSecteur"].Visible = true;
            dgvSecteur.Columns["idSecteur"].HeaderText = "Numero";
            dgvSecteur.Columns["idSecteur"].DisplayIndex = 0;
            dgvSecteur.Columns["libSecteur"].Visible = true;
            dgvSecteur.Columns["libSecteur"].HeaderText = "Region";
            dgvSecteur.Columns["libSecteur"].DisplayIndex = 0;
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
