using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    public class DDepartamento
    {
        private int _IdDepartamento;
        private string _Nombre;
        private string _Descripcion;
        private string _TextoBuscar;

        public int IdDepartamento { get => _IdDepartamento; set => _IdDepartamento = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public DDepartamento()
        {

        }
        //Constructor con parámetros
        public DDepartamento(int iddepartamento, string nombre, string descripcion, string textobuscar)
        {
            this.IdDepartamento = iddepartamento;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.TextoBuscar = textobuscar;

        }

        public string Insertar(DDepartamento Departamento)
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
                SqlCmd.CommandText = "spinsertar_departamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDepartamento= new SqlParameter();
                ParIdDepartamento.ParameterName = "@Id_Depatamento";
                ParIdDepartamento.SqlDbType = SqlDbType.Int;
                ParIdDepartamento.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdDepartamento);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre_Dep";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Departamento.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Des";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Departamento.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

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

        public string Editar(DDepartamento Departamento)
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
                SqlCmd.CommandText = "speditar_departamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDepartamento = new SqlParameter();
                ParIdDepartamento.ParameterName = "@Id_Depatamento";
                ParIdDepartamento.SqlDbType = SqlDbType.Int;
                ParIdDepartamento.Value = Departamento.IdDepartamento;
                SqlCmd.Parameters.Add(ParIdDepartamento);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre_Dep";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Departamento.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Des";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Departamento.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

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


        public string Eliminar(DDepartamento Departamento)
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
                SqlCmd.CommandText = "speliminar_departamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDepartamento = new SqlParameter();
                ParIdDepartamento.ParameterName = "@Id_Departamento";
                ParIdDepartamento.SqlDbType = SqlDbType.Int;
                ParIdDepartamento.Value = Departamento.IdDepartamento;
                SqlCmd.Parameters.Add(ParIdDepartamento);


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
            DataTable DtResultado = new DataTable("Departamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_departamento";
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
        public DataTable BuscarNombre(DDepartamento Departamento)
        {
            DataTable DtResultado = new DataTable("Departamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_departamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Departamento.TextoBuscar;
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
