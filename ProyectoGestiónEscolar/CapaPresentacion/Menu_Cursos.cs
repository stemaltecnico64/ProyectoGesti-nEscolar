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
    public partial class Menu_Cursos : Form
    {
        public Menu_Cursos()
        {
            InitializeComponent();
        }

        private void btn_Crear_Curso_Click(object sender, EventArgs e)
        {
            Cursos_Pensum cp = new Cursos_Pensum();
            cp.Show();
        }

        private void btn_lista_curso_Click(object sender, EventArgs e)
        {
            Listado_Cursos lc = new Listado_Cursos();
            lc.Show();
        }

        private void Btn_AsignacionE_Click(object sender, EventArgs e)
        {
            Crear_Asignacion_Alumnos_Cursos cac = new Crear_Asignacion_Alumnos_Cursos();
            cac.Show();
        }
    }
}
