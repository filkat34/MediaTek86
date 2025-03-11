using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe pour mémoriser les informations sur les personnels
    /// </summary>
    public class Personnel
    {/// <summary>
     /// Valorise les propriétés
     /// </summary>
     /// <param name="idpersonnel"></param>
     /// <param name="nom"></param>
     /// <param name="prenom"></param>
     /// <param name="tel"></param>
     /// <param name="mail"></param>
     /// <param name="service"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Service service)
        {
            this.Idpersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }

        /// <summary>
        /// Getter Idpersonnel
        /// </summary>
        public int Idpersonnel { get; }

        /// <summary>
        /// Getter et setter Nom
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Getter et setter Prenom
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Getter et setter Tel
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Getter et setter Mail
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Getter et setter service
        /// </summary>
        public Service Service { get; set; }

        /// <summary>
        /// Définit l'information à afficher (juste le nom et le prénom)
        /// </summary>
        /// <returns>NOM Prénom</returns>
        public override string ToString()
        {
            return this.Nom.ToUpper() + " " + this.Prenom;
        }
    }
}
