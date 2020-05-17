﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txt_password.isPassword = true;
        }

        public static string nivel_x = "";

        public static string ID_USER = "";


        public static DataSet Conexion(string cmd)
        {
            SqlConnection con = new SqlConnection("Data Source = GX; Initial Catalog = BDEscuela; Integrated Security = true ");
            con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);

            DP.Fill(DS);

            con.Close();

            return DS;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = String.Format("Select * from Usuarios where NOMBRE_USUARIO='{0}' and PASSWORD_USUARIO='{1}'",txt_usuario.Text.Trim(),txt_password.Text.Trim());
                DataSet ds = Conexion(CMD);

                string usuario = ds.Tables[0].Rows[0]["NOMBRE_USUARIO"].ToString().Trim();
                string password = ds.Tables[0].Rows[0]["PASSWORD_USUARIO"].ToString().Trim();
                nivel_x = ds.Tables[0].Rows[0]["ID_NIVEL_USUARIO"].ToString().Trim();
                ID_USER = ds.Tables[0].Rows[0]["ID_USUARIO"].ToString().Trim();

                if (nivel_x.Equals("1"))
                {
                    if (usuario == txt_usuario.Text.Trim() && password == txt_password.Text.Trim())
                    {
                        Pantalla_Carga VenCarga = new Pantalla_Carga();
                        this.Hide();
                        VenCarga.Show();
                    }
                }
                else if (nivel_x.Equals("2"))
                {
                    if (usuario == txt_usuario.Text.Trim() && password == txt_password.Text.Trim())
                    {
                        Pantalla_Carga VenCarga = new Pantalla_Carga();
                        this.Hide();
                        VenCarga.Show();
                    }
                }
                else if (nivel_x.Equals("3"))
                {
                    if (usuario == txt_usuario.Text.Trim() && password == txt_password.Text.Trim())
                    {
                        Pantalla_Carga VenCarga = new Pantalla_Carga();
                        this.Hide();
                        VenCarga.Show();
                    }
                }
                else if (nivel_x.Equals("4"))
                {
                    if (usuario == txt_usuario.Text.Trim() && password == txt_password.Text.Trim())
                    {
                        Pantalla_Carga VenCarga = new Pantalla_Carga();
                        this.Hide();
                        VenCarga.Show();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Usuario o Contraseña incorrecta...!");
            }
            
        }
    }
}
