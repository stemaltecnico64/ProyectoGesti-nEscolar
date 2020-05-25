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
           
        }

        SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");

        private void LlenarComboPeriodos()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id_Periodo, Cantidad from Periodos_Escolares", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["Cantidad"] = "Numero de Periodos a Impartir";
            dt.Rows.InsertAt(fila, 0);

            cbPeriodos.ValueMember = "Id_Periodo";
            cbPeriodos.DisplayMember = "Cantidad";
            cbPeriodos.DataSource = dt;
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
        private void LlenarComboGrado(string id_carrera)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id_Carrera, Nombre from Grado where Id_Carrera = @Id_Carrera", con);
            cmd.Parameters.AddWithValue("Id_Carrera", id_carrera);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione un Grado";
            dt.Rows.InsertAt(fila, 0);

            cbGrado.ValueMember = "Id_Carrera";
            cbGrado.DisplayMember = "Nombre";
            cbGrado.DataSource = dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
