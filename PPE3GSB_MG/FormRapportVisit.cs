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
    public partial class FormRapportVisit : Form
    {
        private bool close = false;
        public FormRapportVisit()
        {
            InitializeComponent();
        }

        private void FormRapportVisit_Load(object sender, EventArgs e)
        {
            comboBoxPraticien.ValueMember = "idVisiteur";
            comboBoxPraticien.DisplayMember = "prenom";
            bsVisiteur.DataSource = Modele.listeVisiteur();
            bsInformationVisite.DataSource = Modele.listeRapport();
            comboBoxPraticien.DataSource = bsVisiteur;
        }

        private void BsVisiteur_CurrentChanged(object sender, EventArgs e)
        {
            if (close) return;

            bsInformationVisite.DataSource = ((Visiteur)bsVisiteur.Current).RAPPORT.ToList().OrderBy(x => x.bilan);
            dgvBilan.DataSource = bsInformationVisite;

            for (int i = 0; i < dgvBilan.ColumnCount; i++)
            {
                dgvBilan.Columns[i].Visible = false;
            }
           
            dgvBilan.Columns["bilan"].Visible = true;
            dgvBilan.Columns["bilan"].HeaderText = "Bilan";
            dgvBilan.Columns["bilan"].DisplayIndex = 0;

            textBoxDateRapport.Text = ((RAPPORT)bsInformationVisite.Current).dateRapport.ToString();

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            FormRapportVisit.ActiveForm.Close();
        }
    }
}
