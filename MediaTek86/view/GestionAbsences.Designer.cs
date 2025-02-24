namespace MediaTek86.view
{
    partial class GestionAbsences
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxNomPersAbs = new System.Windows.Forms.TextBox();
            this.TxtBoxPrenomPersAbs = new System.Windows.Forms.TextBox();
            this.TxtBoxIdPersAbs = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAjoutAbs = new System.Windows.Forms.Button();
            this.BtnModifAbs = new System.Windows.Forms.Button();
            this.BtnSupprAbs = new System.Windows.Forms.Button();
            this.BtnAnnulGestAbs = new System.Windows.Forms.Button();
            this.GridViewAbsences = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBoxIdPersAbs);
            this.groupBox1.Controls.Add(this.TxtBoxPrenomPersAbs);
            this.groupBox1.Controls.Add(this.TxtBoxNomPersAbs);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personnel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "id";
            // 
            // TxtBoxNomPersAbs
            // 
            this.TxtBoxNomPersAbs.Enabled = false;
            this.TxtBoxNomPersAbs.Location = new System.Drawing.Point(42, 19);
            this.TxtBoxNomPersAbs.Name = "TxtBoxNomPersAbs";
            this.TxtBoxNomPersAbs.Size = new System.Drawing.Size(263, 20);
            this.TxtBoxNomPersAbs.TabIndex = 3;
            // 
            // TxtBoxPrenomPersAbs
            // 
            this.TxtBoxPrenomPersAbs.Enabled = false;
            this.TxtBoxPrenomPersAbs.Location = new System.Drawing.Point(405, 19);
            this.TxtBoxPrenomPersAbs.Name = "TxtBoxPrenomPersAbs";
            this.TxtBoxPrenomPersAbs.Size = new System.Drawing.Size(219, 20);
            this.TxtBoxPrenomPersAbs.TabIndex = 4;
            // 
            // TxtBoxIdPersAbs
            // 
            this.TxtBoxIdPersAbs.Enabled = false;
            this.TxtBoxIdPersAbs.Location = new System.Drawing.Point(691, 19);
            this.TxtBoxIdPersAbs.Name = "TxtBoxIdPersAbs";
            this.TxtBoxIdPersAbs.Size = new System.Drawing.Size(78, 20);
            this.TxtBoxIdPersAbs.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridViewAbsences);
            this.groupBox2.Location = new System.Drawing.Point(13, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 304);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Absences";
            // 
            // BtnAjoutAbs
            // 
            this.BtnAjoutAbs.Location = new System.Drawing.Point(142, 404);
            this.BtnAjoutAbs.Name = "BtnAjoutAbs";
            this.BtnAjoutAbs.Size = new System.Drawing.Size(75, 23);
            this.BtnAjoutAbs.TabIndex = 2;
            this.BtnAjoutAbs.Text = "Ajouter";
            this.BtnAjoutAbs.UseVisualStyleBackColor = true;
            // 
            // BtnModifAbs
            // 
            this.BtnModifAbs.Location = new System.Drawing.Point(282, 404);
            this.BtnModifAbs.Name = "BtnModifAbs";
            this.BtnModifAbs.Size = new System.Drawing.Size(75, 23);
            this.BtnModifAbs.TabIndex = 3;
            this.BtnModifAbs.Text = "Modifier";
            this.BtnModifAbs.UseVisualStyleBackColor = true;
            // 
            // BtnSupprAbs
            // 
            this.BtnSupprAbs.Location = new System.Drawing.Point(418, 404);
            this.BtnSupprAbs.Name = "BtnSupprAbs";
            this.BtnSupprAbs.Size = new System.Drawing.Size(75, 23);
            this.BtnSupprAbs.TabIndex = 4;
            this.BtnSupprAbs.Text = "Supprimer";
            this.BtnSupprAbs.UseVisualStyleBackColor = true;
            // 
            // BtnAnnulGestAbs
            // 
            this.BtnAnnulGestAbs.Location = new System.Drawing.Point(562, 404);
            this.BtnAnnulGestAbs.Name = "BtnAnnulGestAbs";
            this.BtnAnnulGestAbs.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnulGestAbs.TabIndex = 5;
            this.BtnAnnulGestAbs.Text = "Annuler";
            this.BtnAnnulGestAbs.UseVisualStyleBackColor = true;
            // 
            // GridViewAbsences
            // 
            this.GridViewAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewAbsences.Location = new System.Drawing.Point(9, 20);
            this.GridViewAbsences.Name = "GridViewAbsences";
            this.GridViewAbsences.Size = new System.Drawing.Size(754, 278);
            this.GridViewAbsences.TabIndex = 0;
            // 
            // GestionAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAnnulGestAbs);
            this.Controls.Add(this.BtnSupprAbs);
            this.Controls.Add(this.BtnModifAbs);
            this.Controls.Add(this.BtnAjoutAbs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionAbsences";
            this.Text = "Gestion des absences";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBoxIdPersAbs;
        private System.Windows.Forms.TextBox TxtBoxPrenomPersAbs;
        private System.Windows.Forms.TextBox TxtBoxNomPersAbs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridViewAbsences;
        private System.Windows.Forms.Button BtnAjoutAbs;
        private System.Windows.Forms.Button BtnModifAbs;
        private System.Windows.Forms.Button BtnSupprAbs;
        private System.Windows.Forms.Button BtnAnnulGestAbs;
    }
}