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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            menu_inicio1.BringToFront();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            menu_alumnos1.BringToFront();
            lblTitle.Text = "ALUMNOS";
        }

        private void btn_alumnos_Click(object sender, EventArgs e)
        {
            menu_inicio1.BringToFront();
            lblTitle.Text = "INICIO";
        }
    }
}
