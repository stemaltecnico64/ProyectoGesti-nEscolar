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
    public partial class Crear_Asignacion_Alumnos_Cursos : Form
    {
        public Crear_Asignacion_Alumnos_Cursos()
        {
            InitializeComponent();
        }

        public static DataSet Conexion_GX(string cmd)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-NPN78EM; Initial Catalog = BDEscuelaComercio; Integrated Security = true ");
            con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);

            DP.Fill(DS);

            con.Close();

            return DS;
        }

        private void btnBuscarA_Click(object sender, EventArgs e)
        {
            Listado_Inscripciones_Admin li = new Listado_Inscripciones_Admin();
            li.ShowDialog();

            if (li.DialogResult == DialogResult.OK)
            {
                txtCodigoA.Text = li.Tabla_Inscripciones.Rows[li.Tabla_Inscripciones.CurrentRow.Index].Cells[0].Value.ToString();
                txtSeccionA.Text = li.Tabla_Inscripciones.Rows[li.Tabla_Inscripciones.CurrentRow.Index].Cells[10].Value.ToString();
                txtCarreraA.Text = li.Tabla_Inscripciones.Rows[li.Tabla_Inscripciones.CurrentRow.Index].Cells[8].Value.ToString();
                txtGradoA.Text = li.Tabla_Inscripciones.Rows[li.Tabla_Inscripciones.CurrentRow.Index].Cells[9].Value.ToString();
                txtAlumno.Text = li.Tabla_Inscripciones.Rows[li.Tabla_Inscripciones.CurrentRow.Index].Cells[5].Value.ToString();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            this.txtAlumno.Text = string.Empty;
            this.txtCarreraA.Text = string.Empty;
            this.txtCarreraM.Text = string.Empty;
            this.txtCodigoA.Text = string.Empty;
            this.txtcodigoM.Text = string.Empty;
            this.txtCurso.Text = string.Empty;
            this.txtGradoA.Text = string.Empty;
            this.txtGradoM.Text = string.Empty;
            this.txtMaestro.Text = string.Empty;
            this.txtSeccionA.Text = string.Empty;
            this.txtSeccionM.Text = string.Empty;
        }

        private void btnBuscarM_Click(object sender, EventArgs e)
        {
            Listado_Cursos_Asignados lca = new Listado_Cursos_Asignados();
            lca.ShowDialog();

            if (lca.DialogResult == DialogResult.OK)
            {
                txtcodigoM.Text = lca.Tabla_Cursos_A.Rows[lca.Tabla_Cursos_A.CurrentRow.Index].Cells[0].Value.ToString();
                txtSeccionM.Text = lca.Tabla_Cursos_A.Rows[lca.Tabla_Cursos_A.CurrentRow.Index].Cells[5].Value.ToString();
                txtCurso.Text = lca.Tabla_Cursos_A.Rows[lca.Tabla_Cursos_A.CurrentRow.Index].Cells[4].Value.ToString();
                txtMaestro.Text = lca.Tabla_Cursos_A.Rows[lca.Tabla_Cursos_A.CurrentRow.Index].Cells[1].Value.ToString();
                txtCarreraM.Text = lca.Tabla_Cursos_A.Rows[lca.Tabla_Cursos_A.CurrentRow.Index].Cells[2].Value.ToString();
                txtGradoM.Text = lca.Tabla_Cursos_A.Rows[lca.Tabla_Cursos_A.CurrentRow.Index].Cells[3].Value.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCarreraM.Text == txtCarreraA.Text && txtGradoM.Text == txtGradoA.Text && txtSeccionM.Text == txtSeccionA.Text)
            {
                try
                {
                    string cmd = string.Format("Execute insertar_inscrip_maes_enNotas '{0}','{1}'", Convert.ToInt32(txtcodigoM.Text), Convert.ToInt32(txtCodigoA.Text));
                    Conexion_GX(cmd);
                    MessageBox.Show("Se Asignado El Curso al Alumno Exitosamente..!");
                    this.Limpiar();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un Error!" + error);
                }
            }
            else if (txtCarreraM.Text != txtCarreraA.Text && txtGradoM.Text == txtGradoA.Text && txtSeccionM.Text == txtSeccionA.Text)
            {
                MessageBox.Show("Ha ocurrido un Error, El Grado y la Sección No pertenecen a esta Carrera!");
            }
            else if (txtCarreraM.Text == txtCarreraA.Text && txtGradoM.Text == txtGradoA.Text && txtSeccionM.Text != txtSeccionA.Text)
            {
                MessageBox.Show("Ha ocurrido un Error, Las Secciones son diferentes!");
            }
            else if (txtCarreraM.Text == txtCarreraA.Text && txtGradoM.Text != txtGradoA.Text && txtSeccionM.Text == txtSeccionA.Text)
            {
                MessageBox.Show("Ha ocurrido un Error, El curso no pertenece a este Grado!");
            }
            

        }
    }
}
