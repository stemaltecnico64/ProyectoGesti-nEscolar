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
    public partial class Cursos_Pensum : Form
    {
        public Cursos_Pensum()
        {
            InitializeComponent();
            LlenarComboPeriodos();
            LlenarComboCarrera();
        }

        SqlConnection con = new SqlConnection("Data Source = DESKTOP-NPN78EM; Initial Catalog = BDEscuelaComercio; Integrated Security = true ");

        private void LlenarComboPeriodos()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id_Periodo, Cantidad from Periodos_Escolares", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["Cantidad"] = "Numero de Periodos a Impartir por Semana";
            dt.Rows.InsertAt(fila, 0);

            cbPeriodos.ValueMember = "Id_Periodo";
            cbPeriodos.DisplayMember = "Cantidad";
            cbPeriodos.DataSource = dt;
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


        public static DataSet Conexion_GX(string cmd)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-NPN78EM; Initial Catalog = BDEscuelaComercio; Integrated Security = true ");
            con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);

            DP.Fill(DS);

            con.Close();

            return DS;
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

        private void Limpiar()
        {
            this.txtCurso.Text = string.Empty;
            this.cbPeriodos.Text = string.Empty;
            this.cbCarrera.Text = string.Empty;
            this.cbGrado.Text = string.Empty;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("Execute insertar_Cursos '{0}','{1}','{2}'", txtCurso.Text.Trim(), Convert.ToInt32(cbGrado.SelectedValue), Convert.ToInt32(cbPeriodos.SelectedValue));
                Conexion_GX(cmd);
                MessageBox.Show("Curso Guardado Exitosamente..!");
                this.Limpiar();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un Error!" + error);
            }
        }

        private void cbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCarrera.SelectedValue.ToString() != null)
            {
                string id_carrera = cbCarrera.SelectedValue.ToString();
                LlenarComboGrado(id_carrera);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
