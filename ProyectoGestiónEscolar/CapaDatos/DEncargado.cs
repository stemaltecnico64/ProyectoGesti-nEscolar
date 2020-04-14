using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
   public class DEncargado
    {
        private int _Id_Encargado;
        private string _DPI;
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
        private int _Id_Tipo_Encargado;
        private string _Estado;
        private string _TextoBuscar;

        public int Id_Encargado { get => _Id_Encargado; set => _Id_Encargado = value; }
        public string DPI { get => _DPI; set => _DPI = value; }
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
        public int Id_Tipo_Encargado { get => _Id_Tipo_Encargado; set => _Id_Tipo_Encargado = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }


        public DEncargado()
        {

        }

        public DEncargado(int id_encargado, string dpi, string nombre1, string nombre2, string nombre3, string apellido1, string apellido2, string apellido3, DateTime fecha_nac,
            string sexo, string direccion, int id_municipio, string telefono, byte[] foto, int id_tipo_encargado, string Estado, string textobuscar)
        {
            this.Id_Encargado = id_encargado;
            this.DPI = dpi;
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
            this.Id_Tipo_Encargado = id_tipo_encargado;
            this.Estado = Estado;
            this.TextoBuscar = textobuscar;
        }

        public string Insertar(DEncargado Encargado)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_encargado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEncargado = new SqlParameter();
                ParIdEncargado.ParameterName = "@Id_Encargado";
                ParIdEncargado.SqlDbType = SqlDbType.Int;
                ParIdEncargado.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdEncargado);

                SqlParameter ParDpi = new SqlParameter();
                ParDpi.ParameterName = "@Dpi";
                ParDpi.SqlDbType = SqlDbType.VarChar;
                ParDpi.Size = 50;
                ParDpi.Value = Encargado.DPI;
                SqlCmd.Parameters.Add(ParDpi);

                SqlParameter ParNombre1 = new SqlParameter();
                ParNombre1.ParameterName = "@Nombre1";
                ParNombre1.SqlDbType = SqlDbType.VarChar;
                ParNombre1.Size = 50;
                ParNombre1.Value = Encargado.Nombre1;
                SqlCmd.Parameters.Add(ParNombre1);

                SqlParameter ParNombre2 = new SqlParameter();
                ParNombre2.ParameterName = "@Nombre2";
                ParNombre2.SqlDbType = SqlDbType.VarChar;
                ParNombre2.Size = 50;
                ParNombre2.Value = Encargado.Nombre2;
                SqlCmd.Parameters.Add(ParNombre2);

                SqlParameter ParNombre3 = new SqlParameter();
                ParNombre3.ParameterName = "@Nombre3";
                ParNombre3.SqlDbType = SqlDbType.VarChar;
                ParNombre3.Size = 50;
                ParNombre3.Value = Encargado.Nombre3;
                SqlCmd.Parameters.Add(ParNombre3);

                SqlParameter ParApellido1 = new SqlParameter();
                ParApellido1.ParameterName = "@Apellido1";
                ParApellido1.SqlDbType = SqlDbType.VarChar;
                ParApellido1.Size = 50;
                ParApellido1.Value = Encargado.Apellido1;
                SqlCmd.Parameters.Add(ParApellido1);

                SqlParameter ParApellido2 = new SqlParameter();
                ParApellido2.ParameterName = "@Apellido2";
                ParApellido2.SqlDbType = SqlDbType.VarChar;
                ParApellido2.Size = 50;
                ParApellido2.Value = Encargado.Apellido2;
                SqlCmd.Parameters.Add(ParApellido2);

                SqlParameter ParApellido3 = new SqlParameter();
                ParApellido3.ParameterName = "@Apellido3";
                ParApellido3.SqlDbType = SqlDbType.VarChar;
                ParApellido3.Size = 50;
                ParApellido3.Value = Encargado.Apellido3;
                SqlCmd.Parameters.Add(ParApellido3);

                SqlParameter ParFecha_Nacimiento = new SqlParameter();
                ParFecha_Nacimiento.ParameterName = "@Fecha_Nac";
                ParFecha_Nacimiento.SqlDbType = SqlDbType.VarChar;
                ParFecha_Nacimiento.Size = 50;
                ParFecha_Nacimiento.Value = Encargado.Fecha_Nac;
                SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@Sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 50;
                ParSexo.Value = Encargado.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 2054;
                ParDireccion.Value = Encargado.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);


                SqlParameter ParIdMunicipio = new SqlParameter();
                ParIdMunicipio.ParameterName = "@Id_Municipio";
                ParIdMunicipio.SqlDbType = SqlDbType.Int;
                ParIdMunicipio.Value = Encargado.Id_Municipio;
                SqlCmd.Parameters.Add(ParIdMunicipio);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 2054;
                ParTelefono.Value = Encargado.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParFoto = new SqlParameter();
                ParFoto.ParameterName = "@Foto";
                ParFoto.SqlDbType = SqlDbType.Image;
                ParFoto.Value = Encargado.Foto;
                SqlCmd.Parameters.Add(ParFoto);

                SqlParameter ParIdTipoEncargado = new SqlParameter();
                ParIdTipoEncargado.ParameterName = "@Id_Tipo_Encargado";
                ParIdTipoEncargado.SqlDbType = SqlDbType.Int;
                ParIdTipoEncargado.Value = Encargado.Id_Tipo_Encargado;
                SqlCmd.Parameters.Add(ParIdTipoEncargado);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParEstado.Value = Encargado.Estado;
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

        public string Editar(DEncargado Encargado)
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
                SqlCmd.CommandText = "speditar_encargado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEncargado = new SqlParameter();
                ParIdEncargado.ParameterName = "@Id_Encargado";
                ParIdEncargado.SqlDbType = SqlDbType.Int;
                ParIdEncargado.Value = Encargado.Id_Encargado;
                SqlCmd.Parameters.Add(ParIdEncargado);

                SqlParameter ParDpi = new SqlParameter();
                ParDpi.ParameterName = "@Dpi";
                ParDpi.SqlDbType = SqlDbType.VarChar;
                ParDpi.Size = 50;
                ParDpi.Value = Encargado.DPI;
                SqlCmd.Parameters.Add(ParDpi);

                SqlParameter ParNombre1 = new SqlParameter();
                ParNombre1.ParameterName = "@Nombre1";
                ParNombre1.SqlDbType = SqlDbType.VarChar;
                ParNombre1.Size = 50;
                ParNombre1.Value = Encargado.Nombre1;
                SqlCmd.Parameters.Add(ParNombre1);

                SqlParameter ParNombre2 = new SqlParameter();
                ParNombre2.ParameterName = "@Nombre2";
                ParNombre2.SqlDbType = SqlDbType.VarChar;
                ParNombre2.Size = 50;
                ParNombre2.Value = Encargado.Nombre2;
                SqlCmd.Parameters.Add(ParNombre2);

                SqlParameter ParNombre3 = new SqlParameter();
                ParNombre3.ParameterName = "@Nombre3";
                ParNombre3.SqlDbType = SqlDbType.VarChar;
                ParNombre3.Size = 50;
                ParNombre3.Value = Encargado.Nombre3;
                SqlCmd.Parameters.Add(ParNombre3);

                SqlParameter ParApellido1 = new SqlParameter();
                ParApellido1.ParameterName = "@Apellido1";
                ParApellido1.SqlDbType = SqlDbType.VarChar;
                ParApellido1.Size = 50;
                ParApellido1.Value = Encargado.Apellido1;
                SqlCmd.Parameters.Add(ParApellido1);

                SqlParameter ParApellido2 = new SqlParameter();
                ParApellido2.ParameterName = "@Apellido2";
                ParApellido2.SqlDbType = SqlDbType.VarChar;
                ParApellido2.Size = 50;
                ParApellido2.Value = Encargado.Apellido2;
                SqlCmd.Parameters.Add(ParApellido2);

                SqlParameter ParApellido3 = new SqlParameter();
                ParApellido3.ParameterName = "@Apellido3";
                ParApellido3.SqlDbType = SqlDbType.VarChar;
                ParApellido3.Size = 50;
                ParApellido3.Value = Encargado.Apellido3;
                SqlCmd.Parameters.Add(ParApellido3);

                SqlParameter ParFecha_Nacimiento = new SqlParameter();
                ParFecha_Nacimiento.ParameterName = "@Fecha_Nac";
                ParFecha_Nacimiento.SqlDbType = SqlDbType.VarChar;
                ParFecha_Nacimiento.Size = 50;
                ParFecha_Nacimiento.Value = Encargado.Fecha_Nac;
                SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@Sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 50;
                ParSexo.Value = Encargado.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 2054;
                ParDireccion.Value = Encargado.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);


                SqlParameter ParIdMunicipio = new SqlParameter();
                ParIdMunicipio.ParameterName = "@Id_Minicipio";
                ParIdMunicipio.SqlDbType = SqlDbType.VarChar;
                ParIdMunicipio.Value = Encargado.Id_Municipio;
                SqlCmd.Parameters.Add(ParIdMunicipio);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 2054;
                ParTelefono.Value = Encargado.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParFoto = new SqlParameter();
                ParFoto.ParameterName = "@Foto";
                ParFoto.SqlDbType = SqlDbType.Image;
                ParFoto.Value = Encargado.Foto;
                SqlCmd.Parameters.Add(ParFoto);

                SqlParameter ParIdTipoEncargado = new SqlParameter();
                ParIdTipoEncargado.ParameterName = "@Id_Tipo_Encargado";
                ParIdTipoEncargado.SqlDbType = SqlDbType.VarChar;
                ParIdTipoEncargado.Value = Encargado.Id_Tipo_Encargado;
                SqlCmd.Parameters.Add(ParIdTipoEncargado);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParEstado.Value = Encargado.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

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
            DataTable DtResultado = new DataTable("Encargado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_encargado";
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
        public DataTable Dpi(DEncargado Encargado)
        {
            DataTable DtResultado = new DataTable("Encargado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_dpi_encargado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Encargado.TextoBuscar;
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
        public DataTable Apellido(DEncargado Encargado)
        {
            DataTable DtResultado = new DataTable("Encargado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_apellido_encargado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Encargado.TextoBuscar;
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
