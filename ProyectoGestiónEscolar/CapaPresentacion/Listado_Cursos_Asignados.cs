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
    public partial class Listado_Cursos_Asignados : Form
    {
        public Listado_Cursos_Asignados()
        {
            InitializeComponent();
        }

        public static DataSet Conexion_GX1(string cmd)
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);

            DP.Fill(DS);

            con.Close();

            return DS;
        }
        private void BuscarCurso()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_cursos_a_empleados where Curso like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Cursos_A.DataSource = dt;

        }
        private void BuscarGrado()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_cursos_a_empleados where Grado like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Cursos_A.DataSource = dt;

        }
        private void BuscarCarrera()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_cursos_a_empleados where Carrera like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Cursos_A.DataSource = dt;

        }

        private void BuscarMaestro()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_cursos_a_empleados where Maestro like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Cursos_A.DataSource = dt;

        }
        private void cargarTablaCursos_Asignados()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            con.Open();
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_cursos_a_empleados", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Cursos_A.DataSource = dt;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listado_Cursos_Asignados_Load(object sender, EventArgs e)
        {
            cargarTablaCursos_Asignados();
            txtBuscar.Focus();
            cbBuscar.SelectedIndex = 0;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Maestro"))
            {
                BuscarMaestro();
            }
            else if (cbBuscar.Text.Equals("Carrera"))
            {
                BuscarCarrera();
            }
            else if (cbBuscar.Text.Equals("Grado"))
            {
                BuscarGrado();
            }
            else if (cbBuscar.Text.Equals("Curso"))
            {
                BuscarCurso();
            }
        }

        private void Tabla_Cursos_A_DoubleClick(object sender, EventArgs e)
        {
            if (Tabla_Cursos_A.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
