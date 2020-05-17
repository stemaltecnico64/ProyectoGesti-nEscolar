using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
   public class DSeccion
    {
        private int _IdSeccion;
        private string _Nombre;

        public int IdSeccion { get => _IdSeccion; set => _IdSeccion = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }


        public DSeccion(int idseccion, string nombre)
        {
            this.IdSeccion = idseccion;
            this.Nombre = nombre;
        }

        public DSeccion()
        {
        }

        public string Insertar(DSeccion Seccion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_secc";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdSeccion = new SqlParameter();
                ParIdSeccion.ParameterName = "@Id_Secc";
                ParIdSeccion.SqlDbType = SqlDbType.Int;
                ParIdSeccion.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdSeccion);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Seccion.Nombre;
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


        public string Editar(DSeccion Seccion)
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
                SqlCmd.CommandText = "speditar_secc";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdSeccion = new SqlParameter();
                ParIdSeccion.ParameterName = "@Id_Secc";
                ParIdSeccion.SqlDbType = SqlDbType.Int;
                ParIdSeccion.Value = Seccion.IdSeccion;
                SqlCmd.Parameters.Add(ParIdSeccion);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Seccion.Nombre;
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
            DataTable DtResultado = new DataTable("Seccion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_secc";
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
