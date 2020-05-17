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
    public partial class Ingreso_de_Grados : Form
    {
        private bool IsNuevo = false;

        private bool IsEditar = false;
        public Ingreso_de_Grados()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtGrado, "Debe ingresas un grado, Ejemplo: 4to. 5to. 6to.");

        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SEGURIDAD DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SEGURIDAD DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            this.txtId_Grado.Text = string.Empty;
            this.txtGrado.Text = string.Empty;

        }



        private void Habilitar(bool valor)
        {
            this.txtId_Grado.ReadOnly = !valor;
            this.txtGrado.Enabled = valor;
          
        }
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) 
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }

        }
        private void OcultarColumnas()
        {
        }

        private void Mostrar()
        {
            this.dataListado.DataSource = NGrado.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void Ingreso_de_Grados_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtGrado.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                string rpta = "";
                if (this.txtGrado.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtGrado, "Ingrese un Valor");

                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NGrado.Insertar(this.txtGrado.Text);

                    }
                    else
                    {
                        rpta = NGrado.Editar(Convert.ToInt32(this.txtGrado.Text),
                            this.txtGrado.Text);
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtGrado.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtGrado.Text = string.Empty;
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtId_Grado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Código"].Value);
            this.txtGrado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Grado"].Value);
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
