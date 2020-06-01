using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
namespace CapaPresentacion
{
    public partial class Lista_Ciclos : Form
    {
        public Lista_Ciclos()
        {
            InitializeComponent();
        }

        private void OcultarColumnas()
        {
            
        }

        private void Mostrar()
        {
            this.dataListadoCi.DataSource = NCiclo.MostrarCicloActivos();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListadoCi.Rows.Count);
        }
        private void Lista_Ciclos_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            if (dataListadoCi.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
