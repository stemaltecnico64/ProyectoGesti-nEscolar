﻿using System;
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
    public partial class ConfigPuestos : Form
    {
        private bool IsNuevo = false;

        private bool IsEditar = false;
        public ConfigPuestos()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtPuestos, "Ingrese el nombre de un puesto");
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
            this.txtIdPuestos.Text = string.Empty;
            this.txtPuestos.Text = string.Empty;
        }


        private void Habilitar(bool valor)
        {
            this.txtIdPuestos.ReadOnly = !valor;
        }


        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }

        }

        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
        }
        private void Mostrar()
        {
            this.dataListado.DataSource = NPuesto.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NPuesto.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void ConfigPuestos_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.txtBuscar.Focus();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtPuestos.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtPuestos.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtPuestos, "Ingrese un Nombre");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NPuesto.Insertar(this.txtPuestos.Text);
                    }
                    else
                    {
                        rpta = NPuesto.Editar(Convert.ToInt32(this.txtIdPuestos.Text), this.txtPuestos.Text);
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
                    this.Mostrar();
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdPuestos.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdPuestos.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["ID_PUESTO"].Value);
            this.txtPuestos.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["PUESTO"].Value);

            this.tabControl1.SelectedIndex = 1;
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
