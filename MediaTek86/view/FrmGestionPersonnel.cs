using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek86.controller;
using MediaTek86.model;
using MediaTek86.view;

namespace MediaTek86
{
    public partial class FrmGestionPersonnel : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifResponsable = false;

        /// <summary>
        /// Objet pour gérer la liste des personnels
        /// </summary>
        private BindingSource bdgPersonnels = new BindingSource();
        /// <summary>

        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private BindingSource bdgAbsences = new BindingSource();
        /// <summary>

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmGestionPersonnelController controller;
        
        public FrmGestionPersonnel()
        {
            InitializeComponent();
            Init();
        }

        // <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmGestionPersonnelController();
            RemplirListePersonnels();
            RemplirListeAbsences();
        }
        /// <summary>
        /// Affiche les personnels
        /// </summary>
        private void RemplirListePersonnels()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            dataGridPersonnels.DataSource = bdgPersonnels;
            dataGridPersonnels.Columns["idpersonnel"].Visible = false;
        }

        /// <summary>
        /// Affiche les absences
        /// </summary>
        private void RemplirListeAbsences()
        {
            List<Absence> lesAbsences = controller.GetLesAbsences();
            bdgAbsences.DataSource = lesAbsences;
            GridViewAbsences.DataSource = bdgAbsences;
        }

        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        private void BtnPersEnregistrer_Click(object sender, EventArgs e)
        {
            if (!TxtBoxNom.Text.Equals("") && !TxtBoxPrenom.Text.Equals("") && !TextBoxTel.Text.Equals("") && !TextBoxMail.Text.Equals("") && CBoxService.SelectedIndex != -1)
            {
                if (enCoursDeModifResponsable)
                {
                    Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                    personnel.Nom = TxtBoxNom.Text;
                    personnel.Prenom = TxtBoxPrenom.Text;
                    personnel.Tel = TextBoxTel.Text;
                    personnel.Mail = TextBoxMail.Text;
                    String nomservice = CBoxService.SelectedItem.ToString();
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
                    if (MessageBox.Show("Voulez-vous apporter des modifications à " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        controller.UpdatePersonnel(personnel);
                        EffaceChampsPersonnel();
                    }
                    controller.UpdatePersonnel(personnel);
                    EffaceChampsPersonnel();
                }
                else
                {
                    String nomservice = CBoxService.SelectedItem.ToString();
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
                    Personnel personnel = new Personnel(0, TxtBoxNom.Text, TxtBoxPrenom.Text, TextBoxTel.Text, TextBoxMail.Text, service);
                    controller.AddPersonnel(personnel);
                    EffaceChampsPersonnel();
                }
                RemplirListePersonnels();
                enCoursDeModifResponsable = false;
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        ///  Demande de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridPersonnels.SelectedRows.Count > 0)
            {
                enCoursDeModifResponsable = true;
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                TxtBoxNom.Text = personnel.Nom;
                TxtBoxPrenom.Text = personnel.Prenom;
                TextBoxTel.Text = personnel.Tel;
                TextBoxMail.Text = personnel.Mail;
                CBoxService.SelectedIndex = CBoxService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande de suppression d'un développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPersSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }

        }

        public void EffaceChampsPersonnel()
        {
            TxtBoxNom.Clear(); 
            TxtBoxPrenom.Clear();
            TextBoxTel.Clear();
            TextBoxMail.Clear();
            CBoxService.SelectedIndex = -1;
        }

        private void EffacChampsPerso_Click(object sender, EventArgs e)
        {
            EffaceChampsPersonnel();
        }

        private void BtnAddPersonnel_Click(object sender, EventArgs e)
        { 
            Form addPersonnel = new AddPersonnel();
            addPersonnel.Owner = this;
            if (addPersonnel.ShowDialog() == DialogResult.OK)
            {
                RemplirListePersonnels();
            }
        }

        private void ModPersonnel_Click(object sender, EventArgs e)
        {
            Form modPersonnel = new ModPersonnel();
            modPersonnel.Owner = this;
            enCoursDeModifResponsable = true;
            
            if (modPersonnel.ShowDialog() == DialogResult.OK)
            {
                RemplirListePersonnels();
            }
        }
    }
}

