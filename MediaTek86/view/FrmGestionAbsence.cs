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
    public partial class FrmGestionAbsence : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifResponsable = false;

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmGestionPersonnelController controller;

        /// <summary>
        /// Variable pour sauvegarder l'identifiant du personnel en cours de modification
        /// </summary>
        public int idpersonnelencoursdemodif;

        private BindingSource bdgAbsences = new BindingSource();


        public FrmGestionAbsence(int idpersonnel, String nom, String prenom, String tel, String mail, Service service)
        {
            InitializeComponent();
            controller = new FrmGestionPersonnelController();
            idpersonnelencoursdemodif = idpersonnel;
            lbIdPersonnel.Text = prenom + " " + nom.ToUpper() + " " + "(" + service + ")";
            RemplirListeAbsences(idpersonnelencoursdemodif);
        }

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
            GridViewAbsences.Columns["idpersonnel"].Visible = false;
            GridViewAbsences.Columns["idmotif"].Visible = false;
        }

        private void CloseFrmGestAbs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddAbsence_Click(object sender, EventArgs e)
        {
            Form addAbsence = new FrmAddAbsence(idpersonnelencoursdemodif);
            addAbsence.Owner = this;
            if (addAbsence.ShowDialog() == DialogResult.OK)
            {
                RemplirListeAbsences(idpersonnelencoursdemodif);
            }
        }

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
            enCoursDeModifResponsable = true;

            if (modAbsence.ShowDialog() == DialogResult.Yes)
            {
                RemplirListeAbsences(idpersonnelencoursdemodif);
                enCoursDeModifResponsable = false;
            }
        }
    }
}
