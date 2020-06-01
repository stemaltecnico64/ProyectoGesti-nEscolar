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
            this.dataListadoAl.DataSource = NAlumno.Mostrar();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListadoAl.Rows.Count);
        }

        private void BuscarApellido()
        {
            this.dataListadoAl.DataSource = NAlumno.Apellido(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListadoAl.Rows.Count);
        }
        private void BuscarNombre()
        {
            this.dataListadoAl.DataSource = NAlumno.Nombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListadoAl.Rows.Count);
        }

        private void BuscarCUI()
        {
            this.dataListadoAl.DataSource = NAlumno.cui(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListadoAl.Rows.Count);
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
            par1 = Convert.ToString(this.dataListadoAl.CurrentRow.Cells["Código"].Value);
            par2 = Convert.ToString(this.dataListadoAl.CurrentRow.Cells["CUI"].Value);
            par3 = Convert.ToString(this.dataListadoAl.CurrentRow.Cells["Nombres y Apellidos"].Value);
            form.SetAlumno(par1, par2, par3);
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Reporte_Alumnos_Actual raa = new Reporte_Alumnos_Actual();
            raa.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (dataListadoAl.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Borrar este Alumno", "SEGURIDAD DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    try
                    {
                        string cmd = string.Format("Execute Delete_Alumno '{0}'", Convert.ToInt32(dataListadoAl.Rows[dataListadoAl.CurrentRow.Index].Cells[0].Value.ToString()));
                        Login.Conexion_GX(cmd);
                        MessageBox.Show("El Alumno se ha Borrado..!");
                        this.Mostrar();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un Error!" + error);
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
