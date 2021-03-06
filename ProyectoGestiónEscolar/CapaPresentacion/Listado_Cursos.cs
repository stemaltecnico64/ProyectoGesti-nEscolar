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
    public partial class Listado_Cursos : Form
    {
        public Listado_Cursos()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuelaComercio; Integrated Security = true ");

        public void cargarTablaCursos()
        {
            con.Open();
            SqlDataAdapter DP = new SqlDataAdapter("select * from vista_listado_cursos order by Carrera,Grado", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Cursos.DataSource = dt;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarCurso()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_cursos where Curso like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Cursos.DataSource = dt;

        }
        private void BuscarGrado()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_cursos where Grado like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Cursos.DataSource = dt;

        }
        private void BuscarCarrera()
        {
            SqlDataAdapter DP = new SqlDataAdapter("Select * from vista_listado_cursos where Carrera like'%" + txtBuscar.Text + "%'", con);
            DataTable dt = new DataTable();

            DP.Fill(dt);

            Tabla_Cursos.DataSource = dt;

        }


        private void Tabla_Cursos_DoubleClick(object sender, EventArgs e)
        {
            if (Tabla_Cursos.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Listado_Cursos_Load(object sender, EventArgs e)
        {
            cargarTablaCursos();
            txtBuscar.Focus();
            cbBuscar.SelectedIndex = 0;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Carrera"))
            {
                BuscarCarrera();
            }
            else if (cbBuscar.Text.Equals("Grado"))
            {
                BuscarGrado();
            }
            else if (cbBuscar.Text.Equals("Curso"))
            {
                BuscarCurso();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Tabla_Cursos.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Borrar este Curso", "SEGURIDAD DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    try
                    {
                        string cmd = string.Format("Execute Delete_Curso '{0}'", Convert.ToInt32(Tabla_Cursos.Rows[Tabla_Cursos.CurrentRow.Index].Cells[0].Value.ToString()));
                        Login.Conexion_GX(cmd);
                        MessageBox.Show("El Curso se ha Borrado..!");
                        cargarTablaCursos();
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
