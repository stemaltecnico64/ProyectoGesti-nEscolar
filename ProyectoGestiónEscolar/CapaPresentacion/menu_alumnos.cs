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
    public partial class Menu_Alumnos : Form
    {
        public Menu_Alumnos()
        {
            InitializeComponent();
            if (Login.nivel_x.Equals("3"))
            {
                bunifuImageButton1.Hide();
                label1.Hide();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Inscripcion_alumno VenAlumnos = Inscripcion_alumno.GetInstancia();
            VenAlumnos.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Listado_Alumnos ventanalistadoalumnos = new Listado_Alumnos();
            ventanalistadoalumnos.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Listado_Encargados ventanalistadoencargados = new Listado_Encargados();
            ventanalistadoencargados.Show();
        }

        private void Menu_Alumnos_Load(object sender, EventArgs e)
        {

        }
    }
}
