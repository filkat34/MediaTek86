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
        public Absence(DateTime datedebut, DateTime datefin)
        {
            this.Datedebut = datedebut;
            this.Datefin = datefin;
        }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }
    }
}
