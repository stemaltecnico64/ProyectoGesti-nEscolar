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
            
            progress += 5;
            
            if (Login.nivel_x.Equals("1"))
            {
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

            else if (Login.nivel_x.Equals("2"))
            {
                if (progress >= 100)
                {
                    Timer_Loader.Enabled = false;
                    Timer_Loader.Stop();
                    this.Timer_Loader.Stop();
                    this.Hide();
                    Inicio_Director ventanaInicioD = new Inicio_Director();
                    ventanaInicioD.Show();
                }
                else
                {
                    bunifuCircleProgressbar1.Value = progress;
                }
            }

            else if (Login.nivel_x.Equals("3"))
            {
                if (progress >= 100)
                {
                    Timer_Loader.Enabled = false;
                    Timer_Loader.Stop();
                    this.Timer_Loader.Stop();
                    this.Hide();
                    Inicio_Maestro ventanaInicioM = new Inicio_Maestro();
                    ventanaInicioM.Show();
                }
                else
                {
                    bunifuCircleProgressbar1.Value = progress;
                }
            }
            else if (Login.nivel_x.Equals("4"))
            {
                if (progress >= 100)
                {
                    Timer_Loader.Enabled = false;
                    Timer_Loader.Stop();
                    this.Timer_Loader.Stop();
                    this.Hide();
                    Inicio_Secretarios ventanaInicioS = new Inicio_Secretarios();
                    ventanaInicioS.Show();
                }
                else
                {
                    bunifuCircleProgressbar1.Value = progress;
                }
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

        private void Pantalla_Carga_Load(object sender, EventArgs e)
        {

        }
    }
}
