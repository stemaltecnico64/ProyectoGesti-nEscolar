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
    public partial class Menu_Reportes : Form
    {
        public Menu_Reportes()
        {
            InitializeComponent();
            if (Login.nivel_x.Equals("3"))
            {
                btn_asistencia_empleados.Hide();
                label4.Hide();
                btn_asistencia_alumnos.Hide();
                label2.Hide();
                btn_lista_curso.Hide();
                label5.Hide();
                bunifuImageButton1.Hide();
                label6.Hide();
                Btn_All_Users.Hide();
                label3.Hide();
            }
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            Reporte_Notas_Admin rn = new Reporte_Notas_Admin();
            rn.Show();
        }

        private void btn_asistencia_empleados_Click(object sender, EventArgs e)
        {
            Reporte_Asistencia_Empleados ram = new Reporte_Asistencia_Empleados();
            ram.Show();
        }

        private void Btn_All_Users_Click(object sender, EventArgs e)
        {
            Reporte_Empleados_Puesto rep = new Reporte_Empleados_Puesto();
            rep.Show();
        }

        private void btn_asistencia_alumnos_Click(object sender, EventArgs e)
        {
            Reporte_Asistencia_Alumnos raa = new Reporte_Asistencia_Alumnos();
            raa.Show();
        }

        private void btn_lista_curso_Click(object sender, EventArgs e)
        {
            Reporte_Maestros_Cursos rmc = new Reporte_Maestros_Cursos();
            rmc.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Reporte_Inscripciones_By_year rib = new Reporte_Inscripciones_By_year();
            rib.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
