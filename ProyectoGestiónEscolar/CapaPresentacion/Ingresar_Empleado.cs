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
    public partial class Ingresar_Empleado : Form
    {
        private bool IsNuevo = false;

        private bool IsEditar = false;

        private static Ingresar_Empleado _Instancia;
        public static Ingresar_Empleado GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new Ingresar_Empleado();
            }
            return _Instancia;
        }
        public Ingresar_Empleado()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre1, "Ingrese el primer nombre del empleado");
            this.ttMensaje.SetToolTip(this.txtApellido1, "Ingrese el apellido del empleado");
            this.ttMensaje.SetToolTip(this.txtDpi, "Ingrese el Dpi del Empleado");
            this.ttMensaje.SetToolTip(this.cbPuesto, "Debe seleccionar el puesto del empleado");

            this.LlenarComboDepartamento();
            this.LlenarComboPuesto();
        }
        public void SetEmpleado(string id_empleado, string dpi, string nombre1, string nombre2, string nombre3, string apellido1, string apellido2, string apellido3, string fecha_nac,
          string sexo, string direccion, string id_municipio, string telefono, string id_puesto, Image foto, string correo, string Estado, string fecha_ingreso)
        {
            this.txtIdEmpleado.Text = id_empleado;
            this.txtDpi.Text = dpi;
            this.txtNombre1.Text = nombre1;
            this.txtNombre2.Text = nombre2;
            this.txtNombre3.Text = nombre3;
            this.txtApellido1.Text = apellido1;
            this.txtApellido2.Text = apellido2;
            this.txtApellido3.Text = apellido3;
            this.dtFechaNac.Text = fecha_nac;
            this.cbSexo.Text = sexo;
            this.txtDireccion.Text = direccion;
            this.cbMunicipio.Text = id_municipio;
            this.txtTelefono.Text = telefono;
            this.cbPuesto.Text = id_puesto;
            this.pxFoto.Image = foto;
            this.txtCorreo.Text = correo;
            this.cbEstado.Text = Estado;
            this.dtFecha_Ingreso.Text = fecha_ingreso;
        }

        private void LlenarComboPuesto()
        {
            cbPuesto.DataSource = NPuesto.Mostrar();
            cbPuesto.ValueMember = "ID_PUESTO";
            cbPuesto.DisplayMember = "PUESTO";

        }
        SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuelaComercio; Integrated Security = true ");

        private void LlenarComboMunicipio(string id_departamento)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id_Municipio, Nombre_Muni from Municipio where Id_Departamento = @Id_Departamento", con);
            cmd.Parameters.AddWithValue("Id_Departamento", id_departamento);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre_Muni"] = "Seleccione un Municipio";
            dt.Rows.InsertAt(fila, 0);

            cbMunicipio.ValueMember = "Id_Municipio";
            cbMunicipio.DisplayMember = "Nombre_Muni";
            cbMunicipio.DataSource = dt;
        }

        private void LlenarComboDepartamento()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id_Departamento, Nombre_Dep from Departamento", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre_Dep"] = "Seleccione un Departamento";
            dt.Rows.InsertAt(fila, 0);

            cbDepartamento.ValueMember = "Id_Departamento";
            cbDepartamento.DisplayMember = "Nombre_Dep";
            cbDepartamento.DataSource = dt;
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
            this.txtIdEmpleado.Text = string.Empty;
            this.txtDpi.Text = string.Empty;
            this.txtNombre1.Text = string.Empty;
            this.txtNombre2.Text = string.Empty;
            this.txtNombre3.Text = string.Empty;
            this.txtApellido1.Text = string.Empty;
            this.txtApellido2.Text = string.Empty;
            this.txtApellido3.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtIdEmpleado.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
            this.pxFoto.Image = global::CapaPresentacion.Properties.Resources.file;
        }



        private void Habilitar(bool valor)
        {
            this.txtIdEmpleado.ReadOnly = !valor;
            this.txtDpi.Enabled = valor;
            this.txtNombre1.Enabled = valor;
            this.txtNombre2.Enabled = valor;
            this.txtNombre3.Enabled = valor;
            this.txtApellido1.Enabled = valor;
            this.txtApellido2.Enabled = valor;
            this.txtApellido3.Enabled = valor;
            this.cbSexo.Enabled = valor;
            this.dtFechaNac.Enabled = valor;
            this.txtTelefono.Enabled = valor;
            this.txtDireccion.Enabled = valor;
            this.cbDepartamento.Enabled = valor;
            this.cbMunicipio.Enabled = valor;
            this.txtIdEmpleado.Enabled = valor;
            this.cbPuesto.Enabled = valor;
            this.dtFecha_Ingreso.Enabled = valor;
            this.BtnQuitarFoto.Enabled = valor;
            this.BtnAgregarFoto.Enabled = valor;
            this.cbEstado.Enabled = valor;
        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
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

        private void Ingresar_Empleado_Load(object sender, EventArgs e)
        {
            this.Habilitar(false);
            this.Botones();
            this.txtDpi.Focus();
        }

        private void BtnAgregarFoto_Click(object sender, EventArgs e)
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
            this.txtDpi.Focus();
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
                    if (this.txtDpi.Text == string.Empty || this.txtNombre1.Text == string.Empty
                        || this.txtApellido1.Text == string.Empty || this.cbPuesto.Text == string.Empty)
                    {
                        MensajeError("Falta ingresar algunos datos, serán remarcados");
                        errorIcono.SetError(txtDpi, "Ingrese un Valor");
                        errorIcono.SetError(txtNombre1, "Ingrese un Valor");
                        errorIcono.SetError(txtApellido1, "Ingrese un Valor");
                        errorIcono.SetError(cbPuesto, "Ingrese un Valor");
                    }
                    else
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        this.pxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                        byte[] imagen = ms.GetBuffer();


                        if (this.IsNuevo)
                        {
                            rpta = NEmpleado.Insertar(this.txtDpi.Text, this.txtNombre1.Text, this.txtNombre2.Text, this.txtNombre3.Text, this.txtApellido1.Text, this.txtApellido2.Text, this.txtApellido3.Text,
                                this.dtFechaNac.Value, this.cbSexo.Text, this.txtDireccion.Text, Convert.ToInt32(this.cbMunicipio.SelectedValue), this.txtTelefono.Text, Convert.ToInt32(this.cbPuesto.SelectedValue), imagen,
                                this.txtCorreo.Text, this.cbEstado.Text, this.dtFecha_Ingreso.Value);
                        }
                        else
                        {
                            rpta = NEmpleado.Editar(Convert.ToInt32(this.txtIdEmpleado.Text),
                                this.txtDpi.Text, this.txtNombre1.Text, this.txtNombre2.Text, this.txtNombre3.Text, this.txtApellido1.Text, this.txtApellido2.Text, this.txtApellido3.Text,
                                this.dtFechaNac.Value, this.cbSexo.Text, this.txtDireccion.Text, Convert.ToInt32(this.cbMunicipio.SelectedValue), this.txtTelefono.Text, Convert.ToInt32(this.cbPuesto.SelectedValue), imagen,
                                this.txtCorreo.Text, this.cbEstado.Text, this.dtFecha_Ingreso.Value);
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdEmpleado.Text.Equals(""))
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
            this.Habilitar(false);
        }

        private void CbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepartamento.SelectedValue.ToString() != null)
            {
                string id_departamento = cbDepartamento.SelectedValue.ToString();
                LlenarComboMunicipio(id_departamento);
            }
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtDpi_KeyPress(object sender, KeyPressEventArgs e)
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
                this.txtCorreo.Focus();
        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CbMunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.cbPuesto.Focus();
        }

        private void CbPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.dtFecha_Ingreso.Focus();
        }

        private void DtFecha_Ingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.btnGuardar.Focus();
        }

        private void BtnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            VistaEmpleados ver = new VistaEmpleados();
            ver.Show();
        }

        private void Ingresar_Empleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }
    }
}
