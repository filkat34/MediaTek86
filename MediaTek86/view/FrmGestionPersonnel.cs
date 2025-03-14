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


namespace MediaTek86.view
{
    /// <summary>
    /// Fenêtre de gestion du personnel
    /// </summary>
    public partial class FrmGestionPersonnel : Form
    {
        /// <summary>
        /// Objet pour gérer la liste des personnels
        /// </summary>
        private BindingSource bdgPersonnels = new BindingSource();

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmGestionPersonnelController controller;

        /// <summary>
        /// Liste de sauvegarde des personnels
        /// </summary>
        List<Personnel> lesPersonnels = new List<Personnel>();
        
        /// <summary>
        /// Initialisation de la fenêtre de gestion du personnel
        /// </summary>
        public FrmGestionPersonnel()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmGestionPersonnelController();
            RemplirListePersonnels();
        }

        /// <summary>
        /// Affiche la liste des personnels
        /// </summary>
        private void RemplirListePersonnels()
        {
            lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            dataGridPersonnels.DataSource = bdgPersonnels;
            dataGridPersonnels.Columns["idpersonnel"].Visible = false;
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
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom.ToUpper() + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            Form addPersonnel = new FrmAddPersonnel(lesPersonnels);
            addPersonnel.Owner = this;
            if (addPersonnel.ShowDialog() == DialogResult.OK)
            {
                RemplirListePersonnels();
            }
        }

        /// <summary>
        /// Demande de modification d'un personnel
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
            Form modPersonnel = new FrmModPersonnel(idpersonnel, nom, prenom, tel, mail, service);
            modPersonnel.Owner = this;

            if (modPersonnel.ShowDialog() == DialogResult.Yes)
            {
                RemplirListePersonnels();
            }
        }

        /// <summary>
        /// Affiche les absences du personnel sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowAbsences_Click(object sender, EventArgs e)
        {
            if (dataGridPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                int idpersonnel = personnel.Idpersonnel;
                String nom = personnel.Nom;
                String prenom = personnel.Prenom;
                String tel = personnel.Tel;
                String mail = personnel.Mail;
                Service service = personnel.Service;
                Form afficheabsences = new FrmGestionAbsence(idpersonnel, nom, prenom, tel, mail, service);
                afficheabsences.Owner = this;
                afficheabsences.ShowDialog();
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
    }
    
}

