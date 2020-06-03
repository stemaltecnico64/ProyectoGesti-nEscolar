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

        SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuelaComercio; Integrated Security = true ");


        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarTablaUsurios()
        {
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
            SqlDataAdapter DP = new SqlDataAdapter("Select * from listado_usuarios where Código like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Usuarios.DataSource = dt;

        }

        private void BuscarEmpleado()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from listado_usuarios where Empleado like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Usuarios.DataSource = dt;

        }

        private void BuscarNivel()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from listado_usuarios where Nivel like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Usuarios.DataSource = dt;

        }

        private void BuscarUsuario()
        {
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Tabla_Usuarios.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Borrar este Usuario", "SEGURIDAD DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    try
                    {
                        string cmd = string.Format("Execute Delete_Usuario '{0}'", Convert.ToInt32(Tabla_Usuarios.Rows[Tabla_Usuarios.CurrentRow.Index].Cells[0].Value.ToString()));
                        Login.Conexion_GX(cmd);
                        MessageBox.Show("El Usuario se ha Borrado..!");
                        cargarTablaUsurios();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un Error!" + error);
                    }
                }
            }
        }
    }
}
