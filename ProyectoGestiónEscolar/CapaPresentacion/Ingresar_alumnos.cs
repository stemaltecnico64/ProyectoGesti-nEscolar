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
    public partial class Ingresar_alumnos : Form
    {
        public Ingresar_alumnos()
        {
            InitializeComponent();
        }
        private void btn_agregar_encargado_Click(object sender, EventArgs e)
        {
            Ingresar_Encargado ventanEncargado = new Ingresar_Encargado();
            ventanEncargado.Show();
        }

        private void btn_add_foto_Click(object sender, EventArgs e)
        {
            try
            {
                
                openFileDialog1.Title = "Seleccione una Foto";
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("")==false)
                {
                    pictureBox1.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la Imagen");
            }
        }
    }
}
