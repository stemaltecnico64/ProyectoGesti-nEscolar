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
        }
    }
}
