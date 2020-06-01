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
    public partial class Menu_Mantenimiento : Form
    {
        public Menu_Mantenimiento()
        {
            InitializeComponent();
            if (Login.nivel_x.Equals("4"))
            {
                btn_Usuario.Hide();
                label3.Hide();
            }
        }

            private void btn_Usuario_Click(object sender, EventArgs e)
        {
            Editar_Usuario eu = new Editar_Usuario();
            eu.Show();
        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
            Editar_Empleado ee = new Editar_Empleado();
            ee.Show();
        }

        private void btn_alumno_Click(object sender, EventArgs e)
        {
            Editar_Alumno ea = new Editar_Alumno();
            ea.Show();
        }

        private void btn_Encargado_Click(object sender, EventArgs e)
        {
            Editar_Encargado ee = new Editar_Encargado();
            ee.Show();
        }
    }
}
