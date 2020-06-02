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
    public partial class Ingresar_Usuario : Form
    {
        public Ingresar_Usuario()
        {
            InitializeComponent();
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

        SqlConnection con = new SqlConnection("Data Source = DESKTOP-NPN78EM; Initial Catalog = BDEscuelaComercio; Integrated Security = true ");

        private void LlenarComboNivelU()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from NIVELES_USUARIOS", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["NIVEL_USUARIO"] = "Seleccione un Nivel de Usuario";
            dt.Rows.InsertAt(fila, 0);

            cbNivelU.ValueMember = "ID_NIVEL_USUARIO";
            cbNivelU.DisplayMember = "NIVEL_USUARIO";
            cbNivelU.DataSource = dt;
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            if (txt_password.isPassword == true)
            {
                txt_password.isPassword = false;
            }
            else if (txt_password.isPassword == false)
            {
                txt_password.isPassword = true;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ingresar_Usuario_Load(object sender, EventArgs e)
        {
            inahabilitar();
        }

        private void inahabilitar()
        {
            txtId.Enabled = false;
            txt_nombre_usuario.Enabled = false;
            txt_password.Enabled = false;
            cbNivelU.Enabled = false;
            btn_guardar.Enabled = false;
            txtcodigoE.Enabled = false;
            txtnombreMaestro.Enabled = false;
            txtdpi.Enabled = false;
        }

        private void Limpiar()
        {
            this.txtId.Text = string.Empty;
            this.txt_nombre_usuario.Text = string.Empty;
            this.txt_password.Text = string.Empty;
            this.cbNivelU.Text = string.Empty;
            this.txtcodigoE.Text = string.Empty;
            this.txtnombreMaestro.Text = string.Empty;
            this.txtdpi.Text = string.Empty;
        }

        private void habilitar()
        {
            txt_nombre_usuario.Enabled = true;
            txt_password.Enabled = true;
            cbNivelU.Enabled = true;
            btn_guardar.Enabled = true;
            txtcodigoE.Enabled = true;
            txtnombreMaestro.Enabled = true;
            txtdpi.Enabled = true;
            LlenarComboNivelU();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar();
            txt_nombre_usuario.Focus();
        }

        private void txt_nombre_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_password.Focus();
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                cbNivelU.Focus();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("Execute insertar_usuarios '{0}','{1}','{2}','{3}'", txt_nombre_usuario.Text,txt_password.Text,Convert.ToInt32(cbNivelU.SelectedValue),Convert.ToInt32(txtcodigoE.Text));
                Login.Conexion_GX(cmd);
                MessageBox.Show("Se ha Guardado el Usuario Exitosamente..!");
                this.Limpiar();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un Error!" + error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Listado_Empleados lm = new Listado_Empleados();
            lm.ShowDialog();

            if (lm.DialogResult == DialogResult.OK)
            {
                txtcodigoE.Text = lm.Tabla_Empleados.Rows[lm.Tabla_Empleados.CurrentRow.Index].Cells[0].Value.ToString();
                txtdpi.Text = lm.Tabla_Empleados.Rows[lm.Tabla_Empleados.CurrentRow.Index].Cells[1].Value.ToString();
                txtnombreMaestro.Text = lm.Tabla_Empleados.Rows[lm.Tabla_Empleados.CurrentRow.Index].Cells[2].Value.ToString();
            }
        }
    }
}
