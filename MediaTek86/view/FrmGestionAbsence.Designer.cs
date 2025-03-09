namespace MediaTek86.view
{
    partial class FrmGestionAbsence
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GridViewAbsences = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CloseFrmGestAbs = new System.Windows.Forms.Button();
            this.BtnAbsModif = new System.Windows.Forms.Button();
            this.BtnAddAbsence = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbIdPersonnel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSupprAbsence = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAbsences)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GridViewAbsences);
            this.groupBox4.Location = new System.Drawing.Point(12, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(550, 509);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Absences";
            // 
            // GridViewAbsences
            // 
            this.GridViewAbsences.AllowUserToAddRows = false;
            this.GridViewAbsences.AllowUserToDeleteRows = false;
            this.GridViewAbsences.AllowUserToOrderColumns = true;
            this.GridViewAbsences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewAbsences.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridViewAbsences.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GridViewAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewAbsences.GridColor = System.Drawing.SystemColors.Window;
            this.GridViewAbsences.Location = new System.Drawing.Point(6, 19);
            this.GridViewAbsences.MultiSelect = false;
            this.GridViewAbsences.Name = "GridViewAbsences";
            this.GridViewAbsences.ReadOnly = true;
            this.GridViewAbsences.RowHeadersVisible = false;
            this.GridViewAbsences.RowTemplate.ReadOnly = true;
            this.GridViewAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewAbsences.ShowEditingIcon = false;
            this.GridViewAbsences.Size = new System.Drawing.Size(538, 484);
            this.GridViewAbsences.TabIndex = 0;
            this.GridViewAbsences.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSupprAbsence);
            this.groupBox1.Controls.Add(this.CloseFrmGestAbs);
            this.groupBox1.Controls.Add(this.BtnAbsModif);
            this.groupBox1.Controls.Add(this.BtnAddAbsence);
            this.groupBox1.Location = new System.Drawing.Point(18, 596);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 53);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion des absences";
            // 
            // CloseFrmGestAbs
            // 
            this.CloseFrmGestAbs.Location = new System.Drawing.Point(420, 24);
            this.CloseFrmGestAbs.Name = "CloseFrmGestAbs";
            this.CloseFrmGestAbs.Size = new System.Drawing.Size(103, 23);
            this.CloseFrmGestAbs.TabIndex = 3;
            this.CloseFrmGestAbs.Text = "Fermer";
            this.CloseFrmGestAbs.UseVisualStyleBackColor = true;
            this.CloseFrmGestAbs.Click += new System.EventHandler(this.CloseFrmGestAbs_Click);
            // 
            // BtnAbsModif
            // 
            this.BtnAbsModif.Location = new System.Drawing.Point(288, 24);
            this.BtnAbsModif.Name = "BtnAbsModif";
            this.BtnAbsModif.Size = new System.Drawing.Size(103, 23);
            this.BtnAbsModif.TabIndex = 2;
            this.BtnAbsModif.Text = "Modifier";
            this.BtnAbsModif.UseVisualStyleBackColor = true;
            this.BtnAbsModif.Click += new System.EventHandler(this.BtnAbsModif_Click);
            // 
            // BtnAddAbsence
            // 
            this.BtnAddAbsence.Location = new System.Drawing.Point(8, 24);
            this.BtnAddAbsence.Name = "BtnAddAbsence";
            this.BtnAddAbsence.Size = new System.Drawing.Size(103, 23);
            this.BtnAddAbsence.TabIndex = 0;
            this.BtnAddAbsence.Text = "Ajouter";
            this.BtnAddAbsence.UseVisualStyleBackColor = true;
            this.BtnAddAbsence.Click += new System.EventHandler(this.BtnAddAbsence_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbIdPersonnel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 59);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personnel";
            // 
            // lbIdPersonnel
            // 
            this.lbIdPersonnel.AutoSize = true;
            this.lbIdPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdPersonnel.Location = new System.Drawing.Point(72, 28);
            this.lbIdPersonnel.Name = "lbIdPersonnel";
            this.lbIdPersonnel.Size = new System.Drawing.Size(136, 13);
            this.lbIdPersonnel.TabIndex = 67;
            this.lbIdPersonnel.Text = "NOM Prénom (Service)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Identité :";
            // 
            // BtnSupprAbsence
            // 
            this.BtnSupprAbsence.Location = new System.Drawing.Point(148, 24);
            this.BtnSupprAbsence.Name = "BtnSupprAbsence";
            this.BtnSupprAbsence.Size = new System.Drawing.Size(103, 23);
            this.BtnSupprAbsence.TabIndex = 4;
            this.BtnSupprAbsence.Text = "Supprimer";
            this.BtnSupprAbsence.UseVisualStyleBackColor = true;
            this.BtnSupprAbsence.Click += new System.EventHandler(this.BtnSupprAbsence_Click);
            // 
            // FrmGestionAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 662);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(588, 701);
            this.MinimumSize = new System.Drawing.Size(588, 701);
            this.Name = "FrmGestionAbsence";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire des absences";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAbsences)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView GridViewAbsences;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAbsModif;
        private System.Windows.Forms.Button BtnAddAbsence;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIdPersonnel;
        private System.Windows.Forms.Button CloseFrmGestAbs;
        private System.Windows.Forms.Button BtnSupprAbsence;
    }
}