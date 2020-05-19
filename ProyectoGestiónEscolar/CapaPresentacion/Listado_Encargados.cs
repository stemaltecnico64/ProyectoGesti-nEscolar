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
    public partial class Listado_Encargados : Form
    {
        public Listado_Encargados()
        {
            InitializeComponent();
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SEGURIDAD DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SEGURIDAD DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void OcultarColumnas()
        {
            this.dataListadoE.Columns[0].Visible = false;
            this.dataListadoE.Columns[7].Visible = false;
        }

        private void Mostrar()
        {
            this.dataListadoE.DataSource = NEncargado.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListadoE.Rows.Count);
        }

        //Método BuscarApellidos
        private void BuscarApellido()
        {
            this.dataListadoE.DataSource = NEncargado.Apellido(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListadoE.Rows.Count);
        }


        private void BuscarDPI()
        {
            this.dataListadoE.DataSource = NEncargado.Dpi(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListadoE.Rows.Count);
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listado_Encargados_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.txtBuscar.Focus();
        }

       

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("No. Dpi"))
            {
                this.BuscarDPI();
            }
            else if (cbBuscar.Text.Equals("Primer Apellido"))
            {
                this.BuscarApellido();
            }
        }

        private void TxtBuscar_OnTextChange(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("No. Dpi"))
            {
                this.BuscarDPI();
            }
            else if (cbBuscar.Text.Equals("Primer Apellido"))
            {
                this.BuscarApellido();
            }
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            if(dataListadoE.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Hide();
            }
        }
    }
}

