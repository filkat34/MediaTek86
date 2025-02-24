using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    public class service
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public service(int idservice, String nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }
        public int Idservice { get; }
        public String Nom { get; set; }
    }
}
