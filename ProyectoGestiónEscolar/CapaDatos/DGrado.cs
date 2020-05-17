﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
   public  class DGrado
    {
        private int _IdGrado;
        private string _Nombre;

        public int IdGrado { get => _IdGrado; set => _IdGrado = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }

        public DGrado()
        {

        }

        public DGrado(int idgrado, string nombre)
        {
            this.IdGrado = idgrado;
            this.Nombre = nombre;
        }

        public string Insertar(DGrado Grado)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_grado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdGrado= new SqlParameter();
                ParIdGrado.ParameterName = "@Id_Grado";
                ParIdGrado.SqlDbType = SqlDbType.Int;
                ParIdGrado.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdGrado);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Grado.Nombre;
                SqlCmd.Parameters.Add(ParNombre);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }


        public string Editar(DGrado Grado)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_grado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdGrado = new SqlParameter();
                ParIdGrado.ParameterName = "@Id_Grado";
                ParIdGrado.SqlDbType = SqlDbType.Int;
                ParIdGrado.Value = Grado.IdGrado;
                SqlCmd.Parameters.Add(ParIdGrado);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Grado.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }


        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Grado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_grado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
    }
}
