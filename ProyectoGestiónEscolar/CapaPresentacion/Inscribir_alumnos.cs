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
    public partial class Inscribir_alumnos : Form
    {
        public Inscribir_alumnos()
        {
            InitializeComponent();
        }

        private void btn_agregar_encargado_Click(object sender, EventArgs e)
        {
            Ingresar_Encargado ventanEncargado = new Ingresar_Encargado();
            ventanEncargado.Show();
        }
    }
}
