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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            OpenChilForm(new Menu_Inicio());
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        private Form activeForm = null;
        private void OpenChilForm(Form ChildForm)
        {
            if (activeForm != null)
               activeForm.Close();
            
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            DesktopPanel.Controls.Add(ChildForm);
            DesktopPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
                       
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Menu_Inicio());
        }

        private void btn_alumnos_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Menu_Alumnos());
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Menu_Empleados());
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Menu_Usuarios());
        }
    }
}
