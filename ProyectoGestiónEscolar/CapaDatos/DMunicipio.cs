using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class DMunicipio
    {
        private int _IdMunicipio;
        private string _Nombre;
        private string _Descripcion;
        private int _IdDepartamento;
        private string _TextoBuscar;

        public int IdMunicipio { get => _IdMunicipio; set => _IdMunicipio = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int IdDepartamento { get => _IdDepartamento; set => _IdDepartamento = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public DMunicipio()
        {

        }

        public DMunicipio(int idmunicipio, string nombre, string descripcion, int iddepartamento, string textobuscar)
        {
            this.IdMunicipio = idmunicipio;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.IdDepartamento = iddepartamento;
            this.TextoBuscar = textobuscar;
        }

        public string Insertar(DMunicipio Municipio)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_municipio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdMunicipio = new SqlParameter();
                ParIdMunicipio.ParameterName = "@Id_Municipio";
                ParIdMunicipio.SqlDbType = SqlDbType.Int;
                ParIdMunicipio.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdMunicipio);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre_Muni";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Municipio.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Des";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Municipio.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParIdDepartamento= new SqlParameter();
                ParIdDepartamento.ParameterName = "@Id_Departamento";
                ParIdDepartamento.SqlDbType = SqlDbType.VarChar;
                ParIdDepartamento.Size = 256;
                ParIdDepartamento.Value = Municipio.IdDepartamento;
                SqlCmd.Parameters.Add(ParIdDepartamento);

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


        public string Editar(DMunicipio Municipio)
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
                SqlCmd.CommandText = "speditar_municipio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdMunicipio = new SqlParameter();
                ParIdMunicipio.ParameterName = "@Id_Municipio";
                ParIdMunicipio.SqlDbType = SqlDbType.Int;
                ParIdMunicipio.Value = Municipio.IdMunicipio;
                SqlCmd.Parameters.Add(ParIdMunicipio);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre_Muni";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Municipio.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Des";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Municipio.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParIdDepartamento = new SqlParameter();
                ParIdDepartamento.ParameterName = "@Id_Departamento";
                ParIdDepartamento.SqlDbType = SqlDbType.VarChar;
                ParIdDepartamento.Size = 256;
                ParIdDepartamento.Value = Municipio.IdDepartamento;
                SqlCmd.Parameters.Add(ParIdDepartamento);

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


        public string Eliminar(DMunicipio Municipio)
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
                SqlCmd.CommandText = "speliminar_municipio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdMunicipio = new SqlParameter();
                ParIdMunicipio.ParameterName = "@Id_Municipio";
                ParIdMunicipio.SqlDbType = SqlDbType.Int;
                ParIdMunicipio.Value = Municipio.IdMunicipio;
                SqlCmd.Parameters.Add(ParIdMunicipio);

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
            DataTable DtResultado = new DataTable("Municipio");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_municipio";
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


        public DataTable BuscarNombre(DMunicipio Municipio)
        {
            DataTable DtResultado = new DataTable("Municipio");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_Municipio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Municipio.TextoBuscar;
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
