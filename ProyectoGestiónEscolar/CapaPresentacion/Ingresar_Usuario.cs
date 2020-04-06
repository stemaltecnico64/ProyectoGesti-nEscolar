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
    public partial class Ingresar_Usuario : Form
    {
        public Ingresar_Usuario()
        {
            InitializeComponent();
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
    }
}
