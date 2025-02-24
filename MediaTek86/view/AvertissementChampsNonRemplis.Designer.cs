namespace MediaTek86.view
{
    partial class AvertissementChampsNonRemplis
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
            this.BtnAvertissementAjoutPers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tous les champs n\'ont pas été renseignés !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veuillez renseigner tous les champs avant de cliquer sur \"Enregistrer\".";
            // 
            // BtnAvertissementAjoutPers
            // 
            this.BtnAvertissementAjoutPers.Location = new System.Drawing.Point(144, 107);
            this.BtnAvertissementAjoutPers.Name = "BtnAvertissementAjoutPers";
            this.BtnAvertissementAjoutPers.Size = new System.Drawing.Size(75, 23);
            this.BtnAvertissementAjoutPers.TabIndex = 2;
            this.BtnAvertissementAjoutPers.Text = "OK";
            this.BtnAvertissementAjoutPers.UseVisualStyleBackColor = true;
            // 
            // AjoutPersonnelAvertissement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 140);
            this.Controls.Add(this.BtnAvertissementAjoutPers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjoutPersonnelAvertissement";
            this.Text = "Avertissement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAvertissementAjoutPers;
    }
}