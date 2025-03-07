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
    public partial class AddPersonnel : Form
    {
        public AddPersonnel()
        {
            InitializeComponent();
            controller = new FrmGestionPersonnelController();
        }

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmGestionPersonnelController controller;



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
                    controller.AddPersonnel(personnel);
                }
                DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
        
    }
    
}
