namespace PPE3GSB_MG
{
    partial class FormRapportVisit
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTitleVisit = new System.Windows.Forms.Label();
            this.textBoxRapportVisit = new System.Windows.Forms.TextBox();
            this.labelNumRapport = new System.Windows.Forms.Label();
            this.labelPraticien = new System.Windows.Forms.Label();
            this.labelDateRapport = new System.Windows.Forms.Label();
            this.labelMotifVisite = new System.Windows.Forms.Label();
            this.labelBilan = new System.Windows.Forms.Label();
            this.comboBoxPraticien = new System.Windows.Forms.ComboBox();
            this.textBoxDateRapport = new System.Windows.Forms.TextBox();
            this.textBoxMotifVisit = new System.Windows.Forms.TextBox();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.dgvBilan = new System.Windows.Forms.DataGridView();
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.bsInformationVisite = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelEchantillon = new System.Windows.Forms.Label();
            this.dateTimePickerRapport = new System.Windows.Forms.DateTimePicker();
            this.bsMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInformationVisite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitleVisit
            // 
            this.labelTitleVisit.AutoSize = true;
            this.labelTitleVisit.Font = new System.Drawing.Font("Carlito", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleVisit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelTitleVisit.Location = new System.Drawing.Point(269, 9);
            this.labelTitleVisit.Name = "labelTitleVisit";
            this.labelTitleVisit.Size = new System.Drawing.Size(243, 33);
            this.labelTitleVisit.TabIndex = 0;
            this.labelTitleVisit.Text = "RAPPORTS DE VISITE";
            // 
            // textBoxRapportVisit
            // 
            this.textBoxRapportVisit.Enabled = false;
            this.textBoxRapportVisit.Location = new System.Drawing.Point(118, 73);
            this.textBoxRapportVisit.Name = "textBoxRapportVisit";
            this.textBoxRapportVisit.Size = new System.Drawing.Size(121, 20);
            this.textBoxRapportVisit.TabIndex = 1;
            // 
            // labelNumRapport
            // 
            this.labelNumRapport.AutoSize = true;
            this.labelNumRapport.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumRapport.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelNumRapport.Location = new System.Drawing.Point(12, 75);
            this.labelNumRapport.Name = "labelNumRapport";
            this.labelNumRapport.Size = new System.Drawing.Size(100, 15);
            this.labelNumRapport.TabIndex = 2;
            this.labelNumRapport.Text = "Numéro Rapport";
            // 
            // labelPraticien
            // 
            this.labelPraticien.AutoSize = true;
            this.labelPraticien.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPraticien.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelPraticien.Location = new System.Drawing.Point(12, 103);
            this.labelPraticien.Name = "labelPraticien";
            this.labelPraticien.Size = new System.Drawing.Size(55, 15);
            this.labelPraticien.TabIndex = 3;
            this.labelPraticien.Text = "Praticien";
            // 
            // labelDateRapport
            // 
            this.labelDateRapport.AutoSize = true;
            this.labelDateRapport.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateRapport.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelDateRapport.Location = new System.Drawing.Point(12, 130);
            this.labelDateRapport.Name = "labelDateRapport";
            this.labelDateRapport.Size = new System.Drawing.Size(80, 15);
            this.labelDateRapport.TabIndex = 4;
            this.labelDateRapport.Text = "Date Rapport";
            // 
            // labelMotifVisite
            // 
            this.labelMotifVisite.AutoSize = true;
            this.labelMotifVisite.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotifVisite.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelMotifVisite.Location = new System.Drawing.Point(12, 158);
            this.labelMotifVisite.Name = "labelMotifVisite";
            this.labelMotifVisite.Size = new System.Drawing.Size(71, 15);
            this.labelMotifVisite.TabIndex = 5;
            this.labelMotifVisite.Text = "Motif Visite";
            // 
            // labelBilan
            // 
            this.labelBilan.AutoSize = true;
            this.labelBilan.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBilan.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelBilan.Location = new System.Drawing.Point(12, 184);
            this.labelBilan.Name = "labelBilan";
            this.labelBilan.Size = new System.Drawing.Size(40, 15);
            this.labelBilan.TabIndex = 6;
            this.labelBilan.Text = "BILAN";
            // 
            // comboBoxPraticien
            // 
            this.comboBoxPraticien.FormattingEnabled = true;
            this.comboBoxPraticien.Location = new System.Drawing.Point(118, 100);
            this.comboBoxPraticien.Name = "comboBoxPraticien";
            this.comboBoxPraticien.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPraticien.TabIndex = 7;
            // 
            // textBoxDateRapport
            // 
            this.textBoxDateRapport.Location = new System.Drawing.Point(118, 129);
            this.textBoxDateRapport.Name = "textBoxDateRapport";
            this.textBoxDateRapport.Size = new System.Drawing.Size(121, 20);
            this.textBoxDateRapport.TabIndex = 8;
            // 
            // textBoxMotifVisit
            // 
            this.textBoxMotifVisit.Location = new System.Drawing.Point(118, 156);
            this.textBoxMotifVisit.Name = "textBoxMotifVisit";
            this.textBoxMotifVisit.Size = new System.Drawing.Size(121, 20);
            this.textBoxMotifVisit.TabIndex = 9;
            // 
            // buttonDetail
            // 
            this.buttonDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDetail.Location = new System.Drawing.Point(245, 99);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(47, 23);
            this.buttonDetail.TabIndex = 11;
            this.buttonDetail.Text = "Détails";
            this.buttonDetail.UseVisualStyleBackColor = true;
            // 
            // dgvBilan
            // 
            this.dgvBilan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBilan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilan.Location = new System.Drawing.Point(118, 184);
            this.dgvBilan.Name = "dgvBilan";
            this.dgvBilan.Size = new System.Drawing.Size(240, 150);
            this.dgvBilan.TabIndex = 12;
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.Location = new System.Drawing.Point(118, 354);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(75, 23);
            this.buttonPrecedent.TabIndex = 13;
            this.buttonPrecedent.Text = "Précédent";
            this.buttonPrecedent.UseVisualStyleBackColor = true;
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Location = new System.Drawing.Point(201, 354);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(75, 23);
            this.buttonSuivant.TabIndex = 14;
            this.buttonSuivant.Text = "Suivant";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(283, 354);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 15;
            this.buttonNew.Text = "Nouveau";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(703, 412);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(85, 26);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Text = "Fermer";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(420, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // labelEchantillon
            // 
            this.labelEchantillon.AutoSize = true;
            this.labelEchantillon.Location = new System.Drawing.Point(417, 163);
            this.labelEchantillon.Name = "labelEchantillon";
            this.labelEchantillon.Size = new System.Drawing.Size(97, 13);
            this.labelEchantillon.TabIndex = 18;
            this.labelEchantillon.Text = "Offre d\'échantillons";
            // 
            // dateTimePickerRapport
            // 
            this.dateTimePickerRapport.CustomFormat = "";
            this.dateTimePickerRapport.Location = new System.Drawing.Point(245, 129);
            this.dateTimePickerRapport.Name = "dateTimePickerRapport";
            this.dateTimePickerRapport.Size = new System.Drawing.Size(18, 20);
            this.dateTimePickerRapport.TabIndex = 20;
            this.dateTimePickerRapport.ValueChanged += new System.EventHandler(this.DateTimePickerRapport_ValueChanged);
            // 
            // bsMedecin
            // 
            this.bsMedecin.CurrentChanged += new System.EventHandler(this.BsMedecin_CurrentChanged);
            // 
            // FormRapportVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerRapport);
            this.Controls.Add(this.labelEchantillon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonPrecedent);
            this.Controls.Add(this.dgvBilan);
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.textBoxMotifVisit);
            this.Controls.Add(this.textBoxDateRapport);
            this.Controls.Add(this.comboBoxPraticien);
            this.Controls.Add(this.labelBilan);
            this.Controls.Add(this.labelMotifVisite);
            this.Controls.Add(this.labelDateRapport);
            this.Controls.Add(this.labelPraticien);
            this.Controls.Add(this.labelNumRapport);
            this.Controls.Add(this.textBoxRapportVisit);
            this.Controls.Add(this.labelTitleVisit);
            this.Name = "FormRapportVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormRapportVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInformationVisite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleVisit;
        private System.Windows.Forms.TextBox textBoxRapportVisit;
        private System.Windows.Forms.Label labelNumRapport;
        private System.Windows.Forms.Label labelPraticien;
        private System.Windows.Forms.Label labelDateRapport;
        private System.Windows.Forms.Label labelMotifVisite;
        private System.Windows.Forms.Label labelBilan;
        private System.Windows.Forms.ComboBox comboBoxPraticien;
        private System.Windows.Forms.TextBox textBoxDateRapport;
        private System.Windows.Forms.TextBox textBoxMotifVisit;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.DataGridView dgvBilan;
        private System.Windows.Forms.Button buttonPrecedent;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.BindingSource bsInformationVisite;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelEchantillon;
        private System.Windows.Forms.DateTimePicker dateTimePickerRapport;
        private System.Windows.Forms.BindingSource bsMedecin;
        private System.Windows.Forms.BindingSource bsVisiteur;
    }
}