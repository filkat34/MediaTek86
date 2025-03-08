namespace MediaTek86.view
{
    partial class FrmAddAbsence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddAbsence));
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeAbsFin
            // 
            this.TimeAbsFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeAbsFin.Location = new System.Drawing.Point(417, 61);
            this.TimeAbsFin.Name = "TimeAbsFin";
            this.TimeAbsFin.ShowUpDown = true;
            this.TimeAbsFin.Size = new System.Drawing.Size(63, 20);
            this.TimeAbsFin.TabIndex = 44;
            // 
            // TimeAbsDeb
            // 
            this.TimeAbsDeb.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeAbsDeb.Location = new System.Drawing.Point(417, 19);
            this.TimeAbsDeb.Name = "TimeAbsDeb";
            this.TimeAbsDeb.ShowUpDown = true;
            this.TimeAbsDeb.Size = new System.Drawing.Size(63, 20);
            this.TimeAbsDeb.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Date de début";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 48;
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
            this.CBoxMotifAbs.Location = new System.Drawing.Point(222, 96);
            this.CBoxMotifAbs.Name = "CBoxMotifAbs";
            this.CBoxMotifAbs.Size = new System.Drawing.Size(200, 21);
            this.CBoxMotifAbs.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Motif";
            // 
            // dateAbsFin
            // 
            this.dateAbsFin.Location = new System.Drawing.Point(222, 61);
            this.dateAbsFin.Name = "dateAbsFin";
            this.dateAbsFin.Size = new System.Drawing.Size(178, 20);
            this.dateAbsFin.TabIndex = 43;
            // 
            // BtnAbsEnregistrer
            // 
            this.BtnAbsEnregistrer.Location = new System.Drawing.Point(222, 140);
            this.BtnAbsEnregistrer.Name = "BtnAbsEnregistrer";
            this.BtnAbsEnregistrer.Size = new System.Drawing.Size(88, 23);
            this.BtnAbsEnregistrer.TabIndex = 46;
            this.BtnAbsEnregistrer.Text = "Enregistrer";
            this.BtnAbsEnregistrer.UseVisualStyleBackColor = true;
            // 
            // dateAbsDeb
            // 
            this.dateAbsDeb.Location = new System.Drawing.Point(222, 19);
            this.dateAbsDeb.Name = "dateAbsDeb";
            this.dateAbsDeb.Size = new System.Drawing.Size(178, 20);
            this.dateAbsDeb.TabIndex = 41;
            this.dateAbsDeb.Value = new System.DateTime(2025, 3, 25, 23, 59, 59, 0);
            // 
            // FrmAddAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 173);
            this.Controls.Add(this.TimeAbsFin);
            this.Controls.Add(this.TimeAbsDeb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBoxMotifAbs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateAbsFin);
            this.Controls.Add(this.BtnAbsEnregistrer);
            this.Controls.Add(this.dateAbsDeb);
            this.Name = "FrmAddAbsence";
            this.Text = "Ajouter une absence";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker TimeAbsFin;
        private System.Windows.Forms.DateTimePicker TimeAbsDeb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBoxMotifAbs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateAbsFin;
        private System.Windows.Forms.Button BtnAbsEnregistrer;
        private System.Windows.Forms.DateTimePicker dateAbsDeb;
    }
}