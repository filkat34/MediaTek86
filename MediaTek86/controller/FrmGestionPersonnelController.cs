using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.dal;
using MediaTek86.model;

namespace MediaTek86.controller
{
    /// <summary>
    /// Contrôleur de FrmGestionPersonnel
    /// </summary>
    public class FrmGestionPersonnelController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Responsable
        /// </summary>
        private readonly ResponsableAccess responsableAccess;

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmGestionPersonnelController()
        {
            responsableAccess = new ResponsableAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos sur les personnels
        /// </summary>
        /// <returns>liste des développeurs</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return responsableAccess.GetLesPersonnels();
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// <param name="personnel">objet personnel à ajouter</param>
        /// </summary>
        public void AddPersonnel(Personnel personnel)
        {
            responsableAccess.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            responsableAccess.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            responsableAccess.DelPersonnel(personnel);
        }

        /// <summary>
        /// Récupère toutes les absences
        /// </summary>
        /// <returns></returns>
        public List<Absence> GetLesAbsences()
        {
            return responsableAccess.GetLesAbsences();
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void AddAbsence(Absence absence)
        {
            responsableAccess.AddAbsence(absence);
        }

        /// <summary>
        /// Demande de suppresiion d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void SupprAbsence(Absence absence)
        {
            responsableAccess.SupprAbsence(absence);
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="anciennedate"></param>
        public void UpdateAbsence(Absence absence, DateTime anciennedate)
        {
            responsableAccess.UpdateAbsence(absence, anciennedate);
        }
    }
}
