using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DInscripcion
    {
        private int _IdInscripcion;
        private int _IdCiclo;
        private int _IdCarrera;
        private int _IdTipoInscripcion;
        private int _IdAlumno;
        private int _IdGrado;
        private int _IdSeccion;
        private DateTime _Fecha;
        private string _Estado;
        private string _TextoBuscar;

        public int IdInscripcion { get => _IdInscripcion; set => _IdInscripcion = value; }
        public int IdCiclo { get => _IdCiclo; set => _IdCiclo = value; }
        public int IdCarrera { get => _IdCarrera; set => _IdCarrera = value; }
        public int IdTipoInscripcion { get => _IdTipoInscripcion; set => _IdTipoInscripcion = value; }
        public int IdAlumno { get => _IdAlumno; set => _IdAlumno = value; }
        public int IdGrado { get => _IdGrado; set => _IdGrado = value; }
        public int IdSeccion { get => _IdSeccion; set => _IdSeccion = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public DInscripcion()
        {

        }
        public DInscripcion(int idinscripcion, int idciclo, int idcarrera, int idtipoinscripcion, int idalumno, int idgrado,
            int idseccion, DateTime fecha, string estado, string textobuscar)
        {
            this.IdInscripcion = idinscripcion;
            this.IdCiclo = idciclo;
            this.IdCarrera = idcarrera;
            this.IdTipoInscripcion = IdTipoInscripcion;
            this.IdAlumno = idalumno;
            this.IdGrado = idgrado;
            this.IdSeccion = idseccion;
            this.Fecha = fecha;
            this.Estado = estado;
            this.TextoBuscar = textobuscar;
        }

        /*  public string Insertar(DInscripcion Inscripcion)
          {
              string rpta = "";
              SqlConnection SqlCon = new SqlConnection();
              try
              {

                  SqlCon.ConnectionString = Conexion.Cn;
                  SqlCon.Open();

                  SqlCommand SqlCmd = new SqlCommand();
                  SqlCmd.Connection = SqlCon;
                  SqlCmd.CommandText = "spinsertar_inscripcion";
                  SqlCmd.CommandType = CommandType.StoredProcedure;

                  SqlParameter ParIdInscripcion = new SqlParameter();
                  ParIdInscripcion.ParameterName = "@Id_Inscripcion";
                  ParIdInscripcion.SqlDbType = SqlDbType.Int;
                  ParIdInscripcion.Direction = ParameterDirection.Output;
                  SqlCmd.Parameters.Add(ParIdInscripcion);

                  SqlParameter IdCiclo = new SqlParameter();
                  IdCiclo.ParameterName = "@Id_Ciclo";
                  IdCiclo.SqlDbType = SqlDbType.VarChar;
                  IdCiclo.Size = 50;
                  IdCiclo.Value = Inscripcion.IdCiclo;
                  SqlCmd.Parameters.Add(IdCiclo);

                  SqlParameter IdCarrera = new SqlParameter();
                  IdCarrera.ParameterName = "@Id_Carrera";
                  IdCarrera.SqlDbType = SqlDbType.VarChar;
                  IdCarrera.Size = 50;
                  IdCarrera.Value = Inscripcion.IdCarrera;
                  SqlCmd.Parameters.Add(IdCarrera);

                  SqlParameter IdTipoInscripcion = new SqlParameter();
                  IdTipoInscripcion.ParameterName = "@Id_Tipo_Inscripcion";
                  IdTipoInscripcion.SqlDbType = SqlDbType.VarChar;
                  IdTipoInscripcion.Size = 50;
                  IdTipoInscripcion.Value = Inscripcion.IdTipoInscripcion;
                  SqlCmd.Parameters.Add(IdTipoInscripcion);

                  SqlParameter IdAlumno = new SqlParameter();
                  IdAlumno.ParameterName = "@Id_Alumno";
                  IdAlumno.SqlDbType = SqlDbType.VarChar;
                  IdAlumno.Size = 50;
                  IdAlumno.Value = Inscripcion.IdAlumno;
                  SqlCmd.Parameters.Add(IdAlumno);

                  SqlParameter IdGrado = new SqlParameter();
                  IdGrado.ParameterName = "@Id_Grado";
                  IdGrado.SqlDbType = SqlDbType.VarChar;
                  IdGrado.Size = 50;
                  IdGrado.Value = Inscripcion.IdAlumno;
                  SqlCmd.Parameters.Add(IdGrado);

                  SqlParameter IdSeccion = new SqlParameter();
                  IdSeccion.ParameterName = "@Id_Seccion";
                  IdSeccion.SqlDbType = SqlDbType.VarChar;
                  IdSeccion.Size = 50;
                  IdSeccion.Value = Inscripcion.IdSeccion;
                  SqlCmd.Parameters.Add(IdSeccion);

                  SqlParameter Fecha = new SqlParameter();
                  Fecha.ParameterName = "@Fecha";
                  Fecha.SqlDbType = SqlDbType.VarChar;
                  Fecha.Size = 50;
                  Fecha.Value = Inscripcion.Fecha;
                  SqlCmd.Parameters.Add(Fecha);

                  SqlParameter Estado = new SqlParameter();
                  Estado.ParameterName = "@Estado";
                  Estado.SqlDbType = SqlDbType.VarChar;
                  Estado.Size = 50;
                  Estado.Value = Inscripcion.Estado;
                  SqlCmd.Parameters.Add(Estado);



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

          } */



        public string Insertar(DInscripcion Inscripcion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer la trasacción
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_inscripcion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdInscripcion = new SqlParameter();
                ParIdInscripcion.ParameterName = "@Id_Inscripcion";
                ParIdInscripcion.SqlDbType = SqlDbType.Int;
                ParIdInscripcion.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdInscripcion);

                SqlParameter IdCiclo = new SqlParameter();
                IdCiclo.ParameterName = "@Id_Ciclo";
                IdCiclo.SqlDbType = SqlDbType.VarChar;
                IdCiclo.Size = 50;
                IdCiclo.Value = Inscripcion.IdCiclo;
                SqlCmd.Parameters.Add(IdCiclo);

                SqlParameter IdCarrera = new SqlParameter();
                IdCarrera.ParameterName = "@Id_Carrera";
                IdCarrera.SqlDbType = SqlDbType.VarChar;
                IdCarrera.Size = 50;
                IdCarrera.Value = Inscripcion.IdCarrera;
                SqlCmd.Parameters.Add(IdCarrera);

                SqlParameter IdTipoInscripcion = new SqlParameter();
                IdTipoInscripcion.ParameterName = "@Id_Tipo_Inscripcion";
                IdTipoInscripcion.SqlDbType = SqlDbType.VarChar;
                IdTipoInscripcion.Size = 50;
                IdTipoInscripcion.Value = Inscripcion.IdTipoInscripcion;
                SqlCmd.Parameters.Add(IdTipoInscripcion);

                SqlParameter IdAlumno = new SqlParameter();
                IdAlumno.ParameterName = "@Id_Alumno";
                IdAlumno.SqlDbType = SqlDbType.VarChar;
                IdAlumno.Size = 50;
                IdAlumno.Value = Inscripcion.IdAlumno;
                SqlCmd.Parameters.Add(IdAlumno);

                SqlParameter IdGrado = new SqlParameter();
                IdGrado.ParameterName = "@Id_Grado";
                IdGrado.SqlDbType = SqlDbType.VarChar;
                IdGrado.Size = 50;
                IdGrado.Value = Inscripcion.IdAlumno;
                SqlCmd.Parameters.Add(IdGrado);

                SqlParameter IdSeccion = new SqlParameter();
                IdSeccion.ParameterName = "@Id_Seccion";
                IdSeccion.SqlDbType = SqlDbType.VarChar;
                IdSeccion.Size = 50;
                IdSeccion.Value = Inscripcion.IdSeccion;
                SqlCmd.Parameters.Add(IdSeccion);

                SqlParameter Fecha = new SqlParameter();
                Fecha.ParameterName = "@Fecha";
                Fecha.SqlDbType = SqlDbType.VarChar;
                Fecha.Size = 50;
                Fecha.Value = Inscripcion.Fecha;
                SqlCmd.Parameters.Add(Fecha);

                SqlParameter Estado = new SqlParameter();
                Estado.ParameterName = "@Estado";
                Estado.SqlDbType = SqlDbType.VarChar;
                Estado.Size = 50;
                Estado.Value = Inscripcion.Estado;
                SqlCmd.Parameters.Add(Estado);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

                if (rpta.Equals("OK"))
                {
                    //Obtener el código del ingreso generado
                    this.IdInscripcion = Convert.ToInt32(SqlCmd.Parameters["@Id_Inscripcion"].Value);

                }
                if (rpta.Equals("OK"))
                {
                    SqlTra.Commit();
                }
                else
                {
                    SqlTra.Rollback();
                }


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
    }
}
