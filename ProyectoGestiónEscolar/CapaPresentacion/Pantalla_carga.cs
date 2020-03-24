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
    public partial class Pantalla_Carga : Form
    {
        public Pantalla_Carga()
        {
            InitializeComponent();
        }

        int progress = 0;

        public void fn_probar()
        {
            progress += 1;
            if (progress >= 100)
            {
                Timer_Loader.Enabled = false;
                Timer_Loader.Stop();
                this.Timer_Loader.Stop();
                this.Hide();
                Inicio ventanaInicio = new Inicio();
                ventanaInicio.Show();
            }
            else
            {
                bunifuCircleProgressbar1.Value = progress;
            }
        }

        private void Timer_Loader_Tick(object sender, EventArgs e)
        {
            fn_probar();
        }

        private void Timer_Fecha_Hora_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
