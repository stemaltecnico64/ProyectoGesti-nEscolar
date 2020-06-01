using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using CapaNegocios;
namespace CapaPresentacion
{
    public partial class Editar_Alumno : Form
    {
        private bool IsNuevo = false;

        private bool IsEditar = false;

        private static Editar_Alumno _Instancia;
        public static Editar_Alumno GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new Editar_Alumno();
            }
            return _Instancia;
        }
        public Editar_Alumno()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre1, "Ingrese el primer nombre del alumno");
            this.ttMensaje.SetToolTip(this.txtApellido1, "Ingrese el apellido del alumno");
            this.ttMensaje.SetToolTip(this.txtCui, "Ingrese el CUI del Alumno");
            this.ttMensaje.SetToolTip(this.txtNombreEncargado, "Debe seleccionar el nombre de un encargado");

            this.LlenarComboDepartamento();
        }


        public void SetAlumnoEditar(string id_alumno, string codigo_alumno, string cui, string nombre1, string nombre2, string nombre3, string apellido1, string apellido2, string apellido3, string fecha_nac,
            string sexo, string direccion, string id_municipio, string telefono, Image foto, string Estado, string id_encargado, string dpi, string nombre_encargado, string apellido_encargado )
        {
            this.txtIdAlumno.Text = id_alumno;
            this.txtCodigoAlumno.Text = codigo_alumno;
            this.txtCui.Text = cui;
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
            this.pxFoto.Image = foto;
            this.txtIdEncargado.Text = id_encargado;
            this.txtDpiEncargado.Text = dpi;
            this.txtNombreEncargado.Text = nombre_encargado;
            this.txtApellidoEncargado.Text = apellido_encargado;
            this.cbEstado.Text = Estado;
        }
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-NPN78EM; Initial Catalog = BDEscuelaComercio; Integrated Security = true ");

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
            this.txtDireccion.Text = string.Empty;
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
            this.txtDireccion.Enabled = valor;
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
        private void Editar_Alumno_Load(object sender, EventArgs e)
        {
            this.Habilitar(false);
            this.Botones();
            this.txtCodigoAlumno.Focus();
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
                                this.dtFechaNac.Value, this.cbSexo.Text, this.txtDireccion.Text, Convert.ToInt32(this.cbMunicipio.SelectedValue), this.txtTelefono.Text, imagen, Convert.ToInt32(this.txtIdEncargado.Text),
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

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (!this.txtIdAlumno.Text.Equals(""))
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

        private void BtnBuscarEncargado_Click(object sender, EventArgs e)
        {
            Listado_Encargados ver = new Listado_Encargados();
            ver.ShowDialog();

            if (ver.DialogResult == DialogResult.OK)
            {
                txtIdEncargado.Text = ver.dataListadoE.Rows[ver.dataListadoE.CurrentRow.Index].Cells[0].Value.ToString();
                txtDpiEncargado.Text = ver.dataListadoE.Rows[ver.dataListadoE.CurrentRow.Index].Cells[1].Value.ToString();
                txtNombreEncargado.Text = ver.dataListadoE.Rows[ver.dataListadoE.CurrentRow.Index].Cells[2].Value.ToString();
                txtApellidoEncargado.Text = ver.dataListadoE.Rows[ver.dataListadoE.CurrentRow.Index].Cells[3].Value.ToString();
            }
        }

        private void BtnNuevoEncargado_Click(object sender, EventArgs e)
        {
            Ingresar_Encargado ventanaEncargado = new Ingresar_Encargado();
            ventanaEncargado.Show();
        }

        private void CbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepartamento.SelectedValue.ToString() != null)
            {
                string id_departamento = cbDepartamento.SelectedValue.ToString();
                LlenarComboMunicipio(id_departamento);
            }
        }

        private void BtnBuscarAlumnoEditar_Click(object sender, EventArgs e)
        {
            VistaAlumnoEditar ver = new VistaAlumnoEditar();
            ver.Show();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editar_Alumno_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }
    }
}
