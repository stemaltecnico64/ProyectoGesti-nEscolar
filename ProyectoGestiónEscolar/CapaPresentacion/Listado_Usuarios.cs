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
    public partial class Listado_Usuarios : Form
    {
        public Listado_Usuarios()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarTablaUsurios()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            con.Open();
            SqlDataAdapter DP = new SqlDataAdapter("Select * from listado_usuarios", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Usuarios.DataSource = dt;
        }

        private void Listado_Usuarios_Load(object sender, EventArgs e)
        {
            cargarTablaUsurios();
            txtBuscar.Focus();
            cbBuscar.SelectedIndex = 0;
        }

        private void Tabla_Usuarios_DoubleClick(object sender, EventArgs e)
        {
            if (Tabla_Usuarios.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void BuscarCodigo()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from listado_usuarios where Código like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Usuarios.DataSource = dt;

        }

        private void BuscarEmpleado()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from listado_usuarios where Empleado like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Usuarios.DataSource = dt;

        }

        private void BuscarNivel()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from listado_usuarios where Nivel like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Usuarios.DataSource = dt;

        }

        private void BuscarUsuario()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from listado_usuarios where NOMBRE_USUARIO like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Usuarios.DataSource = dt;

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Código"))
            {
                BuscarCodigo();
            }
            else if (cbBuscar.Text.Equals("Usuario"))
            {
                BuscarUsuario();
            }
            else if (cbBuscar.Text.Equals("Empleado"))
            {
                BuscarEmpleado();
            }
            else if (cbBuscar.Text.Equals("Nivel"))
            {
                BuscarNivel();
            }
        }
    }
}
