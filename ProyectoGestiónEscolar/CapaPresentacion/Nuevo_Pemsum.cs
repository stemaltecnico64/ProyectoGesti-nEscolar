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
    public partial class Nuevo_Pemsum : Form
    {
        public Nuevo_Pemsum()
        {
            InitializeComponent();
            LlenarComboCarrera();
            LlenarComboPeriodos();
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

        private void LlenarComboCarrera()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id_Carrera, Nombre from Carrera", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione una Carrera";
            dt.Rows.InsertAt(fila, 0);

            cbCarrera.ValueMember = "Id_Carrera";
            cbCarrera.DisplayMember = "Nombre";
            cbCarrera.DataSource = dt;
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

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCarrera.SelectedValue.ToString() != null)
            {
                string id_carrera = cbCarrera.SelectedValue.ToString();
                LlenarComboGrado(id_carrera);
            }
        }

        public static int cont_fila = 0;
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            bool existe = true;
            int num_fila = 0;

            if (cont_fila == 0)
            {
                Tabla_Usuarios.Rows.Add(txtCurso.Text, cbCarrera.SelectedValue, cbGrado.SelectedValue, cbPeriodos.SelectedValue);

                cont_fila++;
            }
            else
            {
                foreach (DataGridViewRow Fila in Tabla_Usuarios.Rows)
                {
                    existe = true;
                    num_fila = Fila.Index;
                }

                if (existe == true)
                {
                    Tabla_Usuarios.Rows[num_fila].Cells[3].Value = cbPeriodos.SelectedValue;
                }
                else
                {
                    Tabla_Usuarios.Rows.Add(txtCurso.Text, cbCarrera.SelectedValue, cbGrado.SelectedValue, cbPeriodos.SelectedValue);

                    cont_fila++;

                }
            }
        }
    }
}
