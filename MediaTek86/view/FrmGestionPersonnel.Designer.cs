using System.Windows.Forms;

namespace MediaTek86
{
    partial class FrmGestionPersonnel
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
            this.BtnPersSupprimer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnShowAbsences = new System.Windows.Forms.Button();
            this.ModPersonnel = new System.Windows.Forms.Button();
            this.BtnAddPersonnel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonnels)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridPersonnels
            // 
            this.dataGridPersonnels.AllowUserToAddRows = false;
            this.dataGridPersonnels.AllowUserToDeleteRows = false;
            this.dataGridPersonnels.AllowUserToOrderColumns = true;
            this.dataGridPersonnels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPersonnels.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridPersonnels.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonnels.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridPersonnels.Location = new System.Drawing.Point(15, 19);
            this.dataGridPersonnels.MultiSelect = false;
            this.dataGridPersonnels.Name = "dataGridPersonnels";
            this.dataGridPersonnels.ReadOnly = true;
            this.dataGridPersonnels.RowHeadersVisible = false;
            this.dataGridPersonnels.RowTemplate.ReadOnly = true;
            this.dataGridPersonnels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPersonnels.ShowEditingIcon = false;
            this.dataGridPersonnels.Size = new System.Drawing.Size(509, 561);
            this.dataGridPersonnels.TabIndex = 0;
            this.dataGridPersonnels.TabStop = false;
            // 
            // BtnPersSupprimer
            // 
            this.BtnPersSupprimer.Location = new System.Drawing.Point(257, 23);
            this.BtnPersSupprimer.Name = "BtnPersSupprimer";
            this.BtnPersSupprimer.Size = new System.Drawing.Size(117, 23);
            this.BtnPersSupprimer.TabIndex = 3;
            this.BtnPersSupprimer.Text = "Supprimer";
            this.BtnPersSupprimer.UseVisualStyleBackColor = true;
            this.BtnPersSupprimer.Click += new System.EventHandler(this.BtnPersSupprimer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridPersonnels);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 586);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des personnels";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnShowAbsences);
            this.groupBox3.Controls.Add(this.ModPersonnel);
            this.groupBox3.Controls.Add(this.BtnAddPersonnel);
            this.groupBox3.Controls.Add(this.BtnPersSupprimer);
            this.groupBox3.Location = new System.Drawing.Point(12, 604);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 57);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gestion du personnel";
            // 
            // BtnShowAbsences
            // 
            this.BtnShowAbsences.Location = new System.Drawing.Point(392, 23);
            this.BtnShowAbsences.Name = "BtnShowAbsences";
            this.BtnShowAbsences.Size = new System.Drawing.Size(117, 23);
            this.BtnShowAbsences.TabIndex = 4;
            this.BtnShowAbsences.Text = "Absences";
            this.BtnShowAbsences.UseVisualStyleBackColor = true;
            this.BtnShowAbsences.Click += new System.EventHandler(this.BtnShowAbsences_Click);
            // 
            // ModPersonnel
            // 
            this.ModPersonnel.Location = new System.Drawing.Point(129, 23);
            this.ModPersonnel.Name = "ModPersonnel";
            this.ModPersonnel.Size = new System.Drawing.Size(110, 23);
            this.ModPersonnel.TabIndex = 2;
            this.ModPersonnel.Text = "Modifier";
            this.ModPersonnel.UseVisualStyleBackColor = true;
            this.ModPersonnel.Click += new System.EventHandler(this.ModPersonnel_Click);
            // 
            // BtnAddPersonnel
            // 
            this.BtnAddPersonnel.Location = new System.Drawing.Point(6, 23);
            this.BtnAddPersonnel.Name = "BtnAddPersonnel";
            this.BtnAddPersonnel.Size = new System.Drawing.Size(107, 23);
            this.BtnAddPersonnel.TabIndex = 1;
            this.BtnAddPersonnel.Text = "Ajouter";
            this.BtnAddPersonnel.UseVisualStyleBackColor = true;
            this.BtnAddPersonnel.Click += new System.EventHandler(this.BtnAddPersonnel_Click);
            // 
            // FrmGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 678);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(568, 718);
            this.MinimumSize = new System.Drawing.Size(568, 718);
            this.Name = "FrmGestionPersonnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire des personnels";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonnels)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPersonnels;
        private System.Windows.Forms.Button BtnPersSupprimer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Button BtnAddPersonnel;
        private Button ModPersonnel;
        private Button BtnShowAbsences;
    }
}

