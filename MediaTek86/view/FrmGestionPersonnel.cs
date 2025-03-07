using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek86.controller;
using MediaTek86.model;

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
                    personnel.Service = (Service)CBoxService.SelectedItem;
                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, TxtBoxNom.Text, TxtBoxPrenom.Text, TextBoxTel.Text, TextBoxMail.Text, (Service)CBoxService.SelectedItem);
                    controller.AddPersonnel(personnel);
                }
                RemplirListePersonnels();
                enCoursDeModifResponsable = false;
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
    }

