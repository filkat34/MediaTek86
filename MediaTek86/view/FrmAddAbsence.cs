using MediaTek86.controller;
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
using System.Windows.Forms.Design;

namespace MediaTek86.view
{
    public partial class FrmAddAbsence : Form
    {
        /// <summary>
        /// Variable pour sauvegarder l'identifiant du personnel en cours de modification
        /// </summary>
        public int idpersonnelencoursdemodif;

        public FrmAddAbsence(int idpersonnel)
        {
            InitializeComponent();
            idpersonnelencoursdemodif = idpersonnel;
            controller = new FrmGestionPersonnelController();
        }

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmGestionPersonnelController controller;

        private void BtnAbsEnregistrer_Click(object sender, EventArgs e)
        {
            if (CBoxMotifAbs.SelectedIndex != -1)
            {
                {
                    int Idpersonnel = idpersonnelencoursdemodif;
                    DateTime DatedeDebut = dateAbsDeb.Value;
                    DateTime DatedeFin = dateAbsFin.Value;
                    String Libelle = CBoxMotifAbs.SelectedItem.ToString();
                    int IdMotif = 1;
                    if (Libelle == "maladie")
                    {
                        IdMotif = 2;
                    }
                    if (Libelle == "motif familial")
                    {
                        IdMotif = 3;
                    }
                    if (Libelle == "congé parental")
                    {
                        IdMotif = 4;
                    }
                    Absence absence = new Absence(Idpersonnel, DatedeDebut, DatedeFin, IdMotif, Libelle);
                    controller.AddAbsence(absence);
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
