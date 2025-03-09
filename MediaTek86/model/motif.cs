using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    public class Motif
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, String libelle)
        {
            this.IdMotif = idmotif;
            this.Libelle = libelle;
        }

        /// <summary>
        /// Getter de IdMotif
        /// </summary>
        public int IdMotif { get; }

        /// <summary>
        /// Getter de Libelle
        /// </summary>
        public String Libelle { get; set; }

        /// <summary>
        /// Paramètre d'affichage de l'objet motif
        /// </summary>
        /// <returns>motif</returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
