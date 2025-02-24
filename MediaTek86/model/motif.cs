﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    public class motif
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public motif(int idmotif, String libelle)
        {
            this.IdMotif = idmotif;
            this.Libelle = libelle;
        }
        public int IdMotif { get; }
        public String Libelle { get; set; }
    }
}
