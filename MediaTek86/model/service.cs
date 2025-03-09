using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe pour mémoriser les services des personnels
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, String nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }

        /// <summary>
        /// Getter et setter de Idservice
        /// </summary>
        public int Idservice { get; set; }

        /// <summary>
        /// Getter et setter de Nom
        /// </summary>
        public String Nom { get; set; }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du service</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
