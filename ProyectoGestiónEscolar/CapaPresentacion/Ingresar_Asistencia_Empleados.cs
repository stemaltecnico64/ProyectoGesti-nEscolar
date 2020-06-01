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
    public partial class Ingresar_Asistencia_Empleados : Form
    {
        public Ingresar_Asistencia_Empleados()
        {
            InitializeComponent();
        }

        public static DataSet Conexion_GX(string cmd)
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);

            DP.Fill(DS);

            con.Close();

            return DS;
        }

        private void Ingresar_Asistencia_Empleados_Load(object sender, EventArgs e)
        {
            dtFechaNac.Enabled = false;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer_Fecha_Hora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("Execute insertar_asistencia_empleados '{0}'", Convert.ToInt32(txtCodigo.Text));
                Conexion_GX(cmd);
                MessageBox.Show("Asistencia del Empleado Guardada Exitosamente..!");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un Error!" + error);
            }
        }

        private void btnBuscarEncargado_Click(object sender, EventArgs e)
        {
            Listado_Empleados le = new Listado_Empleados();
            le.ShowDialog();

            if (le.DialogResult == DialogResult.OK)
            {
                txtCodigo.Text = le.Tabla_Empleados.Rows[le.Tabla_Empleados.CurrentRow.Index].Cells[0].Value.ToString();
                txtempleado.Text = le.Tabla_Empleados.Rows[le.Tabla_Empleados.CurrentRow.Index].Cells[2].Value.ToString();
                txtpuesto.Text = le.Tabla_Empleados.Rows[le.Tabla_Empleados.CurrentRow.Index].Cells[5].Value.ToString();
                txtdpi.Text = le.Tabla_Empleados.Rows[le.Tabla_Empleados.CurrentRow.Index].Cells[1].Value.ToString();
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("Execute insertar_asistencia_empleados '{0}'", Convert.ToInt32(txtCodigo.Text));
                Conexion_GX(cmd);
                MessageBox.Show("Asistencia del Empleado Guardada Exitosamente..!");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un Error!" + error);
            }
        }
    }
}
