using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Ingresar_Alumno : Form
    {
        private bool IsNuevo = false;

        private bool IsEditar = false;

        private static Ingresar_Alumno _Instancia;
        public static Ingresar_Alumno GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new Ingresar_Alumno();
            }
            return _Instancia;
        }
        public Ingresar_Alumno()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre1, "Ingrese el primer nombre del alumno");
            this.ttMensaje.SetToolTip(this.txtApellido1, "Ingrese el apellido del alumno");
            this.ttMensaje.SetToolTip(this.txtCui, "Ingrese el CUI del Alumno");
            this.ttMensaje.SetToolTip(this.txtNombreEncargado, "Debe seleccionar el nombre de un encargado");
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            this.txtcodigo.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtIdCategoria.Text = string.Empty;
            this.txtCategoria.Text = string.Empty;
            this.txtIdarticulo.Text = string.Empty;
            this.pxImagen.Image = global::CapaPresentacion.Properties.Resources.file;
        }


        private void Habilitar(bool valor)
        {
            this.txtcodigo.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.btnBuscarCategoria.Enabled = valor;
            this.cbIdpresentacion.Enabled = valor;
            this.btnCargar.Enabled = valor;
            this.btnLimpiar.Enabled = valor;
            this.txtCategoria.Enabled = valor;
            this.txtIdarticulo.ReadOnly = !valor;
        }

        //Habilitar los botones
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


        private void btn_add_foto_Click(object sender, EventArgs e)
        {
            try
            {

                openFileDialog1.Title = "Seleccione una Foto";
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pxFoto.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la Imagen");
            }
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevo_encargado_Click(object sender, EventArgs e)
        {
            Ingresar_Encargado ventanaEncargado = new Ingresar_Encargado();
            ventanaEncargado.Show();
        }

        private void Ingresar_Alumno_Load(object sender, EventArgs e)
        {

        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }
    }
}
