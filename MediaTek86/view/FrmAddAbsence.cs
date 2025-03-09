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
            if (CBoxMotifAbs.SelectedIndex != -1 && !(dateAbsDeb.Value.Date > dateAbsFin.Value.Date))
            {
                {
                    int Idpersonnel = idpersonnelencoursdemodif;
                    DateTime DatedeDebut = dateAbsDeb.Value.Date + TimeAbsDeb.Value.TimeOfDay;
                    DateTime DatedeFin = dateAbsFin.Value.Date + TimeAbsFin.Value.TimeOfDay;
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
                MessageBox.Show("Tous les champs doivent être remplis et la date de début doit être inférieure à la date de fin", "Information");
            }
        }
    }
    
}
