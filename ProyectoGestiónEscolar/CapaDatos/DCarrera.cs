using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DCarrera
    {
        private int _IdCarrera;
        private string _Nombre;
        private string _Tipo;
        private string _TextoBuscar;

        public int IdCarrera { get => _IdCarrera; set => _IdCarrera = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public DCarrera()
        {

        }

        public DCarrera(int idcarrera, string nombre, string tipo, string textobuscar)
        {
            this.IdCarrera = idcarrera;
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.TextoBuscar = textobuscar;
        }


        public string Insertar(DCarrera Carrera)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_carrera";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCarrera = new SqlParameter();
                ParIdCarrera.ParameterName = "@Id_Carrera";
                ParIdCarrera.SqlDbType = SqlDbType.Int;
                ParIdCarrera.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdCarrera);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Carrera.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@Tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 256;
                ParTipo.Value = Carrera.Tipo;
                SqlCmd.Parameters.Add(ParTipo);


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

        public string Editar(DCarrera Carrera)
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
                SqlCmd.CommandText = "speditar_carrera";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCarrera= new SqlParameter();
                ParIdCarrera.ParameterName = "@Id_Carrera";
                ParIdCarrera.SqlDbType = SqlDbType.Int;
                ParIdCarrera.Value = Carrera.IdCarrera;
                SqlCmd.Parameters.Add(ParIdCarrera);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Carrera.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@Tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 256;
                ParTipo.Value = Carrera.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

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
            DataTable DtResultado = new DataTable("Carrera");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_carrera";
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


        public DataTable Buscar(DMunicipio Municipio)
        {
            DataTable DtResultado = new DataTable("Carrera");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_carrera";
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
