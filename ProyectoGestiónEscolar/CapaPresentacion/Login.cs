using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txt_password.isPassword = true;
        }

        public static string nivel_x = "";

        public static string ID_USER = "";

        public static string ID_EMPLEADO = "";

        public static string NOMBRE_EMPLEADO = "";


        public static DataSet Conexion_GX(string cmd)
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuelaComercio; Integrated Security = true ");
            con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);

            DP.Fill(DS);

            con.Close();

            return DS;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_usuario.Focus();
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_password.Focus();
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    string CMD = String.Format("Select * from Usuarios where NOMBRE_USUARIO='{0}' and PASSWORD_USUARIO='{1}'", txt_usuario.Text.Trim(), txt_password.Text.Trim());
                    DataSet ds = Conexion_GX(CMD);

                    string usuario = ds.Tables[0].Rows[0]["NOMBRE_USUARIO"].ToString().Trim();
                    string password = ds.Tables[0].Rows[0]["PASSWORD_USUARIO"].ToString().Trim();
                    nivel_x = ds.Tables[0].Rows[0]["ID_NIVEL_USUARIO"].ToString().Trim();
                    ID_USER = ds.Tables[0].Rows[0]["ID_USUARIO"].ToString().Trim();
                    ID_EMPLEADO = ds.Tables[0].Rows[0]["ID_EMPLEADO"].ToString().Trim();

                    datos_empleados();

                    if (nivel_x.Equals("1"))
                    {
                        if (usuario == txt_usuario.Text.Trim() && password == txt_password.Text.Trim())
                        {
                            Pantalla_Carga VenCarga = new Pantalla_Carga();
                            this.Hide();
                            VenCarga.Show();
                        }
                    }
                    else if (nivel_x.Equals("2"))
                    {
                        if (usuario == txt_usuario.Text.Trim() && password == txt_password.Text.Trim())
                        {
                            Pantalla_Carga VenCarga = new Pantalla_Carga();
                            this.Hide();
                            VenCarga.Show();
                        }
                    }
                    else if (nivel_x.Equals("3"))
                    {
                        if (usuario == txt_usuario.Text.Trim() && password == txt_password.Text.Trim())
                        {
                            Pantalla_Carga VenCarga = new Pantalla_Carga();
                            this.Hide();
                            VenCarga.Show();
                        }
                    }
                    else if (nivel_x.Equals("4"))
                    {
                        if (usuario == txt_usuario.Text.Trim() && password == txt_password.Text.Trim())
                        {
                            Pantalla_Carga VenCarga = new Pantalla_Carga();
                            this.Hide();
                            VenCarga.Show();
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta...!");
                }

            }
        }

        private void datos_empleados()
        {
            string cmd = "select ID_EMPLEADO, CONCAT(NOMBRE_1, ' ', NOMBRE_2, ' ', APELLIDO_1, ' ', APELLIDO_2) as Empleado from EMPLEADOS where ID_EMPLEADO=" + ID_EMPLEADO;

            DataSet DS = Conexion_GX(cmd);

            NOMBRE_EMPLEADO= DS.Tables[0].Rows[0]["Empleado"].ToString().Trim();

        }

        private void btn_ingresar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string CMD = String.Format("Select * from Usuarios where NOMBRE_USUARIO='{0}' and PASSWORD_USUARIO='{1}'", txt_usuario.Text.Trim(), txt_password.Text.Trim());
                DataSet ds = Conexion_GX(CMD);

                string usuario = ds.Tables[0].Rows[0]["NOMBRE_USUARIO"].ToString().Trim();
                string password = ds.Tables[0].Rows[0]["PASSWORD_USUARIO"].ToString().Trim();
                nivel_x = ds.Tables[0].Rows[0]["ID_NIVEL_USUARIO"].ToString().Trim();
                ID_USER = ds.Tables[0].Rows[0]["ID_USUARIO"].ToString().Trim();
                ID_EMPLEADO = ds.Tables[0].Rows[0]["ID_EMPLEADO"].ToString().Trim();

                datos_empleados();

                if (nivel_x.Equals("1"))
                {
                    if (usuario == txt_usuario.Text.Trim() && password == txt_password.Text.Trim())
                    {
                        Pantalla_Carga VenCarga = new Pantalla_Carga();
                        this.Hide();
                        VenCarga.Show();
                    }
                }
                else if (nivel_x.Equals("2"))
                {
                    if (usuario == txt_usuario.Text.Trim() && password == txt_password.Text.Trim())
                    {
                        Pantalla_Carga VenCarga = new Pantalla_Carga();
                        this.Hide();
                        VenCarga.Show();
                    }
                }
                else if (nivel_x.Equals("3"))
                {
                    if (usuario == txt_usuario.Text.Trim() && password == txt_password.Text.Trim())
                    {
                        Pantalla_Carga VenCarga = new Pantalla_Carga();
                        this.Hide();
                        VenCarga.Show();
                    }
                }
                else if (nivel_x.Equals("4"))
                {
                    if (usuario == txt_usuario.Text.Trim() && password == txt_password.Text.Trim())
                    {
                        Pantalla_Carga VenCarga = new Pantalla_Carga();
                        this.Hide();
                        VenCarga.Show();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Usuario o Contraseña incorrecta...!");
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
