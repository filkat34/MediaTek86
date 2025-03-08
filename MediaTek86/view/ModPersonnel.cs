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
using System.Windows.Forms.Design;
using System.Collections;

namespace MediaTek86.view
{
    public partial class ModPersonnel : Form
    {
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmGestionPersonnelController controller;

        /// <summary>
        /// Création d'une liste pour sauvegarder les informations originelles du personnel en cours de modification
        /// </summary>
        public List<Personnel> personnelEnCoursdeModif = new List<Personnel>();

        /// <summary>
        /// Variable pour sauvegarder l'identifiant du personnel en cours de modification
        /// </summary>
        public int idpersonnelencoursdemodif;

        /// <summary>
        /// Initialisation de la fenêtre de modification du personnel avec des données issues de la fenêtre de gestion du personnel
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="service"></param>
        public ModPersonnel(int idpersonnel, String nom, String prenom, String tel, String mail, Service service)
        {
            InitializeComponent();
            controller = new FrmGestionPersonnelController();
            int idpersonnelencoursdemodif = idpersonnel;
            TxtBoxNom2.Text = nom ;
            TxtBoxPrenom2.Text = prenom;
            TextBoxTel2.Text = tel;
            TextBoxMail2.Text = mail;
            CBoxService2.SelectedIndex = CBoxService2.FindStringExact(service.Nom);
            
            ///Sauvegarde du personnel avant modification pour affichage lors de la confirmation de modification
            personnelEnCoursdeModif.Add(new Personnel(idpersonnelencoursdemodif, nom, prenom, tel, mail, service));

            ///Création d'un objet personnel pour sauvegarder les modifications apportées
            personnelEnCoursdeModif.Add(new Personnel(idpersonnelencoursdemodif, nom, prenom, tel, mail, service));
        }

        /// <summary>
        /// Demande d'enregistrement des modifications après confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPersEnregistrer_Click(object sender, EventArgs e)
        {
            Personnel personnel = personnelEnCoursdeModif[1];

            if (!TxtBoxNom2.Text.Equals("") && !TxtBoxPrenom2.Text.Equals("") && !TextBoxTel2.Text.Equals("") && !TextBoxMail2.Text.Equals("") && CBoxService2.SelectedIndex != -1)
            {
                personnel.Nom = TxtBoxNom2.Text;
                personnel.Prenom = TxtBoxPrenom2.Text;
                personnel.Tel = TextBoxTel2.Text;
                personnel.Mail = TextBoxMail2.Text;
                String nomservice = CBoxService2.SelectedItem.ToString();
                int idservice = 1;
                if (nomservice == "médiation culturelle")
                {
                    idservice = 2;
                }
                if (nomservice == "prêt")
                {
                    idservice = 3;
                }
                Service service = new Service(idservice, nomservice);
                personnel.Service = service;

                if (MessageBox.Show("Voulez-vous apporter des modifications à " + personnelEnCoursdeModif[0] +  " ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DialogResult = DialogResult.Yes;
                    controller.UpdatePersonnel(personnel);
                    personnelEnCoursdeModif.Clear();
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }

}

