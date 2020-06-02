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
    public partial class Listado_Maestros : Form
    {
        public Listado_Maestros()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuelaComercio; Integrated Security = true ");

        public void cargarTablaMaestros()
        {
            con.Open();
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_maestros", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Maestros.DataSource = dt;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tabla_Cursos_DoubleClick(object sender, EventArgs e)
        {
            if (Tabla_Maestros.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        
        private void Listado_Maestros_Load_1(object sender, EventArgs e)
        {
            cargarTablaMaestros();
            txtBuscar.Focus();
            cbBuscar.SelectedIndex = 1;
        }

        private void BuscarDPI()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_maestros where DPI like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Maestros.DataSource = dt;

        }

        private void BuscarMaestro()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_maestros where Maestro like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Maestros.DataSource = dt;

        }

        private void BuscarCodigo()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_maestros where Código like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Maestros.DataSource = dt;

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
            else if (cbBuscar.Text.Equals("Maestro"))
            {
                BuscarMaestro();
            }
        }
    }
}
