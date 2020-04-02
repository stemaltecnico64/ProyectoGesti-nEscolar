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
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Inscripcion_alumno VenAlumnos = new Inscripcion_alumno();
            VenAlumnos.Show();
        }
    }
}
