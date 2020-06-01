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
    public partial class Editar_Usuario_normal : Form
    {
        public Editar_Usuario_normal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editar_Usuario_normal_Load(object sender, EventArgs e)
        {
            string cmd = "select * from USUARIOS where ID_USUARIO=" + Login.ID_USER;

            DataSet DS = Login.Conexion_GX(cmd);

            txtId.Text = DS.Tables[0].Rows[0]["ID_USUARIO"].ToString();
            txt_nombre_usuario.Text = DS.Tables[0].Rows[0]["NOMBRE_USUARIO"].ToString();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_NuevoNombre.Text == "")
            {
                MessageBox.Show("Ha ocurrido un Error!, Debe Ingresar un Nuevo Nombre de Usuario");
            }
            else
            {
                try
                {
                    string cmd = string.Format("Execute actualizar_nombre_Usuario '{0}','{1}'", Convert.ToInt32(txtId.Text), txt_NuevoNombre.Text);
                    Login.Conexion_GX(cmd);
                    MessageBox.Show("Nombre de Usuario Actualizado Exitosamente..!");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un Error!" + error);
                }
            }
            
        }
    }
}
