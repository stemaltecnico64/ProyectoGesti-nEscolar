﻿using System;
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
            Ingresar_Empleado ventanaEmpleado =  Ingresar_Empleado.GetInstancia();
            ventanaEmpleado.Show();
        }

        private void Btn_All_Users_Click(object sender, EventArgs e)
        {
            Listado_Empleados ventanalistadoempleados = new Listado_Empleados();
            ventanalistadoempleados.Show();
        }

        private void Menu_Empleados_Load(object sender, EventArgs e)
        {

        }
        private void btn_asignar_Click(object sender, EventArgs e)
        {
            Crear_Asignacion_Cursos cac = new Crear_Asignacion_Cursos();
            cac.Show();
        }

        private void btn_listado_C_asignados_Click(object sender, EventArgs e)
        {
            Listado_Cursos_Asignados lc = new Listado_Cursos_Asignados();
            lc.Show();
        }
    }
}
