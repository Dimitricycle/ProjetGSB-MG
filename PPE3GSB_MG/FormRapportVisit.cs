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
            comboBoxPraticien.ValueMember = "idMedecin";
            comboBoxPraticien.DisplayMember = "prenom";
            textBoxDateRapport.Text = Convert.ToString(dateTimePickerRapport.Value.Date.ToString("dd/MM/yyyy"));
            bsMedecin.DataSource = Modele.listeMedecin();
            bsVisiteur.DataSource = Modele.listeVisiteur();
            bsInformationVisite.DataSource = Modele.listeRapport();
            comboBoxPraticien.DataSource = bsMedecin;
        }

        private void BsMedecin_CurrentChanged(object sender, EventArgs e)
        {
            //if (close) return;

           
            bsInformationVisite.DataSource = ((MEDECIN)bsMedecin.Current).RAPPORT.ToList();
            dgvBilan.DataSource = bsInformationVisite;

            for (int i = 0; i < dgvBilan.ColumnCount; i++)
            {
                dgvBilan.Columns[i].Visible = false;
            }

            dgvBilan.Columns["bilan"].Visible = true;
            dgvBilan.Columns["bilan"].HeaderText = "Bilan";
            dgvBilan.Columns["bilan"].DisplayIndex = 0;
            dgvBilan.Columns["dateRapport"].Visible = true;
            dgvBilan.Columns["dateRapport"].HeaderText = "Date";
            dgvBilan.Columns["dateRapport"].DisplayIndex = 1;

            textBoxRapportVisit.Text = ((RAPPORT)bsInformationVisite.Current).idRapport.ToString();
        }

        private void DateTimePickerRapport_ValueChanged(object sender, EventArgs e)
        {
          
            textBoxDateRapport.Text = Convert.ToString(dateTimePickerRapport.Value.Date.ToString("dd/MM/yyyy"));

        }


        private void ButtonClose_Click(object sender, EventArgs e)
        {
            FormRapportVisit.ActiveForm.Close();
        }

    }
}
