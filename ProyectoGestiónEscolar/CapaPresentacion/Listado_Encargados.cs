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
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[7].Visible = false;
        }

        private void Mostrar()
        {
            this.dataListado.DataSource = NEncargado.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarApellidos
        private void BuscarApellido()
        {
            this.dataListado.DataSource = NEncargado.Apellido(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }


        private void BuscarDPI()
        {
            this.dataListado.DataSource = NEncargado.Dpi(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
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
            Ingresar_Alumno from = Ingresar_Alumno.GetInstancia();
            string a, b, c, d;
            a = Convert.ToString(this.dataListado.CurrentRow.Cells["Id_Encargado"].Value);
            b = Convert.ToString(this.dataListado.CurrentRow.Cells["DPI"].Value);
            c = Convert.ToString(this.dataListado.CurrentRow.Cells["Primer Nombre"].Value);
            d = Convert.ToString(this.dataListado.CurrentRow.Cells["Primer Apellido"].Value);
            from.SetEncargado(a, b, c, d);
            this.Hide();
        }
    }
}

