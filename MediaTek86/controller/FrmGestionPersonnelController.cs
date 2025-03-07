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

        // <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
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

        // <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet developpeur à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            responsableAccess.DelPersonnel(personnel);
        }

        public List<Absence> GetLesAbsences()
        {
            return responsableAccess.GetLesAbsences();
        }

    }
}
