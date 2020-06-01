using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocios;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class VistaAlumnoEditar : Form
    {
        public VistaAlumnoEditar()
        {
            InitializeComponent();
        }

        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[5].Visible = false;
            this.dataListado.Columns[8].Visible = false;
            this.dataListado.Columns[11].Visible = false;
            this.dataListado.Columns[12].Visible = false;
            this.dataListado.Columns[14].Visible = false;
            this.dataListado.Columns[15].Visible = false;
            this.dataListado.Columns[20].Visible = false;
        }

        private void Mostrar()
        {
            this.dataListado.DataSource = NAlumno.Mostrar();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void BuscarApellido()
        {
            this.dataListado.DataSource = NAlumno.ApellidoEditar(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NAlumno.NombreEditar(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void BuscarCUI()
        {
            this.dataListado.DataSource = NAlumno.cuiEditar(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void VistaAlumnoEditar_Load(object sender, EventArgs e)
        {
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
            if (cbBuscar.Text.Equals("No. CUI"))
            {
                this.BuscarCUI();
            }
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            Editar_Alumno form = Editar_Alumno.GetInstancia();
            Image par15;

            string par1, par2, par3, par4, par5, par6, par7, par8, par9, par10, par11, par12, par13, par14, par16, par17, par18, par19, par20, par21;
            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["Código"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["Código Alumno"].Value);
            par3 = Convert.ToString(this.dataListado.CurrentRow.Cells["CUI"].Value);
            par4 = Convert.ToString(this.dataListado.CurrentRow.Cells["Primer Nombre"].Value);
            par5 = Convert.ToString(this.dataListado.CurrentRow.Cells["Segundo Nombre"].Value);
            par6 = Convert.ToString(this.dataListado.CurrentRow.Cells["Tercer Nombre"].Value);
            par7 = Convert.ToString(this.dataListado.CurrentRow.Cells["Primer Apellido"].Value);
            par8 = Convert.ToString(this.dataListado.CurrentRow.Cells["Segundo Apellido"].Value);
            par9 = Convert.ToString(this.dataListado.CurrentRow.Cells["Tercer Apellido"].Value);
            par10 = Convert.ToString(this.dataListado.CurrentRow.Cells["Fecha de Nacimiento"].Value);
            par11 = Convert.ToString(this.dataListado.CurrentRow.Cells["Sexo"].Value);
            par12 = Convert.ToString(this.dataListado.CurrentRow.Cells["Dirección"].Value);
            par13 = Convert.ToString(this.dataListado.CurrentRow.Cells["Id_Municipio"].Value);
            par14 = Convert.ToString(this.dataListado.CurrentRow.Cells["Teléfono"].Value);

            byte[] imagenBuffer = (byte[])this.dataListado.CurrentRow.Cells["Foto"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);

            par15 = Image.FromStream(ms);
            par17 = Convert.ToString(this.dataListado.CurrentRow.Cells["Estado"].Value);
            par18 = Convert.ToString(this.dataListado.CurrentRow.Cells["Id_Encargado"].Value);
            par19 = Convert.ToString(this.dataListado.CurrentRow.Cells["Dpi Encargado"].Value);
            par20 = Convert.ToString(this.dataListado.CurrentRow.Cells["Primer Nombre Encargado"].Value);
            par21 = Convert.ToString(this.dataListado.CurrentRow.Cells["Primer Apellido Encargado"].Value);
            form.SetAlumnoEditar(par1, par2, par3, par4, par5, par6, par7, par8, par9, par10, par11, par12, par13, par14, par15, par17, par18, par19, par20, par21);
            this.Hide();
        }
    }
}
