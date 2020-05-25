using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class Cierre_Ciclo : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        private static Cierre_Ciclo _instancia;
        public static Cierre_Ciclo GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Cierre_Ciclo();
            }
            return _instancia;
        }
        public Cierre_Ciclo()
        {
            InitializeComponent();
        }

        public void SetCierreCiclo(string idciclo, string ciclo, string descripcion, string fecha_g, string estado)
        {
            this.txtId_Ciclo.Text = idciclo;
            this.txtCiclo.Text = ciclo;
            this.txtdes.Text = descripcion;
            this.dtFecha.Text = fecha_g;
            this.cbEstado.Text = estado;
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SEGURIDAD DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SEGURIDAD DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            this.txtId_Ciclo.Text = string.Empty;
            this.txtCiclo.Text = string.Empty;
            this.txtdes.Text = string.Empty;
            this.cbEstado.Text = string.Empty;
            this.dtFecha.Text = string.Empty;
        }


        private void Cierre_Ciclo_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Está seguro de guardar estos datos?", "SEGURIDAD DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string rpta = "";
                    if (this.txtCiclo.Text == string.Empty)
                    {
                        MensajeError("Falta ingresar algunos datos, serán remarcados");
                        errorIcono.SetError(txtCiclo, "Ingrese un Valor");

                    }
                    else
                    {

                        if (this.IsNuevo)
                        {
                            rpta = NCiclo.Insertar(this.txtCiclo.Text, this.txtdes.Text, this.dtFecha.Value, this.cbEstado.Text);

                        }
                        else
                        {
                            rpta = NCiclo.Editar(Convert.ToInt32(this.txtId_Ciclo.Text),
                                this.txtCiclo.Text, this.txtdes.Text, this.dtFecha.Value, this.cbEstado.Text);
                        }

                        if (rpta.Equals("OK"))
                        {
                            if (this.IsNuevo)
                            {
                                this.MensajeOk("Se Insertó de forma correcta el registro");
                            }
                            else
                            {
                                this.MensajeOk("Se Actualizó de forma correcta el registro");
                            }
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }

                        this.IsNuevo = false;
                        this.Limpiar();
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

   

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Lista_Ciclos ver = new Lista_Ciclos();
            ver.ShowDialog();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
