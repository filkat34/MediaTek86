namespace MediaTek86.view
{
    partial class AjoutModifPersonnel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBoxAjoutService = new System.Windows.Forms.ComboBox();
            this.TextBoxAjoutMail = new System.Windows.Forms.TextBox();
            this.TextBoxAjoutTel = new System.Windows.Forms.TextBox();
            this.TxtBoxAjoutPrenom = new System.Windows.Forms.TextBox();
            this.TxtBoxAjoutNom = new System.Windows.Forms.TextBox();
            this.BtnAjoutAnnuler = new System.Windows.Forms.Button();
            this.BtnAjoutEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Téléphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Service";
            // 
            // CBoxAjoutService
            // 
            this.CBoxAjoutService.FormattingEnabled = true;
            this.CBoxAjoutService.Items.AddRange(new object[] {
            "prêt",
            "administratif",
            "médiatition culturelle"});
            this.CBoxAjoutService.Location = new System.Drawing.Point(114, 155);
            this.CBoxAjoutService.Name = "CBoxAjoutService";
            this.CBoxAjoutService.Size = new System.Drawing.Size(266, 21);
            this.CBoxAjoutService.TabIndex = 5;
            // 
            // TextBoxAjoutMail
            // 
            this.TextBoxAjoutMail.Location = new System.Drawing.Point(114, 119);
            this.TextBoxAjoutMail.Name = "TextBoxAjoutMail";
            this.TextBoxAjoutMail.Size = new System.Drawing.Size(266, 20);
            this.TextBoxAjoutMail.TabIndex = 6;
            // 
            // TextBoxAjoutTel
            // 
            this.TextBoxAjoutTel.Location = new System.Drawing.Point(114, 85);
            this.TextBoxAjoutTel.Name = "TextBoxAjoutTel";
            this.TextBoxAjoutTel.Size = new System.Drawing.Size(266, 20);
            this.TextBoxAjoutTel.TabIndex = 7;
            // 
            // TxtBoxAjoutPrenom
            // 
            this.TxtBoxAjoutPrenom.Location = new System.Drawing.Point(114, 52);
            this.TxtBoxAjoutPrenom.Name = "TxtBoxAjoutPrenom";
            this.TxtBoxAjoutPrenom.Size = new System.Drawing.Size(266, 20);
            this.TxtBoxAjoutPrenom.TabIndex = 8;
            // 
            // TxtBoxAjoutNom
            // 
            this.TxtBoxAjoutNom.Location = new System.Drawing.Point(114, 19);
            this.TxtBoxAjoutNom.Name = "TxtBoxAjoutNom";
            this.TxtBoxAjoutNom.Size = new System.Drawing.Size(266, 20);
            this.TxtBoxAjoutNom.TabIndex = 9;
            // 
            // BtnAjoutAnnuler
            // 
            this.BtnAjoutAnnuler.Location = new System.Drawing.Point(105, 206);
            this.BtnAjoutAnnuler.Name = "BtnAjoutAnnuler";
            this.BtnAjoutAnnuler.Size = new System.Drawing.Size(75, 23);
            this.BtnAjoutAnnuler.TabIndex = 10;
            this.BtnAjoutAnnuler.Text = "Annuler";
            this.BtnAjoutAnnuler.UseVisualStyleBackColor = true;
            // 
            // BtnAjoutEnregistrer
            // 
            this.BtnAjoutEnregistrer.Location = new System.Drawing.Point(236, 206);
            this.BtnAjoutEnregistrer.Name = "BtnAjoutEnregistrer";
            this.BtnAjoutEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.BtnAjoutEnregistrer.TabIndex = 11;
            this.BtnAjoutEnregistrer.Text = "Enregistrer";
            this.BtnAjoutEnregistrer.UseVisualStyleBackColor = true;
            // 
            // AjoutModifPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 243);
            this.Controls.Add(this.BtnAjoutEnregistrer);
            this.Controls.Add(this.BtnAjoutAnnuler);
            this.Controls.Add(this.TxtBoxAjoutNom);
            this.Controls.Add(this.TxtBoxAjoutPrenom);
            this.Controls.Add(this.TextBoxAjoutTel);
            this.Controls.Add(this.TextBoxAjoutMail);
            this.Controls.Add(this.CBoxAjoutService);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjoutModifPersonnel";
            this.Text = "Informations sur le personnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBoxAjoutService;
        private System.Windows.Forms.TextBox TextBoxAjoutMail;
        private System.Windows.Forms.TextBox TextBoxAjoutTel;
        private System.Windows.Forms.TextBox TxtBoxAjoutPrenom;
        private System.Windows.Forms.TextBox TxtBoxAjoutNom;
        private System.Windows.Forms.Button BtnAjoutAnnuler;
        private System.Windows.Forms.Button BtnAjoutEnregistrer;
    }
}