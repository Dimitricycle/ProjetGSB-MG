namespace PPE3GSB_MG
{
    partial class FormPraticien
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
            this.labelTitleVisit = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelLieuExercice = new System.Windows.Forms.Label();
            this.labelCoNotoriete = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.comboBoxLieuExo = new System.Windows.Forms.ComboBox();
            this.buttonValide = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitleVisit
            // 
            this.labelTitleVisit.AutoSize = true;
            this.labelTitleVisit.Font = new System.Drawing.Font("Carlito", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleVisit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelTitleVisit.Location = new System.Drawing.Point(299, 9);
            this.labelTitleVisit.Name = "labelTitleVisit";
            this.labelTitleVisit.Size = new System.Drawing.Size(143, 33);
            this.labelTitleVisit.TabIndex = 1;
            this.labelTitleVisit.Text = "PRATICIENS";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelSearch.Location = new System.Drawing.Point(33, 96);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(69, 15);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Rechercher";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelNom.Location = new System.Drawing.Point(32, 188);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(36, 15);
            this.labelNom.TabIndex = 4;
            this.labelNom.Text = "NOM";
            // 
            // labelLieuExercice
            // 
            this.labelLieuExercice.AutoSize = true;
            this.labelLieuExercice.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLieuExercice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelLieuExercice.Location = new System.Drawing.Point(33, 347);
            this.labelLieuExercice.Name = "labelLieuExercice";
            this.labelLieuExercice.Size = new System.Drawing.Size(93, 15);
            this.labelLieuExercice.TabIndex = 5;
            this.labelLieuExercice.Text = "LIEU D\'EXERCICE";
            // 
            // labelCoNotoriete
            // 
            this.labelCoNotoriete.AutoSize = true;
            this.labelCoNotoriete.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoNotoriete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelCoNotoriete.Location = new System.Drawing.Point(33, 316);
            this.labelCoNotoriete.Name = "labelCoNotoriete";
            this.labelCoNotoriete.Size = new System.Drawing.Size(107, 15);
            this.labelCoNotoriete.TabIndex = 6;
            this.labelCoNotoriete.Text = "COEFF. NOTORIETE";
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVille.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelVille.Location = new System.Drawing.Point(32, 285);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(36, 15);
            this.labelVille.TabIndex = 7;
            this.labelVille.Text = "VILLE";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresse.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelAdresse.Location = new System.Drawing.Point(32, 253);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(54, 15);
            this.labelAdresse.TabIndex = 8;
            this.labelAdresse.Text = "ADRESSE";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelPrenom.Location = new System.Drawing.Point(32, 221);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(56, 15);
            this.labelPrenom.TabIndex = 9;
            this.labelPrenom.Text = "PRÉNOM";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelNum.Location = new System.Drawing.Point(32, 158);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(57, 15);
            this.labelNum.TabIndex = 10;
            this.labelNum.Text = "NUMÉRO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(173, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(173, 219);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(188, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(173, 251);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(188, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(173, 283);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(51, 20);
            this.textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(230, 283);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(131, 20);
            this.textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(173, 314);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(188, 20);
            this.textBox8.TabIndex = 18;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(173, 96);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(188, 21);
            this.comboBoxSearch.TabIndex = 19;
            // 
            // comboBoxLieuExo
            // 
            this.comboBoxLieuExo.FormattingEnabled = true;
            this.comboBoxLieuExo.Location = new System.Drawing.Point(173, 347);
            this.comboBoxLieuExo.Name = "comboBoxLieuExo";
            this.comboBoxLieuExo.Size = new System.Drawing.Size(188, 21);
            this.comboBoxLieuExo.TabIndex = 20;
            // 
            // buttonValide
            // 
            this.buttonValide.Location = new System.Drawing.Point(367, 95);
            this.buttonValide.Name = "buttonValide";
            this.buttonValide.Size = new System.Drawing.Size(45, 23);
            this.buttonValide.TabIndex = 22;
            this.buttonValide.Text = "Validé";
            this.buttonValide.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(688, 400);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonClose.Size = new System.Drawing.Size(89, 36);
            this.buttonClose.TabIndex = 25;
            this.buttonClose.Text = "Fermer";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Location = new System.Drawing.Point(256, 400);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(75, 23);
            this.buttonSuivant.TabIndex = 24;
            this.buttonSuivant.Text = "Suivant";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.Location = new System.Drawing.Point(173, 400);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(75, 23);
            this.buttonPrecedent.TabIndex = 23;
            this.buttonPrecedent.Text = "Précédent";
            this.buttonPrecedent.UseVisualStyleBackColor = true;
            // 
            // FormPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonPrecedent);
            this.Controls.Add(this.buttonValide);
            this.Controls.Add(this.comboBoxLieuExo);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.labelCoNotoriete);
            this.Controls.Add(this.labelLieuExercice);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelTitleVisit);
            this.Name = "FormPraticien";
            this.Text = "FormPraticien";
            this.Load += new System.EventHandler(this.FormPraticien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleVisit;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelLieuExercice;
        private System.Windows.Forms.Label labelCoNotoriete;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxLieuExo;
        private System.Windows.Forms.Button buttonValide;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button buttonPrecedent;
    }
}