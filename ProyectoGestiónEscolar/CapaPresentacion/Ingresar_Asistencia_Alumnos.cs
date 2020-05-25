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
    public partial class Ingresar_Asistencia_Alumnos : Form
    {
        public Ingresar_Asistencia_Alumnos()
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
        private void Ingresar_Asistencia_Alumnos_Load(object sender, EventArgs e)
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

        private void btnBuscarEncargado_Click(object sender, EventArgs e)
        {
            Listado_Inscripciones_Admin li = new Listado_Inscripciones_Admin();
            li.ShowDialog();

            if (li.DialogResult == DialogResult.OK)
            {
                txtCodigo.Text = li.Tabla_Inscripciones.Rows[li.Tabla_Inscripciones.CurrentRow.Index].Cells[0].Value.ToString();
                txtSeccion.Text = li.Tabla_Inscripciones.Rows[li.Tabla_Inscripciones.CurrentRow.Index].Cells[8].Value.ToString();
                txtCarrera.Text = li.Tabla_Inscripciones.Rows[li.Tabla_Inscripciones.CurrentRow.Index].Cells[6].Value.ToString();
                txtGrado.Text = li.Tabla_Inscripciones.Rows[li.Tabla_Inscripciones.CurrentRow.Index].Cells[7].Value.ToString();
                txtAlumno.Text = li.Tabla_Inscripciones.Rows[li.Tabla_Inscripciones.CurrentRow.Index].Cells[5].Value.ToString();
                txtCiclo.Text = li.Tabla_Inscripciones.Rows[li.Tabla_Inscripciones.CurrentRow.Index].Cells[3].Value.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("Execute insertar_asistencia_alumno '{0}'", Convert.ToInt32(txtCodigo.Text));
                Conexion_GX(cmd);
                MessageBox.Show("Asistencia del Alumno Guardada Exitosamente..!");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un Error!" + error);
            }
        }
    }
}
