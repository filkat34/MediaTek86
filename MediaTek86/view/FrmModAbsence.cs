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
    /// <summary>
    /// Fenêtre de modification d'une absence
    /// </summary>
    public partial class FrmModAbsence : Form
    {

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private readonly FrmGestionPersonnelController controller;

        /// <summary>
        /// Liste des absences pouvant être modifiées
        /// </summary>
        public List<Absence> absencesamodifier = new List<Absence>();

        /// <summary>
        /// Liste des absences pouvant êtres modifiées sans celle en cours de modification
        /// pour éviter de déclecher l'alerte de chevauchement par rappory à l'absence déjà enregistrée
        /// </summary>
        public List<Absence> absencessansabsencoursdemodif = new List<Absence>();

        /// <summary>
        /// Variable pour sauvegarder l'identifiant du personnel en cours de modification
        /// </summary>
        public int idpersonnelencoursdemodif;

        /// <summary>
        /// Création d'une liste pour sauvegarder les informations de l'absence en cours de modification
        /// </summary>
        public List<Absence> absEnCoursdeModif = new List<Absence>();

        /// <summary>
        /// Initialisation de la fenêtre et du contrôleur
        /// Remplissage des champs avec les informations de l'absence en cours de modification
        /// Sauvegarde de l'absence avant modification pour affichage lors de la confirmation de modification
        /// Remplissage d'une liste avec les absences sans celle en cours de modification
        /// </summary>
        /// <param name="Idpersonnel"></param>
        /// <param name="Datedebut"></param>
        /// <param name="Datefin"></param>
        /// <param name="IdMotif"></param>
        /// <param name="Libelle"></param>
        /// <param name="absenceslistecontrol"></param>
        public FrmModAbsence(int Idpersonnel, DateTime Datedebut, DateTime Datefin, int IdMotif, String Libelle, List<Absence> absenceslistecontrol)
        {
            InitializeComponent();
            controller = new FrmGestionPersonnelController();
            absencesamodifier = absenceslistecontrol;
            foreach (Absence absence in absenceslistecontrol)
            {
                absencessansabsencoursdemodif.Add(absence);
            }
            absencessansabsencoursdemodif.Remove(absencessansabsencoursdemodif.Find(abs => abs.Idpersonnel == Idpersonnel && abs.Datedebut == Datedebut && abs.Datefin == Datefin && abs.IdMotif == IdMotif && abs.Libelle == Libelle));
            idpersonnelencoursdemodif = Idpersonnel;
            dateAbsDeb.Value = Datedebut;
            TimeAbsDeb.Value = Datedebut;
            dateAbsFin.Value = Datefin;
            TimeAbsFin.Value = Datefin;
            CBoxMotifAbs.SelectedIndex = CBoxMotifAbs.FindStringExact(Libelle);
            absEnCoursdeModif.Add(new Absence(Idpersonnel, Datedebut, Datefin, IdMotif, Libelle));
        }

        /// <summary>
        /// Demande d'enregistrement des modifications apportées à l'absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbsEnregistrerModif_Click(object sender, EventArgs e)
        {
            if (CBoxMotifAbs.SelectedIndex != -1 && !((dateAbsDeb.Value.Date + TimeAbsDeb.Value.TimeOfDay) >= (dateAbsFin.Value.Date + TimeAbsFin.Value.TimeOfDay)) && !(FrmGestionAbsence.GetChevauchementAbs((dateAbsDeb.Value.Date + TimeAbsDeb.Value.TimeOfDay), (dateAbsFin.Value.Date + TimeAbsFin.Value.TimeOfDay), absencessansabsencoursdemodif)))
            {
                int Idpersonnel = idpersonnelencoursdemodif;
                DateTime AncienneDateDebut = absEnCoursdeModif[0].Datedebut;
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

                if (MessageBox.Show("Voulez-vous apporter des modifications à l'absence du " + absEnCoursdeModif[0] + " ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DialogResult = DialogResult.Yes;
                    controller.UpdateAbsence(absence, AncienneDateDebut);
                    absEnCoursdeModif.Clear();
                }
            }
            if (CBoxMotifAbs.SelectedIndex == -1 || ((dateAbsDeb.Value.Date + TimeAbsDeb.Value.TimeOfDay) >= (dateAbsFin.Value.Date + TimeAbsFin.Value.TimeOfDay)) || FrmGestionAbsence.GetChevauchementAbs((dateAbsDeb.Value.Date + TimeAbsDeb.Value.TimeOfDay), (dateAbsFin.Value.Date + TimeAbsFin.Value.TimeOfDay), absencessansabsencoursdemodif))
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
                if (FrmGestionAbsence.GetChevauchementAbs((dateAbsDeb.Value.Date + TimeAbsDeb.Value.TimeOfDay), (dateAbsFin.Value.Date + TimeAbsFin.Value.TimeOfDay), absencessansabsencoursdemodif))
                {
                    message += "Une absence a déjà été programmée sur cette période.";
                }
                MessageBox.Show(message, "Information");
            }
        }
    }
}
