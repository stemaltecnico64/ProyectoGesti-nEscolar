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

namespace CapaPresentacion
{
    public partial class Crear_Asignacion_Cursos : Form
    {
        public Crear_Asignacion_Cursos()
        {
            InitializeComponent();
            LlenarComboCarrera();
            LlenarComboSeccion();
        }

        SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuelaComercio; Integrated Security = true ");


        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            fila["Nombre"] = "Eliga la Carrera del Curso";
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

        private void LlenarComboCurso(string id_grado)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select ID_CURSO, NOMBRE from Cursos where ID_GRADO = @Id_grado", con);
            cmd.Parameters.AddWithValue("ID_GRADO", id_grado);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["NOMBRE"] = "Seleccione un Curso";
            dt.Rows.InsertAt(fila, 0);

            cbCurso.ValueMember = "ID_CURSO";
            cbCurso.DisplayMember = "NOMBRE";
            cbCurso.DataSource = dt;
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
            fila["Nombre"] = "Seleccione una Seccion";
            dt.Rows.InsertAt(fila, 0);

            cbSeccion.ValueMember = "Id_Seccion";
            cbSeccion.DisplayMember = "Nombre";
            cbSeccion.DataSource = dt;
        }

        

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbGrado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbGrado.SelectedValue.ToString() != null)
            {
                string id_grado = cbGrado.SelectedValue.ToString();
                LlenarComboCurso(id_grado);
            }
        }

        private void cbCarrera_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbCarrera.SelectedValue.ToString() != null)
            {
                string id_carrera = cbCarrera.SelectedValue.ToString();
                LlenarComboGrado(id_carrera);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("Execute insertar_cursos_empleados '{0}','{1}','{2}'", Convert.ToInt32(txtcodigo.Text), Convert.ToInt32(cbCurso.SelectedValue), Convert.ToInt32(cbSeccion.SelectedValue));
                Login.Conexion_GX(cmd);
                MessageBox.Show("Asignación Guardada Exitosamente..!");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un Error!" + error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Listado_Maestros lm = new Listado_Maestros();
            lm.ShowDialog();

            if (lm.DialogResult == DialogResult.OK)
            {
                txtcodigo.Text = lm.Tabla_Maestros.Rows[lm.Tabla_Maestros.CurrentRow.Index].Cells[0].Value.ToString();
                txtdpi.Text = lm.Tabla_Maestros.Rows[lm.Tabla_Maestros.CurrentRow.Index].Cells[1].Value.ToString();
                txtnombreMaestro.Text= lm.Tabla_Maestros.Rows[lm.Tabla_Maestros.CurrentRow.Index].Cells[2].Value.ToString();
            }
        }

        private void Crear_Asignacion_Cursos_Load(object sender, EventArgs e)
        {

        }
    }
}
