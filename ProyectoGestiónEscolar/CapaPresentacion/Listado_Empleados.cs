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
    public partial class Listado_Empleados : Form
    {
        public Listado_Empleados()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarTablaEmpleados()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            con.Open();
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_empleados", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Empleados.DataSource = dt;
        }

        private void Listado_Empleados_Load(object sender, EventArgs e)
        {
            cargarTablaEmpleados();
            txtBuscar.Focus();
            cbBuscar.SelectedIndex = 0;
        }

        private void BuscarCodigo()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_empleados where Código like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Empleados.DataSource = dt;

        }

        private void BuscarDPI()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_empleados where DPI like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Empleados.DataSource = dt;

        }

        private void BuscarEmpleado()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_empleados where Empleado like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Empleados.DataSource = dt;

        }

        private void BuscarDireccion()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_empleados where DIRECCION like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Empleados.DataSource = dt;

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Código"))
            {
                BuscarCodigo();
            }
            else if (cbBuscar.Text.Equals("DPI"))
            {
                BuscarDPI();
            }
            else if (cbBuscar.Text.Equals("Empleado"))
            {
                BuscarEmpleado();
            }
            else if (cbBuscar.Text.Equals("Dirección"))
            {
                BuscarDireccion();
            }
        }

        private void Tabla_Empleados_DoubleClick(object sender, EventArgs e)
        {
            if (Tabla_Empleados.Rows.Count == 0)
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
