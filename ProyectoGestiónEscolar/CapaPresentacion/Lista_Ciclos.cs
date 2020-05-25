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
            this.dataListado.Columns[2].Visible = false;
        }

        private void Mostrar()
        {
            this.dataListado.DataSource = NCiclo.MostrarCicloActivos();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void Lista_Ciclos_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            Cierre_Ciclo form = Cierre_Ciclo.GetInstancia();
            string par1, par2, par3, par4, par5;
            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["Código"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["Ciclo o Año"].Value);
            par3 = Convert.ToString(this.dataListado.CurrentRow.Cells["Descripción"].Value);
            par4 = Convert.ToString(this.dataListado.CurrentRow.Cells["Fecha Generada"].Value);
            par5 = Convert.ToString(this.dataListado.CurrentRow.Cells["Estado"].Value);
            form.SetCierreCiclo(par1, par2, par3, par4, par5);
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
