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
    public partial class Asistencia_Alumnos : Form
    {
        public Asistencia_Alumnos()
        {
            InitializeComponent();
        }

        private void Timer_Fecha_Hora_Tick(object sender, EventArgs e)
        {
            label_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
