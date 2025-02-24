namespace MediaTek86.view
{
    partial class SupprPers
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
            this.AffichePersAsupprimer = new System.Windows.Forms.Label();
            this.BtnAnnulerSupprPers = new System.Windows.Forms.Button();
            this.BtnContinuerSupprPers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vous êtes sur le point de supprimer définitivement le personnel suivant de la bas" +
    "e :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voulez-vous continuer ?";
            // 
            // AffichePersAsupprimer
            // 
            this.AffichePersAsupprimer.AutoSize = true;
            this.AffichePersAsupprimer.Location = new System.Drawing.Point(178, 66);
            this.AffichePersAsupprimer.Name = "AffichePersAsupprimer";
            this.AffichePersAsupprimer.Size = new System.Drawing.Size(71, 13);
            this.AffichePersAsupprimer.TabIndex = 3;
            this.AffichePersAsupprimer.Text = "Nom, Prénom";
            // 
            // BtnAnnulerSupprPers
            // 
            this.BtnAnnulerSupprPers.Location = new System.Drawing.Point(113, 146);
            this.BtnAnnulerSupprPers.Name = "BtnAnnulerSupprPers";
            this.BtnAnnulerSupprPers.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnulerSupprPers.TabIndex = 4;
            this.BtnAnnulerSupprPers.Text = "Annuler";
            this.BtnAnnulerSupprPers.UseVisualStyleBackColor = true;
            // 
            // BtnContinuerSupprPers
            // 
            this.BtnContinuerSupprPers.Location = new System.Drawing.Point(237, 146);
            this.BtnContinuerSupprPers.Name = "BtnContinuerSupprPers";
            this.BtnContinuerSupprPers.Size = new System.Drawing.Size(75, 23);
            this.BtnContinuerSupprPers.TabIndex = 5;
            this.BtnContinuerSupprPers.Text = "Continuer";
            this.BtnContinuerSupprPers.UseVisualStyleBackColor = true;
            // 
            // SupprPers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 193);
            this.Controls.Add(this.BtnContinuerSupprPers);
            this.Controls.Add(this.BtnAnnulerSupprPers);
            this.Controls.Add(this.AffichePersAsupprimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SupprPers";
            this.Text = "Confirmation de suppression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AffichePersAsupprimer;
        private System.Windows.Forms.Button BtnAnnulerSupprPers;
        private System.Windows.Forms.Button BtnContinuerSupprPers;
    }
}