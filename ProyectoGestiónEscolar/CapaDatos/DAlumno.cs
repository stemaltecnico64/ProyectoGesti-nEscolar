using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DAlumno
    {
        private int _Id_Alumno;
        private string _Codigo_Alumno;
        private string _CUI;
        private string _Nombre1;
        private string _Nombre2;
        private string _Nombre3;
        private string _Apellido1;
        private string _Apellido2;
        private string _Apellido3;
        private DateTime _Fecha_Nac;
        private string _Sexo;
        private string _Direccion;
        private int _Id_Municipio;
        private string _Telefono;
        private byte[] _Foto;
        private int _Id_Encargado;
        private string _Estado;
        private string _TextoBuscar;

        public int Id_Alumno { get => _Id_Alumno; set => _Id_Alumno = value; }
        public string Codigo_Alumno { get => _Codigo_Alumno; set => _Codigo_Alumno = value; }
        public string CUI { get => _CUI; set => _CUI = value; }
        public string Nombre1 { get => _Nombre1; set => _Nombre1 = value; }
        public string Nombre2 { get => _Nombre2; set => _Nombre2 = value; }
        public string Nombre3 { get => _Nombre3; set => _Nombre3 = value; }
        public string Apellido1 { get => _Apellido1; set => _Apellido1 = value; }
        public string Apellido2 { get => _Apellido2; set => _Apellido2 = value; }
        public string Apellido3 { get => _Apellido3; set => _Apellido3 = value; }
        public DateTime Fecha_Nac { get => _Fecha_Nac; set => _Fecha_Nac = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public int Id_Municipio { get => _Id_Municipio; set => _Id_Municipio = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public byte[] Foto { get => _Foto; set => _Foto = value; }
        public int Id_Encargado { get => _Id_Encargado; set => _Id_Encargado = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }
   

        public DAlumno()
        {

        }

        public DAlumno(int id_alumno, string codigo_alumno, string cui, string nombre1, string nombre2, string nombre3, string apellido1, string apellido2, string apellido3, DateTime fecha_nac,
            string sexo, string direccion, int id_municipio, string telefono, byte[] foto, int id_encargado, string Estado, string textobuscar)
        {
            this.Id_Alumno = id_alumno;
            this.Codigo_Alumno = codigo_alumno;
            this.CUI = cui;
            this.Nombre1 = nombre1;
            this.Nombre2 = nombre2;
            this.Nombre3 = nombre3;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Apellido3 = apellido3;
            this.Fecha_Nac = fecha_nac;
            this.Sexo = sexo;
            this.Direccion = direccion;
            this.Id_Municipio = id_municipio;
            this.Telefono = telefono;
            this.Foto = foto;
            this.Id_Encargado = id_encargado;
            this.Estado = Estado;
            this.TextoBuscar = textobuscar;
        }

        public string Insertar(DAlumno Alumno)
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
                SqlCmd.CommandText = "spinsertar_alumno";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdAlumno = new SqlParameter();
                ParIdAlumno.ParameterName = "@Id_Alumno";
                ParIdAlumno.SqlDbType = SqlDbType.Int;
                ParIdAlumno.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdAlumno);

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@Codigo_Alumno";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 50;
                ParCodigo.Value = Alumno.Codigo_Alumno;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParCUI = new SqlParameter();
                ParCUI.ParameterName = "@Cui";
                ParCUI.SqlDbType = SqlDbType.VarChar;
                ParCUI.Size = 50;
                ParCUI.Value = Alumno.CUI;
                SqlCmd.Parameters.Add(ParCUI);

                SqlParameter ParNombre1 = new SqlParameter();
                ParNombre1.ParameterName = "@Nombre1";
                ParNombre1.SqlDbType = SqlDbType.VarChar;
                ParNombre1.Size = 50;
                ParNombre1.Value = Alumno.Nombre1;
                SqlCmd.Parameters.Add(ParNombre1);

                SqlParameter ParNombre2 = new SqlParameter();
                ParNombre2.ParameterName = "@Nombre2";
                ParNombre2.SqlDbType = SqlDbType.VarChar;
                ParNombre2.Size = 50;
                ParNombre2.Value = Alumno.Nombre2;
                SqlCmd.Parameters.Add(ParNombre2);

                SqlParameter ParNombre3 = new SqlParameter();
                ParNombre3.ParameterName = "@Nombre3";
                ParNombre3.SqlDbType = SqlDbType.VarChar;
                ParNombre3.Size = 50;
                ParNombre3.Value = Alumno.Nombre3;
                SqlCmd.Parameters.Add(ParNombre3);

                SqlParameter ParApellido1 = new SqlParameter();
                ParApellido1.ParameterName = "@Apellido1";
                ParApellido1.SqlDbType = SqlDbType.VarChar;
                ParApellido1.Size = 50;
                ParApellido1.Value = Alumno.Apellido1;
                SqlCmd.Parameters.Add(ParApellido1);

                SqlParameter ParApellido2 = new SqlParameter();
                ParApellido2.ParameterName = "@Apellido2";
                ParApellido2.SqlDbType = SqlDbType.VarChar;
                ParApellido2.Size = 50;
                ParApellido2.Value = Alumno.Apellido2;
                SqlCmd.Parameters.Add(ParApellido2);

                SqlParameter ParApellido3 = new SqlParameter();
                ParApellido3.ParameterName = "@Apellido3";
                ParApellido3.SqlDbType = SqlDbType.VarChar;
                ParApellido3.Size = 50;
                ParApellido3.Value = Alumno.Apellido3;
                SqlCmd.Parameters.Add(ParApellido3);

                SqlParameter ParFecha_Nacimiento = new SqlParameter();
                ParFecha_Nacimiento.ParameterName = "@Fecha_Nac";
                ParFecha_Nacimiento.SqlDbType = SqlDbType.DateTime;
                ParFecha_Nacimiento.Value = Alumno.Fecha_Nac;
                SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@Sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 50;
                ParSexo.Value = Alumno.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 2054;
                ParDireccion.Value = Alumno.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);


                SqlParameter ParIdMunicipio = new SqlParameter();
                ParIdMunicipio.ParameterName = "@Id_Municipio";
                ParIdMunicipio.SqlDbType = SqlDbType.VarChar;
                ParIdMunicipio.Value = Alumno.Id_Municipio;
                SqlCmd.Parameters.Add(ParIdMunicipio);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 2054;
                ParTelefono.Value = Alumno.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParFoto = new SqlParameter();
                ParFoto.ParameterName = "@Foto";
                ParFoto.SqlDbType = SqlDbType.Image;
                ParFoto.Value = Alumno.Foto;
                SqlCmd.Parameters.Add(ParFoto);

                SqlParameter ParIdEncargado = new SqlParameter();
                ParIdEncargado.ParameterName = "@Id_Encargado";
                ParIdEncargado.SqlDbType = SqlDbType.VarChar;
                ParIdEncargado.Value = Alumno.Id_Encargado;
                SqlCmd.Parameters.Add(ParIdEncargado);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParEstado.Value = Alumno.Estado;
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


        public string Editar(DAlumno Alumno)
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
                SqlCmd.CommandText = "speditar_alumno";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdAlumno = new SqlParameter();
                ParIdAlumno.ParameterName = "@Id_Alumno";
                ParIdAlumno.SqlDbType = SqlDbType.Int;
                ParIdAlumno.Value = Alumno.Id_Alumno;
                SqlCmd.Parameters.Add(ParIdAlumno);

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@Codigo_Alumno";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 50;
                ParCodigo.Value = Alumno.Codigo_Alumno;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParCUI = new SqlParameter();
                ParCUI.ParameterName = "@Cui";
                ParCUI.SqlDbType = SqlDbType.VarChar;
                ParCUI.Size = 50;
                ParCUI.Value = Alumno.CUI;
                SqlCmd.Parameters.Add(ParCUI);

                SqlParameter ParNombre1 = new SqlParameter();
                ParNombre1.ParameterName = "@Nombre1";
                ParNombre1.SqlDbType = SqlDbType.VarChar;
                ParNombre1.Size = 50;
                ParNombre1.Value = Alumno.Nombre1;
                SqlCmd.Parameters.Add(ParNombre1);

                SqlParameter ParNombre2 = new SqlParameter();
                ParNombre2.ParameterName = "@Nombre2";
                ParNombre2.SqlDbType = SqlDbType.VarChar;
                ParNombre2.Size = 50;
                ParNombre2.Value = Alumno.Nombre2;
                SqlCmd.Parameters.Add(ParNombre2);

                SqlParameter ParNombre3 = new SqlParameter();
                ParNombre3.ParameterName = "@Nombre3";
                ParNombre3.SqlDbType = SqlDbType.VarChar;
                ParNombre3.Size = 50;
                ParNombre3.Value = Alumno.Nombre3;
                SqlCmd.Parameters.Add(ParNombre3);

                SqlParameter ParApellido1 = new SqlParameter();
                ParApellido1.ParameterName = "@Apellido1";
                ParApellido1.SqlDbType = SqlDbType.VarChar;
                ParApellido1.Size = 50;
                ParApellido1.Value = Alumno.Apellido1;
                SqlCmd.Parameters.Add(ParApellido1);

                SqlParameter ParApellido2 = new SqlParameter();
                ParApellido2.ParameterName = "@Apellido2";
                ParApellido2.SqlDbType = SqlDbType.VarChar;
                ParApellido2.Size = 50;
                ParApellido2.Value = Alumno.Apellido2;
                SqlCmd.Parameters.Add(ParApellido2);

                SqlParameter ParApellido3 = new SqlParameter();
                ParApellido3.ParameterName = "@Apellido3";
                ParApellido3.SqlDbType = SqlDbType.VarChar;
                ParApellido3.Size = 50;
                ParApellido3.Value = Alumno.Apellido3;
                SqlCmd.Parameters.Add(ParApellido3);

                SqlParameter ParFecha_Nacimiento = new SqlParameter();
                ParFecha_Nacimiento.ParameterName = "@Fecha_Nac";
                ParFecha_Nacimiento.SqlDbType = SqlDbType.DateTime;
                ParFecha_Nacimiento.Value = Alumno.Fecha_Nac;
                SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@Sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 50;
                ParSexo.Value = Alumno.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 2054;
                ParDireccion.Value = Alumno.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);


                SqlParameter ParIdMunicipio = new SqlParameter();
                ParIdMunicipio.ParameterName = "@Id_Municipio";
                ParIdMunicipio.SqlDbType = SqlDbType.VarChar;
                ParIdMunicipio.Value = Alumno.Id_Municipio;
                SqlCmd.Parameters.Add(ParIdMunicipio);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 2054;
                ParTelefono.Value = Alumno.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParFoto = new SqlParameter();
                ParFoto.ParameterName = "@Foto";
                ParFoto.SqlDbType = SqlDbType.Image;
                ParFoto.Value = Alumno.Foto;
                SqlCmd.Parameters.Add(ParFoto);

                SqlParameter ParIdEncargado = new SqlParameter();
                ParIdEncargado.ParameterName = "@Id_Encargado";
                ParIdEncargado.SqlDbType = SqlDbType.VarChar;
                ParIdEncargado.Value = Alumno.Id_Encargado;
                SqlCmd.Parameters.Add(ParIdEncargado);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 50;
                ParEstado.Value = Alumno.Estado;
                SqlCmd.Parameters.Add(ParEstado);

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
            DataTable DtResultado = new DataTable("Alumno");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_alumno";
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

        public DataTable Apellido(DAlumno Alumno)
        {
            DataTable DtResultado = new DataTable("Alumno");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_alumno_apellido";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Alumno.TextoBuscar;
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


        public DataTable Nombre(DAlumno Alumno)
        {
            DataTable DtResultado = new DataTable("Alumno");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_alumno_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Alumno.TextoBuscar;
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

        public DataTable cui(DAlumno Alumno)
        {
            DataTable DtResultado = new DataTable("Alumno");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_alumno_cui";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Alumno.TextoBuscar;
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
        public DataTable MostrarEditar()
        {
            DataTable DtResultado = new DataTable("Alumno");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_alumno_mostrar_editar";
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

        //EDITAR
        public DataTable ApellidoEditar(DAlumno Alumno)
        {
            DataTable DtResultado = new DataTable("Alumno");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_alumno_apellido_editar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Alumno.TextoBuscar;
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


        public DataTable NombreEditar(DAlumno Alumno)
        {
            DataTable DtResultado = new DataTable("Alumno");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_alumno_nombre_editar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Alumno.TextoBuscar;
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

        public DataTable cuiEditar(DAlumno Alumno)
        {
            DataTable DtResultado = new DataTable("Alumno");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_alumno_cui_editar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Alumno.TextoBuscar;
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
