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
            if (Login.nivel_x.Equals("3"))
            {
                btn_asistencia_empleados.Hide();
                label4.Hide();
            }
            else if (Login.nivel_x.Equals("4"))
            {
                btn_asistencia_alumnos.Hide();
                label1.Hide();
            }
        }

        private void btn_asistencia_alumnos_Click(object sender, EventArgs e)
        {
            Ingresar_Asistencia_Alumnos ia = new Ingresar_Asistencia_Alumnos();
            ia.Show();
        }

        private void btn_asistencia_empleados_Click(object sender, EventArgs e)
        {
            Ingresar_Asistencia_Empleados iae = new Ingresar_Asistencia_Empleados();
            iae.Show();
        }
    }
}
