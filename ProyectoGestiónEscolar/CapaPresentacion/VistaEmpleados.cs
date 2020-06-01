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
    public partial class VistaEmpleados : Form
    {
        public VistaEmpleados()
        {
            InitializeComponent();
        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns[4].Visible = false;
            this.dataListado.Columns[7].Visible = false;
            this.dataListado.Columns[10].Visible = false;
            this.dataListado.Columns[11].Visible = false;
            this.dataListado.Columns[13].Visible = false;
            this.dataListado.Columns[14].Visible = false;
        }

        private void Mostrar()
        {
            this.dataListado.DataSource = NEmpleado.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void BuscarApellido()
        {
            this.dataListado.DataSource = NEmpleado.Apellido(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NEmpleado.Nombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void BuscarDPI()
        {
            this.dataListado.DataSource = NEmpleado.dpi(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void VistaEmpleados_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.txtBuscar.Focus();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Primer Apellido"))
            {
                this.BuscarApellido();
            }
            if (cbBuscar.Text.Equals("Primer Nombre"))
            {
                this.BuscarNombre();
            }
            if (cbBuscar.Text.Equals("No. DPI"))
            {
                this.BuscarDPI();
            }
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            Ingresar_Empleado form = Ingresar_Empleado.GetInstancia();
            Image par15;

            string par1, par2, par3, par4, par5, par6, par7, par8, par9, par10, par11, par12, par13, par14, par16, par17, par18, par19, par20, par21;
            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["Código"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["Dpi"].Value);
            par3 = Convert.ToString(this.dataListado.CurrentRow.Cells["Primer Nombre"].Value);
            par4 = Convert.ToString(this.dataListado.CurrentRow.Cells["Segundo Nombre"].Value);
            par5 = Convert.ToString(this.dataListado.CurrentRow.Cells["Tercer Nombre"].Value);
            par6 = Convert.ToString(this.dataListado.CurrentRow.Cells["Primer Apellido"].Value);
            par7 = Convert.ToString(this.dataListado.CurrentRow.Cells["Segundo Apellido"].Value);
            par8 = Convert.ToString(this.dataListado.CurrentRow.Cells["Tercer Apellido"].Value);
            par9 = Convert.ToString(this.dataListado.CurrentRow.Cells["Fecha de Nacimiento"].Value);
            par10 = Convert.ToString(this.dataListado.CurrentRow.Cells["Sexo"].Value);
            par11 = Convert.ToString(this.dataListado.CurrentRow.Cells["Dirección"].Value);
            par12 = Convert.ToString(this.dataListado.CurrentRow.Cells["Id_Municipio"].Value);
            par13 = Convert.ToString(this.dataListado.CurrentRow.Cells["Teléfono"].Value);
            par14 = Convert.ToString(this.dataListado.CurrentRow.Cells["ID_PUESTO"].Value);

            byte[] imagenBuffer = (byte[])this.dataListado.CurrentRow.Cells["Foto"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);

            par15 = Image.FromStream(ms);
            par16 = Convert.ToString(this.dataListado.CurrentRow.Cells["Correo"].Value);
           

            par17 = Convert.ToString(this.dataListado.CurrentRow.Cells["Estado"].Value);
            par18 = Convert.ToString(this.dataListado.CurrentRow.Cells["Fecha de Ingreso"].Value);
            form.SetEmpleado(par1, par2, par3, par4, par5, par6, par7, par8, par9, par10, par11, par12, par13, par14, par15, par16, par17, par18);
            this.Hide();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
