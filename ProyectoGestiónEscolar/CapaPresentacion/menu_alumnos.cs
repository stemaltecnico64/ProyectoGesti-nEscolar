﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class menu_alumnos : UserControl
    {
        public menu_alumnos()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Inscripcion_alumno VenAlumnos = new Inscripcion_alumno();
            VenAlumnos.Show();
        }
    }
}
