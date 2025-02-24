namespace MediaTek86
{
    partial class GestionPersonnel
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
            this.dataGridPersonnels = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnVoirAbsences = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonnels)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridPersonnels
            // 
            this.dataGridPersonnels.AllowUserToOrderColumns = true;
            this.dataGridPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonnels.Location = new System.Drawing.Point(12, 22);
            this.dataGridPersonnels.Name = "dataGridPersonnels";
            this.dataGridPersonnels.Size = new System.Drawing.Size(776, 430);
            this.dataGridPersonnels.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnVoirAbsences);
            this.groupBox1.Controls.Add(this.BtnSupprimer);
            this.groupBox1.Controls.Add(this.BtnModifier);
            this.groupBox1.Controls.Add(this.BtnAjouter);
            this.groupBox1.Location = new System.Drawing.Point(13, 471);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gérer le personnel";
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(25, 25);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(94, 35);
            this.BtnAjouter.TabIndex = 0;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            // 
            // BtnModifier
            // 
            this.BtnModifier.Location = new System.Drawing.Point(231, 25);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(95, 34);
            this.BtnModifier.TabIndex = 1;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Location = new System.Drawing.Point(432, 25);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(95, 34);
            this.BtnSupprimer.TabIndex = 2;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            // 
            // BtnVoirAbsences
            // 
            this.BtnVoirAbsences.Location = new System.Drawing.Point(643, 25);
            this.BtnVoirAbsences.Name = "BtnVoirAbsences";
            this.BtnVoirAbsences.Size = new System.Drawing.Size(95, 34);
            this.BtnVoirAbsences.TabIndex = 3;
            this.BtnVoirAbsences.Text = "Absences";
            this.BtnVoirAbsences.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridPersonnels);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "MediaTek86";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonnels)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPersonnels;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnVoirAbsences;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnAjouter;
    }
}

