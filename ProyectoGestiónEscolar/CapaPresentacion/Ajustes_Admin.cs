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
    public partial class Ajustes_Admin : Form
    {
        public Ajustes_Admin()
        {
            InitializeComponent();
            OpenChilForm(new Smenu_Usuarios());
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
            OpenChilForm(new ConfigDepartamento());
        }

        private void btn_alumnos_Click(object sender, EventArgs e)
        {
            OpenChilForm(new ConfigMunicipio());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChilForm(new ConfigTipoEncargado());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Smenu_Usuarios());
        }
    }
}
