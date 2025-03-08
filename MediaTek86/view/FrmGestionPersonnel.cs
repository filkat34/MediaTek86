using System;
using System.Collections;
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
        
        /// <summary>
        /// Initialisation de la fenêtre de gestion du personnel
        /// </summary>
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
        /// Affiche la liste des personnels
        /// </summary>
        private void RemplirListePersonnels()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            dataGridPersonnels.DataSource = bdgPersonnels;
            dataGridPersonnels.Columns["idpersonnel"].Visible = false;
        }

        /// <summary>
        /// Affiche la liste des absences
        /// </summary>
        private void RemplirListeAbsences()
        {
            List<Absence> lesAbsences = controller.GetLesAbsences();
            bdgAbsences.DataSource = lesAbsences;
            GridViewAbsences.DataSource = bdgAbsences;
        }

        /// <summary>
        /// Demande de suppression d'un personnel
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

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddPersonnel_Click(object sender, EventArgs e)
        { 
            Form addPersonnel = new AddPersonnel();
            addPersonnel.Owner = this;
            if (addPersonnel.ShowDialog() == DialogResult.OK)
            {
                RemplirListePersonnels();
            }
        }

        /// <summary>
        /// Demande de modification d'un développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModPersonnel_Click(object sender, EventArgs e)
        {
            Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
            int idpersonnel = personnel.Idpersonnel;
            String nom = personnel.Nom;
            String prenom = personnel.Prenom;
            String tel = personnel.Tel;
            String mail = personnel.Mail;
            Service service = personnel.Service;
            Form modPersonnel = new ModPersonnel(idpersonnel, nom, prenom, tel, mail, service);
            modPersonnel.Owner = this;
            enCoursDeModifResponsable = true;

            if (modPersonnel.ShowDialog() == DialogResult.Yes)
            {
                RemplirListePersonnels();
                enCoursDeModifResponsable = false;
            }
        }
    }
}

