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

namespace MediaTek86.view
{
    /// <summary>
    /// Fenêtre de gestion des absences du personnel
    /// </summary>
    public partial class FrmGestionAbsence : Form
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
        /// Objet pour gérer la liste des absences
        /// </summary>
        private BindingSource bdgAbsences = new BindingSource();

        /// <summary>
        /// Initialisation de la fenêtre et du contrôleur
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="service"></param>
        public FrmGestionAbsence(int idpersonnel, String nom, String prenom, String tel, String mail, Service service)
        {
            InitializeComponent();
            controller = new FrmGestionPersonnelController();
            idpersonnelencoursdemodif = idpersonnel;
            lbIdPersonnel.Text = prenom + " " + nom.ToUpper() + " " + "(" + service + ")";
            RemplirListeAbsences(idpersonnelencoursdemodif);
        }

        /// <summary>
        /// Affiche la liste des absences
        /// </summary>
        /// <param name="idpersonnel"></param>
        private void RemplirListeAbsences(int idpersonnel)
        {
            List<Absence> lesAbsences = controller.GetLesAbsences();
            List<Absence> absencesPersonnel = new List<Absence>();
            foreach(Absence absence in lesAbsences)
            {
                if (absence.Idpersonnel == idpersonnel)
                {
                    absencesPersonnel.Add(absence);
                }
            }
            bdgAbsences.DataSource = absencesPersonnel;
            GridViewAbsences.DataSource = bdgAbsences;
            GridViewAbsences.Columns[1].HeaderText = "Début";
            GridViewAbsences.Columns[2].HeaderText = "Fin";
            GridViewAbsences.Columns[4].HeaderText = "Motif";
            GridViewAbsences.Columns["idpersonnel"].Visible = false;
            GridViewAbsences.Columns["idmotif"].Visible = false;
        }

        /// <summary>
        /// Ferme la fenêtre de gestion des absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseFrmGestAbs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddAbsence_Click(object sender, EventArgs e)
        {
            Form addAbsence = new FrmAddAbsence(idpersonnelencoursdemodif);
            addAbsence.Owner = this;
            if (addAbsence.ShowDialog() == DialogResult.OK)
            {
                RemplirListeAbsences(idpersonnelencoursdemodif);
            }
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSupprAbsence_Click(object sender, EventArgs e)
        {
            if (GridViewAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer l'absence au motif de " + absence.Libelle + " du " + absence.Datedebut + " au " + absence.Datefin + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.SupprAbsence(absence);
                    RemplirListeAbsences(idpersonnelencoursdemodif);
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbsModif_Click(object sender, EventArgs e)
        {
            Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
            int Idpersonnel = absence.Idpersonnel;
            DateTime Datedebut = absence.Datedebut;
            DateTime Datefin = absence.Datefin;
            int IdMotif = absence.IdMotif;
            String Libelle = absence.Libelle;
            Form modAbsence = new FrmModAbsence(Idpersonnel, Datedebut, Datefin, IdMotif, Libelle);
            modAbsence.Owner = this;

            if (modAbsence.ShowDialog() == DialogResult.Yes)
            {
                RemplirListeAbsences(idpersonnelencoursdemodif);
            }
        }
    }
}
