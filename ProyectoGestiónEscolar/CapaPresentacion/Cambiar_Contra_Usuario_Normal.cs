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
    public partial class Cambiar_Contra_Usuario_Normal : Form
    {
        public Cambiar_Contra_Usuario_Normal()
        {
            InitializeComponent();
        }

        private void Cambiar_Contra_Usuario_Normal_Load(object sender, EventArgs e)
        {
            string cmd = "select * from USUARIOS where ID_USUARIO=" + Login.ID_USER;

            DataSet DS = Login.Conexion_GX(cmd);

            txtId.Text = DS.Tables[0].Rows[0]["ID_USUARIO"].ToString();
            txt_password.Text = DS.Tables[0].Rows[0]["PASSWORD_USUARIO"].ToString();

            txt_password.isPassword = true;

            txtNuevoPass.isPassword = true;
            txtConfirmarPass.isPassword = true;

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txtNuevoPass.Text == "" && txtConfirmarPass.Text == "")
            {
                MessageBox.Show("Ha ocurrido un Error!, Debe Ingresar una Nueva contraseña");
            }
            else if (txtConfirmarPass.Text != txtNuevoPass.Text)
            {
                MessageBox.Show("Ha ocurrido un Error!, Las Contraseñas no Coinciden");
            }
            else if (txtConfirmarPass.Text == txtNuevoPass.Text)
            {
                try
                {
                    string cmd = string.Format("Execute actualizar_contra_Usuario '{0}','{1}'", Convert.ToInt32(txtId.Text), txtConfirmarPass.Text);
                    Login.Conexion_GX(cmd);
                    MessageBox.Show("Contraseña Actualizado Exitosamente..!");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un Error!" + error);
                }
            }
        }

        private void btn_mostrar1_Click(object sender, EventArgs e)
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

        private void btn_mostrar2_Click(object sender, EventArgs e)
        {
            if (txtNuevoPass.isPassword == true)
            {
                txtNuevoPass.isPassword = false;
            }
            else if (txtNuevoPass.isPassword == false)
            {
                txtNuevoPass.isPassword = true;
            }
        }

        private void btn_mostrar3_Click(object sender, EventArgs e)
        {
            if (txtConfirmarPass.isPassword == true)
            {
                txtConfirmarPass.isPassword = false;
            }
            else if (txtConfirmarPass.isPassword == false)
            {
                txtConfirmarPass.isPassword = true;
            }
        }
    }
}
