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
using System.Data;
namespace CapaPresentacion
{
    public partial class Inscripcion_alumno : Form
    {
        private bool IsNuevo = false;

        private bool IsEditar = false;

        private static Inscripcion_alumno _instancia;
        public static Inscripcion_alumno GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Inscripcion_alumno();
            }
            return _instancia;
        }
        public Inscripcion_alumno()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombreAlumno, "Ingrese un Alumno");
            this.ttMensaje.SetToolTip(this.txtCui_Alumno, "Ingrese un Alumno");
            this.ttMensaje.SetToolTip(this.cbTipo_Inscripcion, "Selecciones un tipo de inscripcion");
            this.ttMensaje.SetToolTip(this.cbCarrera, "Seleccione una carrera");
            this.ttMensaje.SetToolTip(this.cbGrado, "Seleccione una carrera");
            this.ttMensaje.SetToolTip(this.cbSeccion, "Seleccione una Sección");


            this.LlenarComboCiclo();
            this.LlenarTipoIns();
            this.LlenarComboCarrera();
            this.LlenarComboSeccion();
        }

        SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuelaComercio; Integrated Security = true ");


        public void SetAlumno(string idalumno, string cui, string nombresyapellidos)
        {
            this.txtId_Alumno.Text = idalumno;
            this.txtCui_Alumno.Text = cui;
            this.txtNombreAlumno.Text = nombresyapellidos;
        }


        public void SetInscripcion(string idinscripcion, string id_ciclo, string id_carrera, string id_tipo_inscripcion, string idalumno,
            string cui, string nombresyapellidos, string id_grado, string id_seccion, string fecha, string estado)
        {
            this.txtIdInscripcion.Text = idinscripcion;
            this.cbCiclo.Text = id_ciclo;
            this.cbCarrera.Text = id_carrera;
            this.cbTipo_Inscripcion.Text = id_tipo_inscripcion;
            this.txtId_Alumno.Text = idalumno;
            this.txtCui_Alumno.Text = cui;
            this.txtNombreAlumno.Text = nombresyapellidos;
            this.cbGrado.Text = id_grado;
            this.cbSeccion.Text = id_seccion;
            this.dtFechaNac.Text = fecha;
            this.cbEstado.Text = estado;
        }


        private void LlenarComboCiclo()
        {
            cbCiclo.DataSource = NCiclo.Mostrar();
            cbCiclo.ValueMember = "Código";
            cbCiclo.DisplayMember = "Ciclo o año";
        }

        private void LlenarTipoIns()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id_Tipo_Inscripcion, Nombre from Tipo_Inscripcion", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Eliga un Tipo de Inscripción ";
            dt.Rows.InsertAt(fila, 0);

            cbTipo_Inscripcion.ValueMember = "Id_Tipo_Inscripcion";
            cbTipo_Inscripcion.DisplayMember = "Nombre";
            cbTipo_Inscripcion.DataSource = dt;
        }

        private void LlenarComboCarrera()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id_Carrera, Nombre from Carrera", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione una Carrera";
            dt.Rows.InsertAt(fila, 0);

            cbCarrera.ValueMember = "Id_Carrera";
            cbCarrera.DisplayMember = "Nombre";
            cbCarrera.DataSource = dt;
        }


        private void LlenarComboGrado(string id_carrera)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id_Grado, Nombre from Grado where Id_Carrera = @Id_Carrera", con);
            cmd.Parameters.AddWithValue("Id_Carrera", id_carrera);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione un Grado";
            dt.Rows.InsertAt(fila, 0);

            cbGrado.ValueMember = "Id_Grado";
            cbGrado.DisplayMember = "Nombre";
            cbGrado.DataSource = dt;
        }
        private void LlenarComboSeccion()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id_Seccion, Nombre from Seccion", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione una Sección";
            dt.Rows.InsertAt(fila, 0);

            cbSeccion.ValueMember = "Id_Seccion";
            cbSeccion.DisplayMember = "Nombre";
            cbSeccion.DataSource = dt;
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
            this.txtId_Alumno.Text = string.Empty;
            this.txtCui_Alumno.Text = string.Empty;
            this.txtNombreAlumno.Text = string.Empty;
        }

        private void Habilitar(bool valor)
        {
            this.txtId_Alumno.Enabled = !valor;
            this.txtCui_Alumno.Enabled = !valor;
            this.txtNombreAlumno.Enabled = !valor;
            this.cbTipo_Inscripcion.Enabled = valor;
            this.cbCarrera.Enabled = valor;
            this.cbGrado.Enabled = valor;
            this.cbSeccion.Enabled = valor;
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

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevo_alumno_Click(object sender, EventArgs e)
        {
            Ingresar_Alumno ventanalumno = Ingresar_Alumno.GetInstancia();
            ventanalumno.Show();
        }

        private void Inscripcion_alumno_Load(object sender, EventArgs e)
        {
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
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.cbCiclo.Text == string.Empty)
                {
                    MensajeError("Estimado Usuario no tiene un ciclo activo");
                }
                else
                {                    
                    if (txtIdInscripcion.Text == txtId_Alumno.Text)
                    {
                        MensajeError("El Alumno ya está ingreso");
                    }
                    else
                    {
                  DialogResult Opcion;
                    Opcion = MessageBox.Show("¿Está seguro de guardar estos datos?", "SEGURIDAD DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.Yes)
                    {
                        string rpta = "";
                        if (this.txtNombreAlumno.Text == string.Empty || this.cbTipo_Inscripcion.Text == "Eliga un Tipo de Inscripción " || this.cbCarrera.Text == "Seleccione una Carrera"
                            || this.cbGrado.Text == "Seleccione un Grado" || this.cbSeccion.Text == "Seleccione una Sección")
                        {
                            MensajeError("Falta ingresar algunos datos, serán remarcados");
                            errorIcono.SetError(txtNombreAlumno, "Ingrese un Nombre de Alumno");
                            errorIcono.SetError(cbTipo_Inscripcion, "Ingrese un tipo de inscripción");
                            errorIcono.SetError(cbCarrera, "Ingrese una carrera");
                            errorIcono.SetError(cbGrado, "Ingrese un grado");
                            errorIcono.SetError(cbSeccion, "Ingrese una sección");
                        }
                        else
                        {

                            if (this.IsNuevo)
                            {
                                rpta = NInscripcion.Insertar(Convert.ToInt32(this.cbCiclo.SelectedValue), Convert.ToInt32(this.cbCarrera.SelectedValue), Convert.ToInt32(this.cbTipo_Inscripcion.SelectedValue), Convert.ToInt32(this.txtId_Alumno.Text),
                                     Convert.ToInt32(this.cbGrado.SelectedValue), Convert.ToInt32(this.cbSeccion.SelectedValue), this.dtFechaNac.Value, this.cbEstado.Text);
                            }
                            else
                            {
                                rpta = NInscripcion.Editar(Convert.ToInt32(txtIdInscripcion.Text), Convert.ToInt32(this.cbCiclo.SelectedValue), Convert.ToInt32(this.cbCarrera.SelectedValue), Convert.ToInt32(this.cbTipo_Inscripcion.SelectedValue), Convert.ToInt32(this.txtId_Alumno.Text),
                                    Convert.ToInt32(this.cbGrado.SelectedValue), Convert.ToInt32(this.cbSeccion.SelectedValue), this.dtFechaNac.Value, this.cbEstado.Text);
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
                            this.LlenarComboCiclo();
                            this.LlenarTipoIns();
                            this.LlenarComboCarrera();
                             this.LlenarComboSeccion();

                            }
                    }
                    else
                    {

                    }
                    }
  
                }
            }
              
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            Listado_Alumnos vista = new Listado_Alumnos();
            vista.ShowDialog();
        }

        private void Inscripcion_alumno_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void Inscripcion_alumno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Listado_Alumnos ver = new Listado_Alumnos();
                ver.Show();
            }
        }

        private void cbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCarrera.SelectedValue.ToString() != null)
            {
                string id_carrera = cbCarrera.SelectedValue.ToString();
                LlenarComboGrado(id_carrera);
            }
        }

        private void BtnBuscarAlumno_Click(object sender, EventArgs e)
        {
            Vista_Inscripcion ver = new Vista_Inscripcion();
            ver.Show();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdInscripcion.Text.Equals(""))
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
