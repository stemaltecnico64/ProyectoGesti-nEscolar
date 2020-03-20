using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGestiónEscolar
{
    public partial class Inscribir_alumnos : Form
    {
        public Inscribir_alumnos()
        {
            InitializeComponent();
        }

        private void Inscribir_alumnos_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox9_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox10_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox12_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_agregar_encargado_Click(object sender, EventArgs e)
        {
            Ingresar_Encargado ventanEncargado = new Ingresar_Encargado();
            ventanEncargado.Show();
        }
    }
}
