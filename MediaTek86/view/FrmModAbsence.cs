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

namespace MediaTek86.view
{
    public partial class FrmModAbsence : Form
    {

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmGestionPersonnelController controller;


        /// <summary>
        /// Variable pour sauvegarder l'identifiant du personnel en cours de modification
        /// </summary>
        public int idpersonnelencoursdemodif;

        /// <summary>
        /// Création d'une liste pour sauvegarder les informations de l'absence en cours de modification
        /// </summary>
        public List<Absence> absEnCoursdeModif = new List<Absence>();


        public FrmModAbsence(int Idpersonnel, DateTime Datedebut, DateTime Datefin, int IdMotif, String Libelle)
        {
            InitializeComponent();
            controller = new FrmGestionPersonnelController();
            idpersonnelencoursdemodif = Idpersonnel;
            dateAbsDeb.Value = Datedebut;
            TimeAbsDeb.Value = Datedebut;
            dateAbsFin.Value = Datefin;
            TimeAbsFin.Value = Datefin;
            CBoxMotifAbs.SelectedIndex = CBoxMotifAbs.FindStringExact(Libelle);

            ///Sauvegarde de l'absence avant modification pour affichage lors de la confirmation de modification
            absEnCoursdeModif.Add(new Absence(Idpersonnel, Datedebut, Datefin, IdMotif, Libelle));

            ///Création d'un objet absence pour sauvegarder les modifications apportées
            absEnCoursdeModif.Add(new Absence(Idpersonnel, Datedebut, Datefin, IdMotif, Libelle));
        }

        private void BtnAbsEnregistrerModif_Click(object sender, EventArgs e)
        {
            if (CBoxMotifAbs.SelectedIndex != -1 && !(dateAbsDeb.Value.Date > dateAbsFin.Value.Date))
                {
                    int Idpersonnel = idpersonnelencoursdemodif;
                    DateTime AncienneDateDebut = absEnCoursdeModif[1].Datedebut;
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

                    if (MessageBox.Show("Voulez-vous apporter des modifications à l'absence du " + absEnCoursdeModif[1] + " ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DialogResult = DialogResult.Yes;
                        controller.UpdateAbsence(absence, AncienneDateDebut);
                        absEnCoursdeModif.Clear();
                    }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis et la date de début doit être inférieure à la date de fin", "Information");
            }
        }
    }
}
