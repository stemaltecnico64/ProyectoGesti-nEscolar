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
using System.Data.SqlClient;
namespace CapaPresentacion
{
    public partial class Crear_Ciclo : Form
    {
        private bool IsNuevo = false;

        private bool IsEditar = false;
        public Crear_Ciclo()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtCiclo, "Ingrese el Ciclo o año escolar");
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
            this.txtId_Ciclo.Text = string.Empty;
            this.txtCiclo.Text = string.Empty;
            this.txtDes.Text = string.Empty;
            this.dtFecha.Text = string.Empty;
        }

        private void Habilitar(bool valor)
        {
            this.txtId_Ciclo.Enabled = valor;
            this.txtCiclo.Enabled = valor;
            this.txtDes.Enabled = valor;

        }

        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }

        }


        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Crear_Ciclo_Load(object sender, EventArgs e)
        {
            this.Habilitar(false);
            this.Botones();
            this.txtCiclo.Focus();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtCiclo.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (this.txtCiclo.Text == this.txtCiclo.Text)
                {
                    MessageBox.Show("El Ciclo ya está ingresado o está activo. Verifique!");
                }

                else
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("¿Está seguro de guardar estos datos?", "SEGURIDAD DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.Yes)
                    {
                        string rpta = "";
                        if (this.txtCiclo.Text == string.Empty)
                        {
                            MensajeError("Falta ingresar algunos datos, serán remarcados");
                            errorIcono.SetError(txtCiclo, "Ingrese un Valor");

                        }
                        else
                        {
                            if (this.IsNuevo)
                            {
                                rpta = NCiclo.Insertar(this.txtCiclo.Text, this.txtDes.Text, this.dtFecha.Text, this.txtEstado.Text);
                            }
                            else
                            {

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

                        }
                    }
                    else
                    {

                    }
                }          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
       
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }
    }
}
