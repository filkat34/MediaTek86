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
    /// <summary>
    /// Fenêtre d'ajout d'absence
    /// </summary>
    public partial class FrmAddAbsence : Form
    {
        /// <summary>
        /// Variable pour sauvegarder l'identifiant du personnel en cours de modification
        /// </summary>
        public int idpersonnelencoursdemodif;

        /// <summary>
        /// Liste de contrôle de doublons pour les absences
        /// </summary>
        public List<Absence> absencesPersonnelControllist = new List<Absence>();

        /// <summary>
        /// Initialisation de la fenêtre d'ajout d'absence
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="absenceslistecontrol"></param>
        public FrmAddAbsence(int idpersonnel, List<Absence> absenceslistecontrol)
        {
            InitializeComponent();
            idpersonnelencoursdemodif = idpersonnel;
            absencesPersonnelControllist = absenceslistecontrol;
            controller = new FrmGestionPersonnelController();
            dateAbsDeb.Value = DateTime.Now;
            dateAbsFin.Value = DateTime.Now;
            TimeAbsDeb.Value = DateTime.Now;
            TimeAbsFin.Value = DateTime.Now;
        }

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmGestionPersonnelController controller;

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbsEnregistrer_Click(object sender, EventArgs e)
        {
            if(CBoxMotifAbs.SelectedIndex != -1 && !((dateAbsDeb.Value.Date + TimeAbsDeb.Value.TimeOfDay) >= (dateAbsFin.Value.Date + TimeAbsFin.Value.TimeOfDay)) && !(FrmGestionAbsence.GetChevauchementAbs((dateAbsDeb.Value.Date + TimeAbsDeb.Value.TimeOfDay), (dateAbsFin.Value.Date + TimeAbsFin.Value.TimeOfDay), absencesPersonnelControllist)))
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
                DialogResult = DialogResult.OK;
            }
            if (CBoxMotifAbs.SelectedIndex == -1 || ((dateAbsDeb.Value.Date + TimeAbsDeb.Value.TimeOfDay) >= (dateAbsFin.Value.Date + TimeAbsFin.Value.TimeOfDay)) || FrmGestionAbsence.GetChevauchementAbs((dateAbsDeb.Value.Date + TimeAbsDeb.Value.TimeOfDay), (dateAbsFin.Value.Date + TimeAbsFin.Value.TimeOfDay), absencesPersonnelControllist))
            {
                String message = "";
                if (CBoxMotifAbs.SelectedIndex == -1)
                {
                    message = "Tous les champs doivent être remplis. ";
                }
                if ((dateAbsDeb.Value.Date + TimeAbsDeb.Value.TimeOfDay) >= (dateAbsFin.Value.Date + TimeAbsFin.Value.TimeOfDay))
                {
                    message += "La date de début doit être antérieure à la date de fin. ";
                }
                if (FrmGestionAbsence.GetChevauchementAbs((dateAbsDeb.Value.Date + TimeAbsDeb.Value.TimeOfDay), (dateAbsFin.Value.Date + TimeAbsFin.Value.TimeOfDay), absencesPersonnelControllist))
                {
                    message += "Une absence a déjà été programmée sur cette période.";
                }
                MessageBox.Show(message, "Information");
            }
        }
    }
}
