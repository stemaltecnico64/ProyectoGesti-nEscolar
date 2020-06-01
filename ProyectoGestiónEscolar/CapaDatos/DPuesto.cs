using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class DPuesto
    {
        private int _IdPuesto;
        private string _Puesto;
        private string _textobuscar;

        public int IdPuesto { get => _IdPuesto; set => _IdPuesto = value; }
        public string Puesto { get => _Puesto; set => _Puesto = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        public DPuesto()
        {

        }

        public DPuesto(int idpuesto, string puesto, string textobuscar )
        {
            this.IdPuesto = idpuesto;
            this.Puesto = puesto;
            this.Textobuscar = textobuscar;
        }


        public string Insertar(DPuesto Puesto)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_puesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPuesto = new SqlParameter();
                ParIdPuesto.ParameterName = "@Id_Puesto";
                ParIdPuesto.SqlDbType = SqlDbType.Int;
                ParIdPuesto.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdPuesto);

                SqlParameter ParPuesto = new SqlParameter();
                ParPuesto.ParameterName = "@Puesto";
                ParPuesto.SqlDbType = SqlDbType.VarChar;
                ParPuesto.Size = 50;
                ParPuesto.Value = Puesto.Puesto;
                SqlCmd.Parameters.Add(ParPuesto);

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


        public string Editar(DPuesto Puesto)
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
                SqlCmd.CommandText = "speditar_puesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPuesto = new SqlParameter();
                ParIdPuesto.ParameterName = "@Id_Puesto";
                ParIdPuesto.SqlDbType = SqlDbType.Int;
                ParIdPuesto.Value = Puesto.IdPuesto;
                SqlCmd.Parameters.Add(ParIdPuesto);

                SqlParameter ParPuesto = new SqlParameter();
                ParPuesto.ParameterName = "@Puesto";
                ParPuesto.SqlDbType = SqlDbType.VarChar;
                ParPuesto.Size = 50;
                ParPuesto.Value = Puesto.Puesto;
                SqlCmd.Parameters.Add(ParPuesto);

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
            DataTable DtResultado = new DataTable("Puestos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_puesto";
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
        public DataTable BuscarNombre(DPuesto Puesto)
        {
            DataTable DtResultado = new DataTable("Puestos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_puesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Puesto.Textobuscar;
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
