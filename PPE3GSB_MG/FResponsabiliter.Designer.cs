namespace PPE3GSB_MG
{
    partial class FResponsabiliter
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bsGlobal = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSouR = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bsDGV = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsGlobal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSouR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voici vos responssabilitées";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bsGlobal
            // 
            this.bsGlobal.CurrentChanged += new System.EventHandler(this.BsGlobal_CurrentChanged);
            // 
            // dgvSouR
            // 
            this.dgvSouR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSouR.Location = new System.Drawing.Point(172, 128);
            this.dgvSouR.Name = "dgvSouR";
            this.dgvSouR.Size = new System.Drawing.Size(445, 223);
            this.dgvSouR.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // FResponsabiliter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSouR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FResponsabiliter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FResponsabiliter";
            this.Load += new System.EventHandler(this.FResponsabiliter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsGlobal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSouR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bsGlobal;
        private System.Windows.Forms.DataGridView dgvSouR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsDGV;
    }
}