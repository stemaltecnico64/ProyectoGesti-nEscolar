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
    public partial class Vista_Inscripcion : Form
    {
        public Vista_Inscripcion()
        {
            InitializeComponent();
        }

        private void OcultarColumnas()
        {
           this.dataListado.Columns[4].Visible = false;
        }

        private void Mostrar()
        {
            this.dataListado.DataSource = NInscripcion.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }


        private void BuscarCUI()
        {
            this.dataListado.DataSource = NInscripcion.BuscarCUI(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void Vista_Inscripcion_Load(object sender, EventArgs e)
        {
            this.txtBuscar.Focus();
            this.Mostrar();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("NO. CUI"))
            {
                this.BuscarCUI();
            }
            else
            {
                this.Mostrar();
            }
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            Inscripcion_alumno ver = Inscripcion_alumno.GetInstancia();
            string par1; string par2; string par3; string par4; string par5; string par6;
            string par7;
            string par8;
            string par9;
            string par10;
            string par11;


            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["Código de Inscripción"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["Ciclo Escolar"].Value);
            par3 = Convert.ToString(this.dataListado.CurrentRow.Cells["Carrera"].Value);
            par4 = Convert.ToString(this.dataListado.CurrentRow.Cells["Tipo de Inscripción"].Value);
            par5 = Convert.ToString(this.dataListado.CurrentRow.Cells["Cód Alumno"].Value);
            par6 = Convert.ToString(this.dataListado.CurrentRow.Cells["CUI"].Value);
            par7 = Convert.ToString(this.dataListado.CurrentRow.Cells["Nombres y Apellidos"].Value);
            par8 = Convert.ToString(this.dataListado.CurrentRow.Cells["Grado"].Value);
            par9 = Convert.ToString(this.dataListado.CurrentRow.Cells["Sección"].Value);
            par10 = Convert.ToString(this.dataListado.CurrentRow.Cells["Fecha de Inscripción"].Value);
            par11= Convert.ToString(this.dataListado.CurrentRow.Cells["Estado"].Value);
            ver.SetInscripcion(par1, par2, par3, par4, par5, par6, par7, par8, par9, par10, par11);
            this.Hide();

        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
