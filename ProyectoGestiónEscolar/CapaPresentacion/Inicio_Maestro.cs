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
    public partial class Inicio_Maestro : Form
    {
        public Inicio_Maestro()
        {
            InitializeComponent();
            OpenChilForm(new Menu_Inicio());
            this.Text = string.Empty;
            this.ControlBox = false;
            lblTitle.Text = "Inicio";
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            btn_restaurar.Hide();
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
        private void btn_inicio_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Menu_Inicio());
            lblTitle.Text = "Inicio";
        }

        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_restaurar.Show();
            btn_maximizar.Hide();
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_maximizar.Show();
            btn_restaurar.Hide();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
