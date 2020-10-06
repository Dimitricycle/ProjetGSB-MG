namespace PPE3GSB_MG
{
    partial class FMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Information = new System.Windows.Forms.Button();
            this.Responsable = new System.Windows.Forms.Button();
            this.MDP = new System.Windows.Forms.Button();
            this.Budget = new System.Windows.Forms.Button();
            this.LVisiteur = new System.Windows.Forms.Button();
            this.RVisite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(276, 145);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(122, 23);
            this.Information.TabIndex = 0;
            this.Information.Text = "Information";
            this.Information.UseVisualStyleBackColor = true;
            // 
            // Responsable
            // 
            this.Responsable.Location = new System.Drawing.Point(276, 174);
            this.Responsable.Name = "Responsable";
            this.Responsable.Size = new System.Drawing.Size(122, 23);
            this.Responsable.TabIndex = 2;
            this.Responsable.Text = "Resposabilités";
            this.Responsable.UseVisualStyleBackColor = true;
            // 
            // MDP
            // 
            this.MDP.Location = new System.Drawing.Point(276, 203);
            this.MDP.Name = "MDP";
            this.MDP.Size = new System.Drawing.Size(122, 23);
            this.MDP.TabIndex = 3;
            this.MDP.Text = "Mot de passe";
            this.MDP.UseVisualStyleBackColor = true;
            // 
            // Budget
            // 
            this.Budget.Location = new System.Drawing.Point(276, 232);
            this.Budget.Name = "Budget";
            this.Budget.Size = new System.Drawing.Size(122, 23);
            this.Budget.TabIndex = 4;
            this.Budget.Text = "Budgets";
            this.Budget.UseVisualStyleBackColor = true;
            // 
            // LVisiteur
            // 
            this.LVisiteur.Location = new System.Drawing.Point(276, 261);
            this.LVisiteur.Name = "LVisiteur";
            this.LVisiteur.Size = new System.Drawing.Size(122, 23);
            this.LVisiteur.TabIndex = 5;
            this.LVisiteur.Text = "Liste des visiteurs";
            this.LVisiteur.UseVisualStyleBackColor = true;
            // 
            // RVisite
            // 
            this.RVisite.Location = new System.Drawing.Point(276, 290);
            this.RVisite.Name = "RVisite";
            this.RVisite.Size = new System.Drawing.Size(122, 23);
            this.RVisite.TabIndex = 7;
            this.RVisite.Text = "Rapport visite";
            this.RVisite.UseVisualStyleBackColor = true;
            this.RVisite.Click += new System.EventHandler(this.RVisite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RVisite);
            this.Controls.Add(this.LVisiteur);
            this.Controls.Add(this.Budget);
            this.Controls.Add(this.MDP);
            this.Controls.Add(this.Responsable);
            this.Controls.Add(this.Information);
            this.Name = "FMenu";
            this.Text = "FMenu";
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Information;
        private System.Windows.Forms.Button Responsable;
        private System.Windows.Forms.Button MDP;
        private System.Windows.Forms.Button Budget;
        private System.Windows.Forms.Button LVisiteur;
        private System.Windows.Forms.Button RVisite;
        private System.Windows.Forms.Label label1;
    }
}