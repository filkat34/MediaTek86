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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionPersonnel));
            this.dataGridPersonnels = new System.Windows.Forms.DataGridView();
            this.BtnPersSupprimer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ModPersonnel = new System.Windows.Forms.Button();
            this.BtnAddPersonnel = new System.Windows.Forms.Button();
            this.BtnSupprAbs = new System.Windows.Forms.Button();
            this.BtnAbsModif = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GridViewAbsences = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TimeAbsFin = new System.Windows.Forms.DateTimePicker();
            this.TimeAbsDeb = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CBoxMotifAbs = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateAbsFin = new System.Windows.Forms.DateTimePicker();
            this.BtnAbsEnregistrer = new System.Windows.Forms.Button();
            this.dateAbsDeb = new System.Windows.Forms.DateTimePicker();
            this.BtnShowAbsences = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonnels)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAbsences)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.groupBox3.Size = new System.Drawing.Size(524, 57);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gestion du personnel";
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
            // BtnSupprAbs
            // 
            this.BtnSupprAbs.Location = new System.Drawing.Point(377, 132);
            this.BtnSupprAbs.Name = "BtnSupprAbs";
            this.BtnSupprAbs.Size = new System.Drawing.Size(88, 23);
            this.BtnSupprAbs.TabIndex = 16;
            this.BtnSupprAbs.Text = "Supprimer";
            this.BtnSupprAbs.UseVisualStyleBackColor = true;
            // 
            // BtnAbsModif
            // 
            this.BtnAbsModif.Location = new System.Drawing.Point(265, 132);
            this.BtnAbsModif.Name = "BtnAbsModif";
            this.BtnAbsModif.Size = new System.Drawing.Size(88, 23);
            this.BtnAbsModif.TabIndex = 15;
            this.BtnAbsModif.Text = "Modifier";
            this.BtnAbsModif.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GridViewAbsences);
            this.groupBox4.Location = new System.Drawing.Point(550, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 482);
            this.groupBox4.TabIndex = 26;
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
            this.GridViewAbsences.Location = new System.Drawing.Point(11, 19);
            this.GridViewAbsences.MultiSelect = false;
            this.GridViewAbsences.Name = "GridViewAbsences";
            this.GridViewAbsences.ReadOnly = true;
            this.GridViewAbsences.RowHeadersVisible = false;
            this.GridViewAbsences.RowTemplate.ReadOnly = true;
            this.GridViewAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewAbsences.ShowEditingIcon = false;
            this.GridViewAbsences.Size = new System.Drawing.Size(468, 457);
            this.GridViewAbsences.TabIndex = 0;
            this.GridViewAbsences.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TimeAbsFin);
            this.groupBox6.Controls.Add(this.TimeAbsDeb);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.BtnAbsModif);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.CBoxMotifAbs);
            this.groupBox6.Controls.Add(this.BtnSupprAbs);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.dateAbsFin);
            this.groupBox6.Controls.Add(this.BtnAbsEnregistrer);
            this.groupBox6.Controls.Add(this.dateAbsDeb);
            this.groupBox6.Location = new System.Drawing.Point(551, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(485, 167);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Gestion des absences";
            // 
            // TimeAbsFin
            // 
            this.TimeAbsFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeAbsFin.Location = new System.Drawing.Point(411, 59);
            this.TimeAbsFin.Name = "TimeAbsFin";
            this.TimeAbsFin.ShowUpDown = true;
            this.TimeAbsFin.Size = new System.Drawing.Size(63, 20);
            this.TimeAbsFin.TabIndex = 12;
            // 
            // TimeAbsDeb
            // 
            this.TimeAbsDeb.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeAbsDeb.Location = new System.Drawing.Point(411, 17);
            this.TimeAbsDeb.Name = "TimeAbsDeb";
            this.TimeAbsDeb.ShowUpDown = true;
            this.TimeAbsDeb.Size = new System.Drawing.Size(63, 20);
            this.TimeAbsDeb.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Date de début";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Date de fin";
            // 
            // CBoxMotifAbs
            // 
            this.CBoxMotifAbs.FormattingEnabled = true;
            this.CBoxMotifAbs.Items.AddRange(new object[] {
            "vacances",
            "maladie",
            "motif familial",
            "congé parental"});
            this.CBoxMotifAbs.Location = new System.Drawing.Point(216, 94);
            this.CBoxMotifAbs.Name = "CBoxMotifAbs";
            this.CBoxMotifAbs.Size = new System.Drawing.Size(200, 21);
            this.CBoxMotifAbs.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Motif";
            // 
            // dateAbsFin
            // 
            this.dateAbsFin.Location = new System.Drawing.Point(216, 59);
            this.dateAbsFin.Name = "dateAbsFin";
            this.dateAbsFin.Size = new System.Drawing.Size(178, 20);
            this.dateAbsFin.TabIndex = 11;
            // 
            // BtnAbsEnregistrer
            // 
            this.BtnAbsEnregistrer.Location = new System.Drawing.Point(154, 132);
            this.BtnAbsEnregistrer.Name = "BtnAbsEnregistrer";
            this.BtnAbsEnregistrer.Size = new System.Drawing.Size(88, 23);
            this.BtnAbsEnregistrer.TabIndex = 14;
            this.BtnAbsEnregistrer.Text = "Enregistrer";
            this.BtnAbsEnregistrer.UseVisualStyleBackColor = true;
            // 
            // dateAbsDeb
            // 
            this.dateAbsDeb.Location = new System.Drawing.Point(216, 17);
            this.dateAbsDeb.Name = "dateAbsDeb";
            this.dateAbsDeb.Size = new System.Drawing.Size(178, 20);
            this.dateAbsDeb.TabIndex = 9;
            this.dateAbsDeb.Value = new System.DateTime(2025, 3, 25, 23, 59, 59, 0);
            // 
            // BtnShowAbsences
            // 
            this.BtnShowAbsences.Location = new System.Drawing.Point(392, 23);
            this.BtnShowAbsences.Name = "BtnShowAbsences";
            this.BtnShowAbsences.Size = new System.Drawing.Size(117, 23);
            this.BtnShowAbsences.TabIndex = 4;
            this.BtnShowAbsences.Text = "Absences";
            this.BtnShowAbsences.UseVisualStyleBackColor = true;
            // 
            // FrmGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 678);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1061, 718);
            this.MinimumSize = new System.Drawing.Size(1061, 718);
            this.Name = "FrmGestionPersonnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediaTek86";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonnels)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAbsences)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPersonnels;
        private System.Windows.Forms.Button BtnPersSupprimer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnSupprAbs;
        private System.Windows.Forms.Button BtnAbsModif;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView GridViewAbsences;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnAbsEnregistrer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBoxMotifAbs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateAbsFin;
        private System.Windows.Forms.DateTimePicker dateAbsDeb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DateTimePicker TimeAbsDeb;
        private DateTimePicker TimeAbsFin;
        private Button BtnAddPersonnel;
        private Button ModPersonnel;
        private Button BtnShowAbsences;
    }
}

