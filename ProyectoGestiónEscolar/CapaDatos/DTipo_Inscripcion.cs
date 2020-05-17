using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class DTipo_Inscripcion
    {
        private int _IdTipoInscripcion;
        private string _Nombre;

        public int IdTipoInscripcion { get => _IdTipoInscripcion; set => _IdTipoInscripcion = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }

        public DTipo_Inscripcion()
        {

        }

        public DTipo_Inscripcion(int idtipoinscripcion, string nombre)
        {
            this.IdTipoInscripcion = idtipoinscripcion;
            this.Nombre = nombre;
        }

        public string Insertar(DTipo_Inscripcion Tipo_Inscripcion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_Tipo_Ins";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdTipoInscripcion = new SqlParameter();
                ParIdTipoInscripcion.ParameterName = "@Id_Tipo_Inscripcion";
                ParIdTipoInscripcion.SqlDbType = SqlDbType.Int;
                ParIdTipoInscripcion.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdTipoInscripcion);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Tipo_Inscripcion.Nombre;
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


        public string Editar(DTipo_Inscripcion Tipo_Inscripcion)
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
                SqlCmd.CommandText = "speditar_Tipo_Inscripcion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdTipoInscripcion = new SqlParameter();
                ParIdTipoInscripcion.ParameterName = "@Id_Tipo_Inscripcion";
                ParIdTipoInscripcion.SqlDbType = SqlDbType.Int;
                ParIdTipoInscripcion.Value = Tipo_Inscripcion.IdTipoInscripcion;
                SqlCmd.Parameters.Add(ParIdTipoInscripcion);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Tipo_Inscripcion.Nombre;
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
            DataTable DtResultado = new DataTable("Tipo_Inscripcion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_Tipo_Ins";
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
