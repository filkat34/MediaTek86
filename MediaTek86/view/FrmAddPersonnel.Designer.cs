namespace MediaTek86.view
{
    partial class FrmAddPersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddPersonnel));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxNom1 = new System.Windows.Forms.TextBox();
            this.BtnPersEnregistrer = new System.Windows.Forms.Button();
            this.TxtBoxPrenom1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxService1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxMail1 = new System.Windows.Forms.TextBox();
            this.TextBoxTel1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nom";
            // 
            // TxtBoxNom1
            // 
            this.TxtBoxNom1.Location = new System.Drawing.Point(203, 9);
            this.TxtBoxNom1.Name = "TxtBoxNom1";
            this.TxtBoxNom1.Size = new System.Drawing.Size(288, 20);
            this.TxtBoxNom1.TabIndex = 42;
            // 
            // BtnPersEnregistrer
            // 
            this.BtnPersEnregistrer.Location = new System.Drawing.Point(203, 200);
            this.BtnPersEnregistrer.Name = "BtnPersEnregistrer";
            this.BtnPersEnregistrer.Size = new System.Drawing.Size(117, 23);
            this.BtnPersEnregistrer.TabIndex = 47;
            this.BtnPersEnregistrer.Text = "Enregistrer";
            this.BtnPersEnregistrer.UseVisualStyleBackColor = true;
            this.BtnPersEnregistrer.Click += new System.EventHandler(this.BtnPersEnregistrer_Click);
            // 
            // TxtBoxPrenom1
            // 
            this.TxtBoxPrenom1.Location = new System.Drawing.Point(203, 45);
            this.TxtBoxPrenom1.Name = "TxtBoxPrenom1";
            this.TxtBoxPrenom1.Size = new System.Drawing.Size(288, 20);
            this.TxtBoxPrenom1.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Prénom";
            // 
            // CBoxService1
            // 
            this.CBoxService1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxService1.Items.AddRange(new object[] {
            "prêt",
            "administratif",
            "médiation culturelle"});
            this.CBoxService1.Location = new System.Drawing.Point(203, 161);
            this.CBoxService1.Name = "CBoxService1";
            this.CBoxService1.Size = new System.Drawing.Size(288, 21);
            this.CBoxService1.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Service";
            // 
            // TextBoxMail1
            // 
            this.TextBoxMail1.Location = new System.Drawing.Point(203, 121);
            this.TextBoxMail1.Name = "TextBoxMail1";
            this.TextBoxMail1.Size = new System.Drawing.Size(288, 20);
            this.TextBoxMail1.TabIndex = 45;
            // 
            // TextBoxTel1
            // 
            this.TextBoxTel1.Location = new System.Drawing.Point(203, 82);
            this.TextBoxTel1.Name = "TextBoxTel1";
            this.TextBoxTel1.Size = new System.Drawing.Size(288, 20);
            this.TextBoxTel1.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Téléphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Mail";
            // 
            // FrmAddPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(509, 236);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxNom1);
            this.Controls.Add(this.BtnPersEnregistrer);
            this.Controls.Add(this.TxtBoxPrenom1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBoxService1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxMail1);
            this.Controls.Add(this.TextBoxTel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(525, 275);
            this.MinimumSize = new System.Drawing.Size(525, 275);
            this.Name = "FrmAddPersonnel";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un personnel";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxNom1;
        private System.Windows.Forms.Button BtnPersEnregistrer;
        private System.Windows.Forms.TextBox TxtBoxPrenom1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxService1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxMail1;
        private System.Windows.Forms.TextBox TextBoxTel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}