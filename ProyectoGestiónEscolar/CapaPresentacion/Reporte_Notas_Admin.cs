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
    public partial class Reporte_Notas_Admin : Form
    {
        public Reporte_Notas_Admin()
        {
            InitializeComponent();
        }

        private void Tabla_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cargarTablaNotas()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            con.Open();
            SqlDataAdapter DP = new SqlDataAdapter("Select * from listado_notas", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Notas.DataSource = dt;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reporte_Notas_Admin_Load(object sender, EventArgs e)
        {
            cargarTablaNotas();
            txtBuscar.Focus();
            cbBuscar.SelectedIndex = 0;
        }

        private void BuscarCurso()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from listado_notas where Curso like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Notas.DataSource = dt;

        }
        private void BuscarGrado()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from listado_notas where Grado like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Notas.DataSource = dt;

        }
        private void BuscarCarrera()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from listado_notas where Carrera like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Notas.DataSource = dt;

        }

        private void BuscarMaestro()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from listado_notas where Maestro like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Notas.DataSource = dt;

        }

        private void BuscarAlumno()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from listado_notas where Alumno like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Notas.DataSource = dt;

        }

        private void BuscarCiclo()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from listado_notas where Ciclo like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Notas.DataSource = dt;

        }

        private void BuscarSeccion()
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            SqlDataAdapter DP = new SqlDataAdapter("Select * from listado_notas where Sección like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Notas.DataSource = dt;

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Maestro"))
            {
                BuscarMaestro();
            }
            else if (cbBuscar.Text.Equals("Carrera"))
            {
                BuscarCarrera();
            }
            else if (cbBuscar.Text.Equals("Grado"))
            {
                BuscarGrado();
            }
            else if (cbBuscar.Text.Equals("Curso"))
            {
                BuscarCurso();
            }
            else if (cbBuscar.Text.Equals("Alumno"))
            {
                BuscarAlumno();
            }
            else if (cbBuscar.Text.Equals("Ciclo"))
            {
                BuscarCiclo();
            }
            else if (cbBuscar.Text.Equals("Sección"))
            {
                BuscarSeccion();
            }
        }

        private void Tabla_Notas_DoubleClick(object sender, EventArgs e)
        {
            if(Tabla_Notas.CurrentRow.Index != 1)
            {
                txtIdNota.Text = Tabla_Notas.CurrentRow.Cells[0].Value.ToString();
                txtCiclo.Text = Tabla_Notas.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = Tabla_Notas.CurrentRow.Cells[2].Value.ToString();
                txtCarrera.Text = Tabla_Notas.CurrentRow.Cells[3].Value.ToString();
                txtGrado.Text = Tabla_Notas.CurrentRow.Cells[4].Value.ToString();
                txtSeccion.Text = Tabla_Notas.CurrentRow.Cells[5].Value.ToString();
                txtCurso.Text = Tabla_Notas.CurrentRow.Cells[7].Value.ToString();
                txtNota1.Text = Tabla_Notas.CurrentRow.Cells[8].Value.ToString();
                txtNota2.Text = Tabla_Notas.CurrentRow.Cells[9].Value.ToString();
                txtNota3.Text = Tabla_Notas.CurrentRow.Cells[10].Value.ToString();
                txtNota4.Text = Tabla_Notas.CurrentRow.Cells[11].Value.ToString();
                txtPromedio.Text = Tabla_Notas.CurrentRow.Cells[12].Value.ToString();
                txtNota1.Focus();
            }
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Double n1 = Convert.ToDouble(txtNota1.Text);
            Double n2 = Convert.ToDouble(txtNota2.Text);
            Double n3 = Convert.ToDouble(txtNota3.Text);
            Double n4 = Convert.ToDouble(txtNota4.Text);
            Double p = 0;

            if (n1 >= 0.01 && n2 <= 0.00 && n3 <= 0.00 && n4 <= 0.00)
            {
                p = n1;
                try
                {
                    string cmd = string.Format("Execute Actualizar_Notas '{0}','{1}','{2}','{3}','{4}','{5}'", Convert.ToInt32(txtIdNota.Text),n1,n2,n3,n4,p);
                    Conexion_GX(cmd);
                    MessageBox.Show("Se Guardado la Nota Exitosamente..!");
                    cargarTablaNotas();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un Error!" + error);
                }
            }
            else if (n1 >= 0.01 && n2 >= 0.01 && n3 <= 0.00 && n4 <= 0.00)
            {
                p = (n1+n2)/2;
                try
                {
                    string cmd = string.Format("Execute Actualizar_Notas '{0}','{1}','{2}','{3}','{4}','{5}'", Convert.ToInt32(txtIdNota.Text), n1, n2, n3, n4, p);
                    Conexion_GX(cmd);
                    MessageBox.Show("Se Guardado la Nota Exitosamente..!");
                    cargarTablaNotas();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un Error!" + error);
                }
            }
            else if (n1 >= 0.01 && n2 >= 0.01 && n3 >= 0.01 && n4 <= 0.00)
            {
                p = (n1+n2+n3)/3;
                try
                {
                    string cmd = string.Format("Execute Actualizar_Notas '{0}','{1}','{2}','{3}','{4}','{5}'", Convert.ToInt32(txtIdNota.Text), n1, n2, n3, n4, p);
                    Conexion_GX(cmd);
                    MessageBox.Show("Se Guardado la Nota Exitosamente..!");
                    cargarTablaNotas();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un Error!" + error);
                }
            }
            else if (n1 >= 0.01 && n2 >= 0.01 && n3 >= 0.01 && n4 >= 0.01)
            {
                p = (n1+n2+n3+n4)/4;
                try
                {
                    string cmd = string.Format("Execute Actualizar_Notas '{0}','{1}','{2}','{3}','{4}','{5}'", Convert.ToInt32(txtIdNota.Text), n1, n2, n3, n4, p);
                    Conexion_GX(cmd);
                    MessageBox.Show("Se Guardado la Nota Exitosamente..!");
                    cargarTablaNotas();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un Error!" + error);
                }
            }
            else if (n4 >= 0.01)
            {
                MessageBox.Show("Debe Ingresar Notas en el Bloque 1, 2  y 3..!");
            }
            else if (n3 >= 0.01 && n4 >= 0.01)
            {
                MessageBox.Show("Debe Ingresar Notas en el Bloque 1 y 2..!");
            }
            else if (n2 >= 0.01 && n3 >= 0.01 && n4 >= 0.01)
            {
                MessageBox.Show("Debe Ingresar una Nota en el Bloque 1..!");
            }

        }
    }
}
