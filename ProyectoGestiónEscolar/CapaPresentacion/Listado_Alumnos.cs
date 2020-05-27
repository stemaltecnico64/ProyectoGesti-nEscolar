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
    public partial class Listado_Alumnos : Form
    {
        public Listado_Alumnos()
        {
            InitializeComponent();
            this.txtBuscar.Focus();
        }

        private void OcultarColumnas()
        {
        }

        private void Mostrar()
        {
            this.dataListado.DataSource = NAlumno.Mostrar();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void BuscarApellido()
        {
            this.dataListado.DataSource = NAlumno.Apellido(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NAlumno.Nombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void BuscarCUI()
        {
            this.dataListado.DataSource = NAlumno.cui(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listado_Alumnos_Load(object sender, EventArgs e)
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
            if(cbBuscar.Text.Equals("No. CUI"))
            {
                this.BuscarCUI();
            }
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            Inscripcion_alumno form = Inscripcion_alumno.GetInstancia();
            string par1, par2, par3;
            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["Código"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["CUI"].Value);
            par3 = Convert.ToString(this.dataListado.CurrentRow.Cells["Nombres y Apellidos"].Value);
            form.SetAlumno(par1, par2, par3);
            this.Hide();
        }
    }
}
