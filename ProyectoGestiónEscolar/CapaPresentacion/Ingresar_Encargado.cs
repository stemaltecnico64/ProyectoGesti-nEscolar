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
    public partial class Ingresar_Encargado : Form
    {
        private bool IsNuevo = false;

        private bool IsEditar = false;

        private static Ingresar_Encargado _Instancia;
        public static Ingresar_Encargado GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new Ingresar_Encargado();
            }
            return _Instancia;
        }
        public Ingresar_Encargado()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre1, "Ingrese el primer nombre del Encargado");
            this.ttMensaje.SetToolTip(this.txtApellido1, "Ingrese el apellido del Encargado");
            this.ttMensaje.SetToolTip(this.txtDpi, "Ingrese el Número de DPI del Encargado");
            this.ttMensaje.SetToolTip(this.txtApellido2, "Ingrese el Segundo apellido del Encargado");

            this.LlenarComboTipoEncargado();
            this.LlenarComboDepartamento();
            this.cbEstado.Visible = false;
            this.label10.Visible = false;
        }


        SqlConnection con = new SqlConnection("Data Source = DESKTOP-NPN78EM; Initial Catalog = BDEscuelaComercio; Integrated Security = true ");

        private void LlenarComboTipoEncargado()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id_Tipo_Encargado, Nombre from Tipo_Encargado", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione un Parentezco";
            dt.Rows.InsertAt(fila, 0);

            cbTipoEncargado.ValueMember = "Id_Tipo_Encargado";
            cbTipoEncargado.DisplayMember = "Nombre";
            cbTipoEncargado.DataSource = dt;
        }

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
            this.txtIdEncargado.Text = string.Empty;
            this.txtDpi.Text = string.Empty;
            this.txtNombre1.Text = string.Empty;
            this.txtNombre2.Text = string.Empty;
            this.txtNombre3.Text = string.Empty;
            this.txtApellido1.Text = string.Empty;
            this.txtApellido2.Text = string.Empty;
            this.txtApellido3.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.pxFoto.Image = global::CapaPresentacion.Properties.Resources.file;
        }



        private void Habilitar(bool valor)
        {
            this.txtIdEncargado.ReadOnly = !valor;
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
            this.cbDepartamento.Enabled = valor;
            this.cbMunicipio.Enabled = valor;
            this.cbTipoEncargado.Enabled = valor;
            this.BtnAgregarFoto.Enabled = valor;
            this.BtnQuitarFoto.Enabled = valor;
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
                Opcion = MessageBox.Show("¿Está seguro de guardar estos datos del Encargado del Alumno?", "SEGURIDAD DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string rpta = "";
                    if (this.txtDpi.Text == string.Empty || this.txtNombre1.Text == string.Empty
                        || this.txtApellido1.Text == string.Empty)
                    {
                        MensajeError("Falta ingresar algunos datos, serán remarcados");
                        errorIcono.SetError(txtDpi, "Ingrese un Valor");
                        errorIcono.SetError(txtNombre1, "Ingrese un Valor");
                        errorIcono.SetError(txtApellido1, "Ingrese un Valor");
                    }
                    else
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        this.pxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                        byte[] imagen = ms.GetBuffer();


                        if (this.IsNuevo)
                        {
                            rpta = NEncargado.Insertar(this.txtDpi.Text, this.txtNombre1.Text, this.txtNombre2.Text, this.txtNombre3.Text, this.txtApellido1.Text, this.txtApellido2.Text, this.txtApellido3.Text,
                                dtFechaNac.Value, this.cbSexo.Text, this.txtDireccion.Text, Convert.ToInt32(this.cbMunicipio.SelectedValue), this.txtTelefono.Text, imagen, Convert.ToInt32(this.cbTipoEncargado.SelectedValue),
                                this.cbEstado.Text);
                        }
                        else
                        {
                            rpta = NEncargado.Editar(Convert.ToInt32(this.txtIdEncargado.Text),
                                this.txtDpi.Text, this.txtNombre1.Text, this.txtNombre2.Text, this.txtNombre3.Text, this.txtApellido1.Text, this.txtApellido2.Text, this.txtApellido3.Text,
                                this.dtFechaNac.Value, this.cbSexo.Text, this.txtDireccion.Text, Convert.ToInt32(this.cbMunicipio.SelectedValue), this.txtTelefono.Text, imagen, Convert.ToInt32(this.cbTipoEncargado.SelectedValue),
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

        private void Ingresar_Encargado_Load(object sender, EventArgs e)
        {
            this.Habilitar(false);
            this.Botones();
            this.txtDpi.Focus();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Realmente Desea Salir", "SEGURIDAD DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Opcion == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
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
                this.txtTelefono.Focus();
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.dtFechaNac.Focus();
        }

        private void DtFechaNac_KeyPress(object sender, KeyPressEventArgs e)
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
                this.cbTipoEncargado.Focus();
        }

        private void CbTipoEncargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.btnGuardar.Focus();
        }

        private void DtFechaNac_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.txtDireccion.Focus();
        }

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepartamento.SelectedValue.ToString() != null)
            {
                string id_departamento = cbDepartamento.SelectedValue.ToString();
                LlenarComboMunicipio(id_departamento);
            }
        }
    }
}
