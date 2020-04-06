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
    public partial class Menu_Usuarios : Form
    {
        public Menu_Usuarios()
        {
            InitializeComponent();
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            Ingresar_Usuario ventanaUsuario = new Ingresar_Usuario();
            ventanaUsuario.Show();
        }

        private void Btn_All_Users_Click(object sender, EventArgs e)
        {
            Listado_Usuarios listausuarios = new Listado_Usuarios();
            listausuarios.Show();
        }
    }
}
