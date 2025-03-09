using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe pour mémoriser les absences des personnels
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idpersonnel"></param>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, int idmotif, String libelle)
        {
            this.Idpersonnel = idpersonnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.IdMotif = idmotif;
            this.Libelle = libelle;
        }

        /// <summary>
        /// Getter Idpersonnel
        /// </summary>
        public int Idpersonnel { get; }

        /// <summary>
        /// Getter et setter Datedebut
        /// </summary>
        public DateTime Datedebut { get; set; }

        /// <summary>
        /// Getter et setter Datefin
        /// </summary>
        public DateTime Datefin { get; set; }

        /// <summary>
        /// Getter et setter Idmotif
        /// </summary>
        public int IdMotif { get; set; }

        /// <summary>
        /// Getter et setter Libelle
        /// </summary>
        public String Libelle {  get; set; }

        /// <summary>
        /// Définit l'information à afficher (juste la date de début et le motif)
        /// </summary>
        /// <returns>date de début, motif : Motif</returns>
        public override string ToString()
        {
            return this.Datedebut + ", motif : " + this.Libelle;
        }
    }
}
