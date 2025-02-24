namespace MediaTek86.view
{
    partial class Connexion
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
            this.TxtBoxLogin = new System.Windows.Forms.TextBox();
            this.TxtBoxPwd = new System.Windows.Forms.TextBox();
            this.BtnConnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            // 
            // TxtBoxLogin
            // 
            this.TxtBoxLogin.Location = new System.Drawing.Point(110, 33);
            this.TxtBoxLogin.Name = "TxtBoxLogin";
            this.TxtBoxLogin.Size = new System.Drawing.Size(277, 20);
            this.TxtBoxLogin.TabIndex = 2;
            // 
            // TxtBoxPwd
            // 
            this.TxtBoxPwd.Location = new System.Drawing.Point(110, 73);
            this.TxtBoxPwd.Name = "TxtBoxPwd";
            this.TxtBoxPwd.Size = new System.Drawing.Size(277, 20);
            this.TxtBoxPwd.TabIndex = 3;
            this.TxtBoxPwd.UseSystemPasswordChar = true;
            // 
            // BtnConnexion
            // 
            this.BtnConnexion.Location = new System.Drawing.Point(174, 115);
            this.BtnConnexion.Name = "BtnConnexion";
            this.BtnConnexion.Size = new System.Drawing.Size(96, 30);
            this.BtnConnexion.TabIndex = 4;
            this.BtnConnexion.Text = "Connexion";
            this.BtnConnexion.UseVisualStyleBackColor = true;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 168);
            this.Controls.Add(this.BtnConnexion);
            this.Controls.Add(this.TxtBoxPwd);
            this.Controls.Add(this.TxtBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxLogin;
        private System.Windows.Forms.TextBox TxtBoxPwd;
        private System.Windows.Forms.Button BtnConnexion;
    }
}