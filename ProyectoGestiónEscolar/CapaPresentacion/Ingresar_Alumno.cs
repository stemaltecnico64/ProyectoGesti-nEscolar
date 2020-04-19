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
using System.Resources;
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

            this.LlenarComboDepartamento();
            this.LlenarComboMunicipio();
            this.cbEstado.Visible = false;
            this.label10.Visible = false;
        }

        private void LlenarComboMunicipio()
        {
            cbMunicipio.DataSource = NMunicipio.Mostrar();
            cbMunicipio.ValueMember = "Id_Municipio";
            cbMunicipio.DisplayMember = "Municipio";
        }

        private void LlenarComboDepartamento()
        {
            cbDepartamento.DataSource = NDepartamento.Mostrar();
            cbDepartamento.ValueMember = "Id_Departamento";
            cbDepartamento.DisplayMember = "Nombre_Dep";
        }

        public void SetEncargado(string idEncargado, string dpi, string nombre, string apellido)
        {
            this.txtIdEncargado.Text = idEncargado;
            this.txtDpiEncargado.Text = dpi;
            this.txtNombreEncargado.Text = nombre;
            this.txtApellidoEncargado.Text = apellido;

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
            this.txtIdAlumno.Text = string.Empty;
            this.txtCodigoAlumno.Text = string.Empty;
            this.txtCui.Text = string.Empty;
            this.txtNombre1.Text = string.Empty;
            this.txtNombre2.Text = string.Empty;
            this.txtNombre3.Text = string.Empty;
            this.txtApellido1.Text = string.Empty;
            this.txtApellido2.Text = string.Empty;
            this.txtApellido3.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtIdEncargado.Text = string.Empty;
            this.txtDpiEncargado.Text = string.Empty;
            this.txtNombreEncargado.Text = string.Empty;
            this.txtApellidoEncargado.Text = string.Empty;
            this.pxFoto.Image = global::CapaPresentacion.Properties.Resources.file;   
        }



        private void Habilitar(bool valor)
        {
            this.txtIdAlumno.ReadOnly = !valor;
            this.txtCodigoAlumno.Enabled = valor;
            this.txtCui.Enabled = valor;
            this.txtNombre1.Enabled = valor;
            this.txtNombre2.Enabled = valor;
            this.txtNombre3.Enabled = valor;
            this.txtApellido1.Enabled = valor;
            this.txtApellido2.Enabled = valor;
            this.txtApellido3.Enabled = valor;
            this.cbSexo.Enabled = valor;
            this.dtFechaNac.Enabled = valor;
            this.txtTelefono.Enabled = valor;
            this.cbDepartamento.Enabled = valor;
            this.cbMunicipio.Enabled = valor;
            this.txtIdEncargado.Enabled = valor;
            this.txtDpiEncargado.Enabled = valor;
            this.txtNombreEncargado.Enabled = valor;
            this.txtApellidoEncargado.Enabled = valor;
            this.BtnAgregarFoto.Enabled = valor;
            this.cbEstado.Enabled = valor;
            this.btnBuscarEncargado.Enabled = valor;
            this.btnNuevoEncargado.Enabled = valor;
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

                OpenFileDialog dialog = new OpenFileDialog();

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.pxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pxFoto.Image = Image.FromFile(dialog.FileName);
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
            this.Habilitar(false);
            this.Botones();
            this.txtCodigoAlumno.Focus();
        }

        private void BtnQuitarFoto_Click(object sender, EventArgs e)
        {
            this.pxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pxFoto.Image = global::CapaPresentacion.Properties.Resources.file;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtCodigoAlumno.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Está seguro de guardar estos datos?", "SEGURIDAD DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string rpta = "";
                if (this.txtCui.Text == string.Empty || this.txtNombre1.Text == string.Empty
                    || this.txtApellido1.Text == string.Empty || this.txtIdEncargado.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtCui, "Ingrese un Valor");
                    errorIcono.SetError(txtNombre1, "Ingrese un Valor");
                    errorIcono.SetError(txtApellido1, "Ingrese un Valor");
                    errorIcono.SetError(txtIdEncargado, "Ingrese un Valor");
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    byte[] imagen = ms.GetBuffer();


                    if (this.IsNuevo)
                    {
                        rpta = NAlumno.Insertar(this.txtCodigoAlumno.Text, this.txtCui.Text, this.txtNombre1.Text, this.txtNombre2.Text, this.txtNombre3.Text, this.txtApellido1.Text, this.txtApellido2.Text, this.txtApellido3.Text,
                            Convert.ToDateTime(this.dtFechaNac.Value), this.cbSexo.Text, this.txtDireccion.Text, Convert.ToInt32(this.cbMunicipio.SelectedValue), this.txtTelefono.Text, imagen, Convert.ToInt32(this.txtIdEncargado.Text),
                            this.cbEstado.Text);                            
                    }
                    else
                    {
                        rpta = NAlumno.Editar(Convert.ToInt32(this.txtIdAlumno.Text),
                            this.txtCodigoAlumno.Text, this.txtCui.Text, this.txtNombre1.Text, this.txtNombre2.Text, this.txtNombre3.Text, this.txtApellido1.Text, this.txtApellido2.Text, this.txtApellido3.Text,
                            this.dtFechaNac.Value, this.cbSexo.Text, this.txtDireccion.Text, Convert.ToInt32(this.cbMunicipio.Text), this.txtTelefono.Text, imagen, Convert.ToInt32(this.txtIdEncargado.Text),
                            this.cbEstado.Text);
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

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            Listado_Encargados ver = new Listado_Encargados();
            ver.ShowDialog();
        }

        private void TxtCodigoAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.txtCui.Focus();
        }

        private void TxtCui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.txtNombre1.Focus();
        }

        private void TxtNombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.txtNombre2.Focus();
        }

        private void TxtNombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.txtNombre3.Focus();
        }

        private void TxtNombre3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.txtApellido1.Focus();
        }

        private void TxtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.txtApellido2.Focus();
        }

        private void TxtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.txtApellido3.Focus();
        }

        private void TxtApellido3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.cbSexo.Focus();
        }

        private void CbSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.dtFechaNac.Focus();
        }

        private void DtFechaNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.txtTelefono.Focus();
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.txtDireccion.Focus();
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.cbDepartamento.Focus();
        }

        private void CbDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.cbMunicipio.Focus();
        }

        private void DtFechaNac_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.txtTelefono.Focus();
        }
    }
}
