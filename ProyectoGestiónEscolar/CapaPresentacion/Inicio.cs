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
            lblTitle.Text = "Inicio";
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
            lblTitle.Text = "Inicio";
        }

        private void btn_alumnos_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Menu_Alumnos());
            lblTitle.Text = "Alumnos";
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Menu_Empleados());
            lblTitle.Text = "Empleados";
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Menu_Usuarios());
            lblTitle.Text = "Usuarios";
        }

        private void btn_pensum_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Menu_Pensum());
            lblTitle.Text = "Pensum";
        }

        private void btn_asistencia_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Menu_Asistencia());
            lblTitle.Text = "Asistencia";
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Menu_reportes());
            lblTitle.Text = "Reportes";
        }
    }
}
