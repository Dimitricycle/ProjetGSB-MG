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
    public partial class FormPraticien : Form
    {
        public FormPraticien()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            FormRapportVisit.ActiveForm.Close();
        }

        private void FormPraticien_Load(object sender, EventArgs e)
        {
            //comboBoxSearch.DataSource = bsMedecin;
        }
    }
}
