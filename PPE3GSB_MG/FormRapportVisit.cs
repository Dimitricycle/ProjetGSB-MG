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
            bsMedecin.DataSource = Modele.listeMedecin();
            bsVisiteur.DataSource = Modele.listeVisiteur();
            bsInformationVisite.DataSource = Modele.listeRapport();

            //textBoxRapportVisit.Text = ((RAPPORT)bsVisiteur.Current).idRapport.ToString();
            //textBoxRapportVisit.Text = ((RAPPORT)bsVisiteur.Current).idRapport.ToString();
            comboBoxPraticien.DataSource = bsMedecin;
            comboBoxPraticien.ValueMember = "idMedecin";
            comboBoxPraticien.DisplayMember = "nom";
            textBoxDateRapport.Text = Convert.ToString(dateTimePickerRapport.Value.Date.ToString("dd/MM/yyyy"));
            
            
        }

        private void BsMedecin_CurrentChanged(object sender, EventArgs e)
        {
            if (close) return;

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

        }

        private void DateTimePickerRapport_ValueChanged(object sender, EventArgs e)
        {
          
            textBoxDateRapport.Text = Convert.ToString(dateTimePickerRapport.Value.Date.ToString("dd/MM/yyyy"));

        }


        private void ButtonClose_Click(object sender, EventArgs e)
        {
            FormRapportVisit.ActiveForm.Close();
        }

        private void ButtonDetail_Click(object sender, EventArgs e)
        {
            FormPraticien fp = new FormPraticien();
            fp.Show();
        }
    }
}
