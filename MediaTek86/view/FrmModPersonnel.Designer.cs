namespace MediaTek86.view
{
    partial class FrmModPersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModPersonnel));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxNom2 = new System.Windows.Forms.TextBox();
            this.BtnPersEnregistrer = new System.Windows.Forms.Button();
            this.TxtBoxPrenom2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxService2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxMail2 = new System.Windows.Forms.TextBox();
            this.TextBoxTel2 = new System.Windows.Forms.TextBox();
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
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Nom";
            // 
            // TxtBoxNom2
            // 
            this.TxtBoxNom2.Location = new System.Drawing.Point(203, 9);
            this.TxtBoxNom2.Name = "TxtBoxNom2";
            this.TxtBoxNom2.Size = new System.Drawing.Size(288, 20);
            this.TxtBoxNom2.TabIndex = 56;
            // 
            // BtnPersEnregistrer
            // 
            this.BtnPersEnregistrer.Location = new System.Drawing.Point(218, 200);
            this.BtnPersEnregistrer.Name = "BtnPersEnregistrer";
            this.BtnPersEnregistrer.Size = new System.Drawing.Size(117, 23);
            this.BtnPersEnregistrer.TabIndex = 61;
            this.BtnPersEnregistrer.Text = "Enregistrer";
            this.BtnPersEnregistrer.UseVisualStyleBackColor = true;
            this.BtnPersEnregistrer.Click += new System.EventHandler(this.BtnPersEnregistrer_Click);
            // 
            // TxtBoxPrenom2
            // 
            this.TxtBoxPrenom2.Location = new System.Drawing.Point(203, 45);
            this.TxtBoxPrenom2.Name = "TxtBoxPrenom2";
            this.TxtBoxPrenom2.Size = new System.Drawing.Size(288, 20);
            this.TxtBoxPrenom2.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Prénom";
            // 
            // CBoxService2
            // 
            this.CBoxService2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxService2.Items.AddRange(new object[] {
            "prêt",
            "administratif",
            "médiation culturelle"});
            this.CBoxService2.Location = new System.Drawing.Point(203, 161);
            this.CBoxService2.Name = "CBoxService2";
            this.CBoxService2.Size = new System.Drawing.Size(288, 21);
            this.CBoxService2.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Service";
            // 
            // TextBoxMail2
            // 
            this.TextBoxMail2.Location = new System.Drawing.Point(203, 121);
            this.TextBoxMail2.Name = "TextBoxMail2";
            this.TextBoxMail2.Size = new System.Drawing.Size(288, 20);
            this.TextBoxMail2.TabIndex = 59;
            // 
            // TextBoxTel2
            // 
            this.TextBoxTel2.Location = new System.Drawing.Point(203, 82);
            this.TextBoxTel2.Name = "TextBoxTel2";
            this.TextBoxTel2.Size = new System.Drawing.Size(288, 20);
            this.TextBoxTel2.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Téléphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Mail";
            // 
            // FrmModPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 235);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxNom2);
            this.Controls.Add(this.BtnPersEnregistrer);
            this.Controls.Add(this.TxtBoxPrenom2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBoxService2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxMail2);
            this.Controls.Add(this.TextBoxTel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(525, 275);
            this.MinimumSize = new System.Drawing.Size(525, 275);
            this.Name = "FrmModPersonnel";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifier un personnel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxNom2;
        private System.Windows.Forms.Button BtnPersEnregistrer;
        private System.Windows.Forms.TextBox TxtBoxPrenom2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxService2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxMail2;
        private System.Windows.Forms.TextBox TextBoxTel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}