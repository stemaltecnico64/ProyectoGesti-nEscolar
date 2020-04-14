using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Inscripcion_alumno : Form
    {
        public Inscripcion_alumno()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevo_alumno_Click(object sender, EventArgs e)
        {
            Ingresar_Alumno ventanalumno =  Ingresar_Alumno.GetInstancia();
            ventanalumno.Show();
        }
    }
}
