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
            this.BtnModifier = new System.Windows.Forms.Button();
            this.TxtBoxNom = new System.Windows.Forms.TextBox();
            this.TxtBoxPrenom = new System.Windows.Forms.TextBox();
            this.TextBoxTel = new System.Windows.Forms.TextBox();
            this.TextBoxMail = new System.Windows.Forms.TextBox();
            this.CBoxService = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnPersEnregistrer = new System.Windows.Forms.Button();
            this.BtnSupprAbs = new System.Windows.Forms.Button();
            this.BtnAbsModif = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GridViewAbsences = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CBoxMotifAbs = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.daTimeAbsFin = new System.Windows.Forms.DateTimePicker();
            this.BtnAbsEnregistrer = new System.Windows.Forms.Button();
            this.daTimeAbsDeb = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonnels)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.dataGridPersonnels.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonnels.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridPersonnels.Location = new System.Drawing.Point(15, 19);
            this.dataGridPersonnels.MultiSelect = false;
            this.dataGridPersonnels.Name = "dataGridPersonnels";
            this.dataGridPersonnels.ReadOnly = true;
            this.dataGridPersonnels.RowHeadersVisible = false;
            this.dataGridPersonnels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPersonnels.ShowEditingIcon = false;
            this.dataGridPersonnels.Size = new System.Drawing.Size(503, 387);
            this.dataGridPersonnels.TabIndex = 0;
            // 
            // BtnPersSupprimer
            // 
            this.BtnPersSupprimer.Location = new System.Drawing.Point(11, 201);
            this.BtnPersSupprimer.Name = "BtnPersSupprimer";
            this.BtnPersSupprimer.Size = new System.Drawing.Size(117, 23);
            this.BtnPersSupprimer.TabIndex = 2;
            this.BtnPersSupprimer.Text = "Supprimer";
            this.BtnPersSupprimer.UseVisualStyleBackColor = true;
            // 
            // BtnModifier
            // 
            this.BtnModifier.Location = new System.Drawing.Point(11, 172);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(117, 23);
            this.BtnModifier.TabIndex = 1;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            // 
            // TxtBoxNom
            // 
            this.TxtBoxNom.Location = new System.Drawing.Point(202, 17);
            this.TxtBoxNom.Name = "TxtBoxNom";
            this.TxtBoxNom.Size = new System.Drawing.Size(288, 20);
            this.TxtBoxNom.TabIndex = 21;
            // 
            // TxtBoxPrenom
            // 
            this.TxtBoxPrenom.Location = new System.Drawing.Point(202, 56);
            this.TxtBoxPrenom.Name = "TxtBoxPrenom";
            this.TxtBoxPrenom.Size = new System.Drawing.Size(288, 20);
            this.TxtBoxPrenom.TabIndex = 20;
            // 
            // TextBoxTel
            // 
            this.TextBoxTel.Location = new System.Drawing.Point(202, 99);
            this.TextBoxTel.Name = "TextBoxTel";
            this.TextBoxTel.Size = new System.Drawing.Size(288, 20);
            this.TextBoxTel.TabIndex = 19;
            // 
            // TextBoxMail
            // 
            this.TextBoxMail.Location = new System.Drawing.Point(202, 143);
            this.TextBoxMail.Name = "TextBoxMail";
            this.TextBoxMail.Size = new System.Drawing.Size(288, 20);
            this.TextBoxMail.TabIndex = 18;
            // 
            // CBoxService
            // 
            this.CBoxService.FormattingEnabled = true;
            this.CBoxService.Items.AddRange(new object[] {
            "prêt",
            "administratif",
            "médiatition culturelle"});
            this.CBoxService.Location = new System.Drawing.Point(202, 190);
            this.CBoxService.Name = "CBoxService";
            this.CBoxService.Size = new System.Drawing.Size(288, 21);
            this.CBoxService.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Téléphone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nom";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridPersonnels);
            this.groupBox2.Location = new System.Drawing.Point(8, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 412);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des personnels";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.BtnPersSupprimer);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.BtnModifier);
            this.groupBox3.Controls.Add(this.TxtBoxNom);
            this.groupBox3.Controls.Add(this.BtnPersEnregistrer);
            this.groupBox3.Controls.Add(this.TxtBoxPrenom);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.CBoxService);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TextBoxMail);
            this.groupBox3.Controls.Add(this.TextBoxTel);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 237);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gestion du personnel";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // BtnPersEnregistrer
            // 
            this.BtnPersEnregistrer.Location = new System.Drawing.Point(11, 142);
            this.BtnPersEnregistrer.Name = "BtnPersEnregistrer";
            this.BtnPersEnregistrer.Size = new System.Drawing.Size(117, 23);
            this.BtnPersEnregistrer.TabIndex = 22;
            this.BtnPersEnregistrer.Text = "Enregistrer";
            this.BtnPersEnregistrer.UseVisualStyleBackColor = true;
            this.BtnPersEnregistrer.Click += new System.EventHandler(this.BtnPersEnregistrer_Click);
            // 
            // BtnSupprAbs
            // 
            this.BtnSupprAbs.Enabled = false;
            this.BtnSupprAbs.Location = new System.Drawing.Point(377, 132);
            this.BtnSupprAbs.Name = "BtnSupprAbs";
            this.BtnSupprAbs.Size = new System.Drawing.Size(88, 23);
            this.BtnSupprAbs.TabIndex = 29;
            this.BtnSupprAbs.Text = "Supprimer";
            this.BtnSupprAbs.UseVisualStyleBackColor = true;
            // 
            // BtnAbsModif
            // 
            this.BtnAbsModif.Enabled = false;
            this.BtnAbsModif.Location = new System.Drawing.Point(265, 132);
            this.BtnAbsModif.Name = "BtnAbsModif";
            this.BtnAbsModif.Size = new System.Drawing.Size(88, 23);
            this.BtnAbsModif.TabIndex = 28;
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
            this.GridViewAbsences.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GridViewAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewAbsences.Location = new System.Drawing.Point(11, 19);
            this.GridViewAbsences.Name = "GridViewAbsences";
            this.GridViewAbsences.Size = new System.Drawing.Size(468, 457);
            this.GridViewAbsences.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.BtnAbsModif);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.CBoxMotifAbs);
            this.groupBox6.Controls.Add(this.BtnSupprAbs);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.daTimeAbsFin);
            this.groupBox6.Controls.Add(this.BtnAbsEnregistrer);
            this.groupBox6.Controls.Add(this.daTimeAbsDeb);
            this.groupBox6.Location = new System.Drawing.Point(551, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(485, 167);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Gestion des absences";
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
            this.label8.Location = new System.Drawing.Point(151, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Date de début";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Date de fin";
            // 
            // CBoxMotifAbs
            // 
            this.CBoxMotifAbs.Enabled = false;
            this.CBoxMotifAbs.FormattingEnabled = true;
            this.CBoxMotifAbs.Items.AddRange(new object[] {
            "vacances",
            "maladie",
            "motif familial",
            "congé parental"});
            this.CBoxMotifAbs.Location = new System.Drawing.Point(265, 94);
            this.CBoxMotifAbs.Name = "CBoxMotifAbs";
            this.CBoxMotifAbs.Size = new System.Drawing.Size(200, 21);
            this.CBoxMotifAbs.TabIndex = 38;
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
            // daTimeAbsFin
            // 
            this.daTimeAbsFin.Enabled = false;
            this.daTimeAbsFin.Location = new System.Drawing.Point(265, 55);
            this.daTimeAbsFin.Name = "daTimeAbsFin";
            this.daTimeAbsFin.Size = new System.Drawing.Size(200, 20);
            this.daTimeAbsFin.TabIndex = 37;
            // 
            // BtnAbsEnregistrer
            // 
            this.BtnAbsEnregistrer.Enabled = false;
            this.BtnAbsEnregistrer.Location = new System.Drawing.Point(154, 132);
            this.BtnAbsEnregistrer.Name = "BtnAbsEnregistrer";
            this.BtnAbsEnregistrer.Size = new System.Drawing.Size(88, 23);
            this.BtnAbsEnregistrer.TabIndex = 39;
            this.BtnAbsEnregistrer.Text = "Enregistrer";
            this.BtnAbsEnregistrer.UseVisualStyleBackColor = true;
            // 
            // daTimeAbsDeb
            // 
            this.daTimeAbsDeb.Enabled = false;
            this.daTimeAbsDeb.Location = new System.Drawing.Point(265, 16);
            this.daTimeAbsDeb.Name = "daTimeAbsDeb";
            this.daTimeAbsDeb.Size = new System.Drawing.Size(200, 20);
            this.daTimeAbsDeb.TabIndex = 36;
            // 
            // FrmGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 679);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
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
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.TextBox TxtBoxNom;
        private System.Windows.Forms.TextBox TxtBoxPrenom;
        private System.Windows.Forms.TextBox TextBoxTel;
        private System.Windows.Forms.TextBox TextBoxMail;
        private System.Windows.Forms.ComboBox CBoxService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DateTimePicker daTimeAbsFin;
        private System.Windows.Forms.DateTimePicker daTimeAbsDeb;
        private System.Windows.Forms.Button BtnPersEnregistrer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

