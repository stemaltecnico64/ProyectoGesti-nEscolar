using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    public class DTipo_Encargado
    {
        private int _IdTipoEncargado;
        private string _Nombre;
        private string _TextoBuscar;

        public int IdTipoEncargado { get => _IdTipoEncargado; set => _IdTipoEncargado = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }


        public DTipo_Encargado()
        {

        }
        //Constructor con parámetros
        public DTipo_Encargado(int idTipoEncargado, string nombre,  string textobuscar)
        {
            this.IdTipoEncargado = idTipoEncargado;
            this.Nombre = nombre;
            this.TextoBuscar = textobuscar;
        }
        public string Insertar(DTipo_Encargado TipoEncargado)
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
                SqlCmd.CommandText = "spinsertar_tipo_encargado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdTipoEncargado = new SqlParameter();
                ParIdTipoEncargado.ParameterName = "@Id_Tipo_Encargado";
                ParIdTipoEncargado.SqlDbType = SqlDbType.Int;
                ParIdTipoEncargado.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdTipoEncargado);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = TipoEncargado.Nombre;
                SqlCmd.Parameters.Add(ParNombre);


                //Ejecutamos nuestro comando

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

        public string Editar(DTipo_Encargado TipoEncargado)
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
                SqlCmd.CommandText = "speditar_tipo_encargado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdTipoEncargado = new SqlParameter();
                ParIdTipoEncargado.ParameterName = "@Id_Tipo_Encargado";
                ParIdTipoEncargado.SqlDbType = SqlDbType.Int;
                ParIdTipoEncargado.Value = TipoEncargado.IdTipoEncargado;
                SqlCmd.Parameters.Add(ParIdTipoEncargado);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = TipoEncargado.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

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

        public string Eliminar(DTipo_Encargado TipoEncargado)
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
                SqlCmd.CommandText = "speliminar_tipo_encargado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdTipoEncargado = new SqlParameter();
                ParIdTipoEncargado.ParameterName = "@Id_Tipo_Encargado";
                ParIdTipoEncargado.SqlDbType = SqlDbType.Int;
                ParIdTipoEncargado.Value = TipoEncargado.IdTipoEncargado;
                SqlCmd.Parameters.Add(ParIdTipoEncargado);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";


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
            DataTable DtResultado = new DataTable("Tipo_Encargado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_tipo_encargado";
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

        public DataTable BuscarNombre(DTipo_Encargado TipoEncargado)
        {
            DataTable DtResultado = new DataTable("Tipo_Encargado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_tipo_encargado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TipoEncargado.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

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
