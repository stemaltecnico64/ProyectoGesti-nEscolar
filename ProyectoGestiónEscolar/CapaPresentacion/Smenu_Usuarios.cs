using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Smenu_Usuarios_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Empleados where ID_EMPLEADO=" + Login.ID_EMPLEADO;

            DataSet DS = Login.Conexion_GX(cmd);


        }
    }
}
