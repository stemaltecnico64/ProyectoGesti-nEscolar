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
    public partial class Menu_Asistencia : Form
    {
        public Menu_Asistencia()
        {
            InitializeComponent();
        }
        private void btn_inasistencia_alumnos_Click(object sender, EventArgs e)
        {
            Inacistencia_Alumnos ventanainaalumnos = new Inacistencia_Alumnos();
            ventanainaalumnos.Show();
        }

        private void btn_inasistencia_empleados_Click(object sender, EventArgs e)
        {
            Inasistencia_Empleados ventanainaempleados = new Inasistencia_Empleados();
            ventanainaempleados.Show();
        }

        private void btn_asistencia_empleados_Click(object sender, EventArgs e)
        {
            Asistencias_Empleados ventanaasisempleados = new Asistencias_Empleados();
            ventanaasisempleados.Show();
        }

        private void btn_asistencia_alumnos_Click(object sender, EventArgs e)
        {
            Asistencia_Alumnos ventanaasisalumnos = new Asistencia_Alumnos();
            ventanaasisalumnos.Show();
        }
    }
}
