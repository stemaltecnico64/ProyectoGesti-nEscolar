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
    public partial class Listado_Inscripciones_Admin : Form
    {
        public Listado_Inscripciones_Admin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuelaComercio; Integrated Security = true ");


        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarTablaInscripciones()
        {
            con.Open();
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_inscripciones", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Inscripciones.DataSource = dt;
        }

        private void Listado_Inscripciones_Admin_Load(object sender, EventArgs e)
        {
            cargarTablaInscripciones();
            txtBuscar.Focus();
            cbBuscar.SelectedIndex = 0;
        }

        private void BuscarCodigo()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_inscripciones where CodigoEscolar like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Inscripciones.DataSource = dt;

        }

        private void BuscarAlumno()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_inscripciones where Alumno like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Inscripciones.DataSource = dt;

        }

        private void BuscarCarrera()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_inscripciones where Carrera like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Inscripciones.DataSource = dt;

        }

        private void BuscarGrado()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_inscripciones where Grado like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Inscripciones.DataSource = dt;

        }

        private void BuscarSeccion()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_inscripciones where Sección like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Inscripciones.DataSource = dt;

        }

        private void BuscarCiclo()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_inscripciones where Ciclo like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Inscripciones.DataSource = dt;

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Codigo Escolar"))
            {
                BuscarCodigo();
            }
            else if (cbBuscar.Text.Equals("Alumno"))
            {
                BuscarAlumno();
            }
            else if (cbBuscar.Text.Equals("Carrera"))
            {
                BuscarCarrera();
            }
            else if (cbBuscar.Text.Equals("Grado"))
            {
                BuscarGrado();
            }
            else if (cbBuscar.Text.Equals("Sección"))
            {
                BuscarSeccion();
            }
            else if (cbBuscar.Text.Equals("Ciclo"))
            {
                BuscarCiclo();
            }

        }

        private void Tabla_Inscripciones_DoubleClick(object sender, EventArgs e)
        {
            if (Tabla_Inscripciones.Rows.Count == 0)
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
