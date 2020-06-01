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
    public partial class Smenu_Usuarios : Form
    {
        public Smenu_Usuarios()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Editar_Usuario_normal eun = new Editar_Usuario_normal();
            eun.Show();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Cambiar_Contra_Usuario_Normal cu = new Cambiar_Contra_Usuario_Normal();
            cu.Show();
        }
        
        private void datos_empleados()
        {
            string cmd = "select ID_EMPLEADO, CONCAT(NOMBRE_1, ' ', NOMBRE_2, ' ', APELLIDO_1, ' ', APELLIDO_2) as Empleado, FOTO from EMPLEADOS where ID_EMPLEADO=" + Login.ID_EMPLEADO;

            DataSet DS = Login.Conexion_GX(cmd);

            lblCodigoE.Text = DS.Tables[0].Rows[0]["ID_EMPLEADO"].ToString();
            lblNombre.Text = DS.Tables[0].Rows[0]["Empleado"].ToString();

            string url = DS.Tables[0].Rows[0]["FOTO"].ToString();

            pictureBox1.Image = Image.FromFile(url);
        }

        private void datos_usuarios()
        {
            string cmd = "select * from USUARIOS where ID_USUARIO=" + Login.ID_USER;

            DataSet DS = Login.Conexion_GX(cmd);

            lblCodigoU.Text = DS.Tables[0].Rows[0]["ID_USUARIO"].ToString();
            lblNombreU.Text = DS.Tables[0].Rows[0]["NOMBRE_USUARIO"].ToString();
        }

        private void Smenu_Usuarios_Load(object sender, EventArgs e)
        {
            datos_empleados();
            datos_usuarios();
        }
    }
}
