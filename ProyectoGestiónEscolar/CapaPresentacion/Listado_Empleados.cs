﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class Listado_Empleados : Form
    {
        public Listado_Empleados()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuelaComercio; Integrated Security = true ");

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarTablaEmpleados()
        {
            con.Open();
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_empleados", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Empleados.DataSource = dt;
        }

        private void Listado_Empleados_Load(object sender, EventArgs e)
        {
            cargarTablaEmpleados();
            txtBuscar.Focus();
            cbBuscar.SelectedIndex = 0;
        }

        private void BuscarCodigo()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_empleados where Código like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Empleados.DataSource = dt;

        }

        private void BuscarDPI()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_empleados where DPI like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Empleados.DataSource = dt;

        }

        private void BuscarEmpleado()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_empleados where Empleado like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Empleados.DataSource = dt;

        }

        private void BuscarDireccion()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_empleados where Dirección like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Empleados.DataSource = dt;

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Código"))
            {
                BuscarCodigo();
            }
            else if (cbBuscar.Text.Equals("DPI"))
            {
                BuscarDPI();
            }
            else if (cbBuscar.Text.Equals("Empleado"))
            {
                BuscarEmpleado();
            }
            else if (cbBuscar.Text.Equals("Dirección"))
            {
                BuscarDireccion();
            }
        }

        private void Tabla_Empleados_DoubleClick(object sender, EventArgs e)
        {
            if (Tabla_Empleados.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Tabla_Empleados.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Borrar este Colaborador", "SEGURIDAD DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    try
                    {
                        string cmd = string.Format("Execute Delete_Empleado '{0}'", Convert.ToInt32(Tabla_Empleados.Rows[Tabla_Empleados.CurrentRow.Index].Cells[0].Value.ToString()));
                        Login.Conexion_GX(cmd);
                        MessageBox.Show("Colaborador se ha Borrado..!");
                        cargarTablaEmpleados();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un Error!" + error);
                    }
                }
            }
        }
    }
}
