using MediaTek86.model;
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
using MediaTek86.view;
using System.Runtime.CompilerServices;

namespace MediaTek86.view
{
    /// <summary>
    /// Fenêtre d'ajout d'un personnel
    /// </summary>
    public partial class FrmAddPersonnel : Form
    {
        /// <summary>
        /// Initialisation de la fenêtre d'ajout du personnel
        /// </summary>
        public FrmAddPersonnel(List <Personnel> personnels)
        {
            InitializeComponent();
            controller = new FrmGestionPersonnelController();
            lespersonnels = personnels;
        }

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmGestionPersonnelController controller;
        
        /// <summary>
        /// Liste des personnels
        /// </summary>
        List <Personnel> lespersonnels = new List <Personnel>();

        /// <summary>
        /// Demande d'ajout du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPersEnregistrer_Click(object sender, EventArgs e)
        {
            if (!TxtBoxNom1.Text.Equals("") && !TxtBoxPrenom1.Text.Equals("") && !TextBoxTel1.Text.Equals("") && !TextBoxMail1.Text.Equals("") && CBoxService1.SelectedIndex != -1)
            {
                {
                    String nomservice = CBoxService1.SelectedItem.ToString();
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
                    Personnel personnel = new Personnel(0, TxtBoxNom1.Text, TxtBoxPrenom1.Text, TextBoxTel1.Text, TextBoxMail1.Text, service);
                    int compteurdoublon = 0;
                    foreach (Personnel unpersonnel in lespersonnels)
                    {
                        if (unpersonnel.Nom.ToUpper() == TxtBoxNom1.Text.ToUpper() && unpersonnel.Prenom.ToUpper() == TxtBoxPrenom1.Text.ToUpper())
                        {
                            compteurdoublon++;
                        }
                    }
                    if (compteurdoublon > 0)
                    {
                       if (MessageBox.Show("Un personnel ayant les mêmes nom et prénom est déjà présent dans la base. Voulez-vous vraiment ajouter " + personnel.Nom.ToUpper() + " " + personnel.Prenom + " ?", "Confirmation d'ajout", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            controller.AddPersonnel(personnel);
                            DialogResult = DialogResult.OK;
                        }
                    }
                    if (compteurdoublon == 0)
                    {
                        controller.AddPersonnel(personnel);
                        DialogResult = DialogResult.OK;
                    }
                }

            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}
