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
            int idpersonnelencoursdemodif = idpersonnel;
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
            Form addAbsence = new FrmAddAbsence();
            addAbsence.Owner = this;
            if (addAbsence.ShowDialog() == DialogResult.OK)
            {
                RemplirListeAbsences(idpersonnelencoursdemodif);
            }
        }
    }
}
