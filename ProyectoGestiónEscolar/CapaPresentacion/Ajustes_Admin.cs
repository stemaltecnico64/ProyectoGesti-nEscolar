using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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

        private void btn_Departamentos_Click(object sender, EventArgs e)
        {
            OpenChilForm(new ConfigDepartamento());
        }

        private void btn_municipios_Click(object sender, EventArgs e)
        {
            OpenChilForm(new ConfigMunicipio());
        }

        private void btn_encargados_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_cuenta_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Smenu_Usuarios());
        }

        private void btn_puestos_Click(object sender, EventArgs e)
        {
            OpenChilForm(new ConfigPuestos());
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ciclo_Click(object sender, EventArgs e)
        {
            OpenChilForm(Cierre_Ciclo.GetInstancia()); 
        }

        private void btn_inscripcion_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Agregar_Tipo_Inscripcion());
        }
    }
}
