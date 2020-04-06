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
    public partial class Menu_Empleados : Form
    {
        public Menu_Empleados()
        {
            InitializeComponent();
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            Ingresar_Empleado ventanaEmpleado = new Ingresar_Empleado();
            ventanaEmpleado.Show();
        }

        private void Btn_All_Users_Click(object sender, EventArgs e)
        {
            Listado_Empleados ventanalistadoempleados = new Listado_Empleados();
            ventanalistadoempleados.Show();
        }
    }
}
