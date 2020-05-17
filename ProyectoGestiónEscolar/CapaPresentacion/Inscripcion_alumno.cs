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
    public partial class Inscripcion_alumno : Form
    {
        private bool IsNuevo = false;
        private static Inscripcion_alumno _instancia;
        public static Inscripcion_alumno GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Inscripcion_alumno();
            }
            return _instancia;
        }
        public Inscripcion_alumno()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombreAlumno, "Ingrese un Alumno");
            this.ttMensaje.SetToolTip(this.txtCui_Alumno, "Ingrese un número del comprobante");
            this.ttMensaje.SetToolTip(this.cbTipo_Inscripcion, "Ingrese la Cantidad del Artículo a Vender");
            this.ttMensaje.SetToolTip(this.txtArticulo, "Seleccione un Artículo");
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevo_alumno_Click(object sender, EventArgs e)
        {
            Ingresar_Alumno ventanalumno =  Ingresar_Alumno.GetInstancia();
            ventanalumno.Show();
        }

        private void Inscripcion_alumno_Load(object sender, EventArgs e)
        {

        }
    }
}
