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
            this.Budget = new System.Windows.Forms.Button();
            this.LVisiteur = new System.Windows.Forms.Button();
            this.RVisite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Information
            // 
            this.Information.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Information.Location = new System.Drawing.Point(322, 146);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(122, 23);
            this.Information.TabIndex = 0;
            this.Information.Text = "Information";
            this.Information.UseVisualStyleBackColor = true;
            this.Information.Click += new System.EventHandler(this.Information_Click);
            // 
            // Responsable
            // 
            this.Responsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Responsable.Location = new System.Drawing.Point(322, 175);
            this.Responsable.Name = "Responsable";
            this.Responsable.Size = new System.Drawing.Size(122, 23);
            this.Responsable.TabIndex = 2;
            this.Responsable.Text = "Resposabilités";
            this.Responsable.UseVisualStyleBackColor = true;
            this.Responsable.Click += new System.EventHandler(this.Responsable_Click);
            // 
            // Budget
            // 
            this.Budget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Budget.Location = new System.Drawing.Point(322, 204);
            this.Budget.Name = "Budget";
            this.Budget.Size = new System.Drawing.Size(122, 23);
            this.Budget.TabIndex = 4;
            this.Budget.Text = "Budgets";
            this.Budget.UseVisualStyleBackColor = true;
            // 
            // LVisiteur
            // 
            this.LVisiteur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LVisiteur.Location = new System.Drawing.Point(322, 233);
            this.LVisiteur.Name = "LVisiteur";
            this.LVisiteur.Size = new System.Drawing.Size(122, 23);
            this.LVisiteur.TabIndex = 5;
            this.LVisiteur.Text = "Liste des visiteurs";
            this.LVisiteur.UseVisualStyleBackColor = true;
            this.LVisiteur.Click += new System.EventHandler(this.LVisiteur_Click);
            // 
            // RVisite
            // 
            this.RVisite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RVisite.Location = new System.Drawing.Point(322, 262);
            this.RVisite.Name = "RVisite";
            this.RVisite.Size = new System.Drawing.Size(122, 23);
            this.RVisite.TabIndex = 7;
            this.RVisite.Text = "Rapport visite";
            this.RVisite.UseVisualStyleBackColor = true;
            this.RVisite.Click += new System.EventHandler(this.RVisite_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bonjour Dandre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(704, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Quiter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RVisite);
            this.Controls.Add(this.LVisiteur);
            this.Controls.Add(this.Budget);
            this.Controls.Add(this.Responsable);
            this.Controls.Add(this.Information);
            this.Name = "FMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMenu";
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Information;
        private System.Windows.Forms.Button Responsable;
        private System.Windows.Forms.Button Budget;
        private System.Windows.Forms.Button LVisiteur;
        private System.Windows.Forms.Button RVisite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}