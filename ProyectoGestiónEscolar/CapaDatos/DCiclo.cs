using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class DCiclo
    {
        private int _IdCiclo;
        private string _Ciclo;
        private string _Descripcion;
        private DateTime _Fecha_G;
        private string _Estado;

        public int IdCiclo { get => _IdCiclo; set => _IdCiclo = value; }
        public string Ciclo { get => _Ciclo; set => _Ciclo = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }

        public string Estado { get => _Estado; set => _Estado = value; }
        public DateTime Fecha_G { get => _Fecha_G; set => _Fecha_G = value; }

        public DCiclo()
        {

        }

        public DCiclo(int idciclo, string ciclo, string descripcion, DateTime fecha_g, string estado)
        {
            this.IdCiclo = idciclo;
            this.Ciclo = ciclo;
            this.Descripcion = descripcion;
            this.Fecha_G = fecha_g;
            this.Estado = estado;
        }


        public string Insertar(DCiclo Ciclo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_ciclo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCiclo = new SqlParameter();
                ParIdCiclo.ParameterName = "@Id_Ciclo";
                ParIdCiclo.SqlDbType = SqlDbType.Int;
                ParIdCiclo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdCiclo);

                SqlParameter ParCiclo = new SqlParameter();
                ParCiclo.ParameterName = "@Ciclo";
                ParCiclo.SqlDbType = SqlDbType.VarChar;
                ParCiclo.Size = 50;
                ParCiclo.Value = Ciclo.Ciclo;
                SqlCmd.Parameters.Add(ParCiclo);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descrip";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Ciclo.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@Fecha_G";
                ParFecha.SqlDbType = SqlDbType.VarChar;
                ParFecha.Size = 256;
                ParFecha.Value = Ciclo.Fecha_G;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 256;
                ParEstado.Value = Ciclo.Estado;
                SqlCmd.Parameters.Add(ParEstado);

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

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Ciclo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_ciclo";
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
