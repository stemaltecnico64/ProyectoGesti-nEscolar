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
    public partial class Listado_Cursos : Form
    {
        public Listado_Cursos()
        {
            InitializeComponent();
        }

        public void cargarTablaCursos()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            con.Open();
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_cursos", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Cursos.DataSource = dt;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarCurso()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_cursos where Curso like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Cursos.DataSource = dt;

        }
        private void BuscarGrado()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_cursos where Grado like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Cursos.DataSource = dt;

        }
        private void BuscarCarrera()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_cursos where Carrera like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Cursos.DataSource = dt;

        }


        private void Tabla_Cursos_DoubleClick(object sender, EventArgs e)
        {
            if (Tabla_Cursos.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Listado_Cursos_Load(object sender, EventArgs e)
        {
            cargarTablaCursos();
            txtBuscar.Focus();
            cbBuscar.SelectedIndex = 0;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Carrera"))
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
    }
}
