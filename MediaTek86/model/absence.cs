using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    public class Absence
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// /// <param name="personnel"></param>
        /// <param name="motif"></param>
        public Absence(DateTime datedebut, DateTime datefin, Motif motif, Personnel personnel)
        {
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.Personnel = personnel;
            this.Motif = motif;
        }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }
        public Personnel Personnel {get; set;}
        public Motif Motif { get; set;}
    }
}
