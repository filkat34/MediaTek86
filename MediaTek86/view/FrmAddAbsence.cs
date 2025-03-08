﻿using MediaTek86.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.view
{
    public partial class FrmAddAbsence : Form
    {
        public FrmAddAbsence()
        {
            InitializeComponent();
            controller = new FrmGestionPersonnelController();
        }

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmGestionPersonnelController controller;
    }
}
