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
    public partial class Agregar_Tipo_Inscripcion : Form
    {
        private bool IsNuevo = false;

        private bool IsEditar = false;
        public Agregar_Tipo_Inscripcion()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtTipo_Inscripcion, "Debe ingresas un Tipo de Inscripción, Ejemplo: Ordinario, ExtraOrdinario");
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
            this.txtId_Tipo_Inscripcion.Text = string.Empty;
            this.txtTipo_Inscripcion.Text = string.Empty;

        }



        private void Habilitar(bool valor)
        {
            this.txtId_Tipo_Inscripcion.ReadOnly = !valor;
            this.txtTipo_Inscripcion.Enabled = valor;

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
            this.dataListado.DataSource = NTipo_Inscripcion.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void Agregar_Tipo_Inscripcion_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtId_Tipo_Inscripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Código"].Value);
            this.txtTipo_Inscripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Tipo de Inscripción"].Value);
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtTipo_Inscripcion.Focus();

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtTipo_Inscripcion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtTipo_Inscripcion, "Ingrese un Valor");

                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NTipo_Inscripcion.Insertar(this.txtTipo_Inscripcion.Text);

                    }
                    else
                    {
                        rpta = NTipo_Inscripcion.Editar(Convert.ToInt32(this.txtId_Tipo_Inscripcion.Text),
                            this.txtTipo_Inscripcion.Text);
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtTipo_Inscripcion.Text = string.Empty;

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (!this.txtTipo_Inscripcion.Text.Equals(""))
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
    }
}
