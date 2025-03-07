using MediaTek86.model;
using MediaTek86.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.view
{
    public partial class ModPersonnel : Form
    {
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmGestionPersonnelController controller;

        public ModPersonnel(String nom, String prenom, String tel, String mail, int service)
        {
            InitializeComponent();
            controller = new FrmGestionPersonnelController();
            TxtBoxNom2.Text = nom;
            TxtBoxPrenom2.Text = prenom;
            TextBoxTel2.Text = tel;
            TextBoxMail2.Text = mail;
            CBoxService2.SelectedIndex = service;

        }

        private void BtnPersEnregistrer_Click(object sender, EventArgs e)
        {
            if (!TxtBoxNom2.Text.Equals("") && !TxtBoxPrenom2.Text.Equals("") && !TextBoxTel2.Text.Equals("") && !TextBoxMail2.Text.Equals("") && CBoxService2.SelectedIndex != -1)
            {
            //    personnel.Nom = TxtBoxNom2.Text;
            //    personnel.Prenom = TxtBoxPrenom2.Text;
            //    personnel.Tel = TextBoxTel2.Text;
            //    personnel.Mail = TextBoxMail2.Text;
            //    String nomservice = CBoxService2.SelectedItem.ToString();
            //    int idservice = 1;
            //    if (nomservice == "médiation culturelle")
            //    {
            //        idservice = 2;
            //    }
            //    if (nomservice == "prêt")
            //    {
            //        idservice = 3;
            //    }
            //    Service service = new Service(idservice, nomservice);
            //    personnel.Service = service;
            //    if (MessageBox.Show("Voulez-vous apporter des modifications à " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        controller.UpdatePersonnel(personnel);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            //}
        }

    }
    }


}
