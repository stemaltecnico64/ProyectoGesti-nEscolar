using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DEmpleado
    {
        private int _Id_Empleado;
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
        private int _Id_Puesto;
        private byte[] _Foto;
        private string _Correo;
        private string _Estado;
        private DateTime _Fecha_Ingreso;
        private string _TextoBuscar;

        public int Id_Empleado { get => _Id_Empleado; set => _Id_Empleado = value; }
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
        public int Id_Puesto { get => _Id_Puesto; set => _Id_Puesto = value; }
        public byte[] Foto { get => _Foto; set => _Foto = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public DateTime Fecha_Ingreso { get => _Fecha_Ingreso; set => _Fecha_Ingreso = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }


        public DEmpleado()
        {

        }

        public DEmpleado(int id_empleado, string dpi, string nombre1, string nombre2, string nombre3, string apellido1, string apellido2, string apellido3, DateTime fecha_nac,
            string sexo, string direccion, int id_municipio, string telefono, int id_puesto, byte[] foto, string correo, string Estado, DateTime fecha_ingreso, string textobuscar)
        {
            this.Id_Empleado = id_empleado;
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
            this.Id_Puesto = id_puesto;
            this.Foto = foto;
            this.Correo = correo;
            this.Estado = Estado;
            this.Fecha_Ingreso = fecha_ingreso;
            this.TextoBuscar = textobuscar;
        }


        public string Insertar(DEmpleado Empleado)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@Id_Empleado";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdEmpleado);

                SqlParameter ParDPI = new SqlParameter();
                ParDPI.ParameterName = "@DPI";
                ParDPI.SqlDbType = SqlDbType.VarChar;
                ParDPI.Size = 50;
                ParDPI.Value = Empleado.DPI;
                SqlCmd.Parameters.Add(ParDPI);

                SqlParameter ParNombre1 = new SqlParameter();
                ParNombre1.ParameterName = "@Nombre_1";
                ParNombre1.SqlDbType = SqlDbType.VarChar;
                ParNombre1.Size = 50;
                ParNombre1.Value = Empleado.Nombre1;
                SqlCmd.Parameters.Add(ParNombre1);

                SqlParameter ParNombre2 = new SqlParameter();
                ParNombre2.ParameterName = "@Nombre_2";
                ParNombre2.SqlDbType = SqlDbType.VarChar;
                ParNombre2.Size = 50;
                ParNombre2.Value = Empleado.Nombre2;
                SqlCmd.Parameters.Add(ParNombre2);

                SqlParameter ParNombre3 = new SqlParameter();
                ParNombre3.ParameterName = "@Nombre_3";
                ParNombre3.SqlDbType = SqlDbType.VarChar;
                ParNombre3.Size = 50;
                ParNombre3.Value = Empleado.Nombre3;
                SqlCmd.Parameters.Add(ParNombre3);

                SqlParameter ParApellido1 = new SqlParameter();
                ParApellido1.ParameterName = "@Apellido_1";
                ParApellido1.SqlDbType = SqlDbType.VarChar;
                ParApellido1.Size = 50;
                ParApellido1.Value = Empleado.Apellido1;
                SqlCmd.Parameters.Add(ParApellido1);

                SqlParameter ParApellido2 = new SqlParameter();
                ParApellido2.ParameterName = "@Apellido_2";
                ParApellido2.SqlDbType = SqlDbType.VarChar;
                ParApellido2.Size = 50;
                ParApellido2.Value = Empleado.Apellido2;
                SqlCmd.Parameters.Add(ParApellido2);

                SqlParameter ParApellido3 = new SqlParameter();
                ParApellido3.ParameterName = "@Apellido_3";
                ParApellido3.SqlDbType = SqlDbType.VarChar;
                ParApellido3.Size = 50;
                ParApellido3.Value = Empleado.Apellido3;
                SqlCmd.Parameters.Add(ParApellido3);

                SqlParameter ParFecha_Nacimiento = new SqlParameter();
                ParFecha_Nacimiento.ParameterName = "@Fecha_Nac";
                ParFecha_Nacimiento.SqlDbType = SqlDbType.DateTime;
                ParFecha_Nacimiento.Value = Empleado.Fecha_Nac;
                SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@Sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 50;
                ParSexo.Value = Empleado.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 2054;
                ParDireccion.Value = Empleado.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);


                SqlParameter ParIdMunicipio = new SqlParameter();
                ParIdMunicipio.ParameterName = "@Id_Municipio";
                ParIdMunicipio.SqlDbType = SqlDbType.VarChar;
                ParIdMunicipio.Value = Empleado.Id_Municipio;
                SqlCmd.Parameters.Add(ParIdMunicipio);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 2054;
                ParTelefono.Value = Empleado.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParIdPuesto = new SqlParameter();
                ParIdPuesto.ParameterName = "@Id_Puesto";
                ParIdPuesto.SqlDbType = SqlDbType.VarChar;
                ParIdPuesto.Value = Empleado.Id_Puesto;
                SqlCmd.Parameters.Add(ParIdPuesto);

                SqlParameter ParFoto = new SqlParameter();
                ParFoto.ParameterName = "@Foto";
                ParFoto.SqlDbType = SqlDbType.Image;
                ParFoto.Value = Empleado.Foto;
                SqlCmd.Parameters.Add(ParFoto);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@Correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 2054;
                ParCorreo.Value = Empleado.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParEstado.Value = Empleado.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParFechaIngreso = new SqlParameter();
                ParFechaIngreso.ParameterName = "@Fecha_Ingreso";
                ParFechaIngreso.SqlDbType = SqlDbType.VarChar;
                ParFechaIngreso.Value = Empleado.Fecha_Ingreso;
                SqlCmd.Parameters.Add(ParFechaIngreso);

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

        public string Editar(DEmpleado Empleado)
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
                SqlCmd.CommandText = "speditar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@Id_Empleado";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Value = Empleado.Id_Empleado;
                SqlCmd.Parameters.Add(ParIdEmpleado);

                SqlParameter ParDPI = new SqlParameter();
                ParDPI.ParameterName = "@DPI";
                ParDPI.SqlDbType = SqlDbType.VarChar;
                ParDPI.Size = 50;
                ParDPI.Value = Empleado.DPI;
                SqlCmd.Parameters.Add(ParDPI);

                SqlParameter ParNombre1 = new SqlParameter();
                ParNombre1.ParameterName = "@Nombre_1";
                ParNombre1.SqlDbType = SqlDbType.VarChar;
                ParNombre1.Size = 50;
                ParNombre1.Value = Empleado.Nombre1;
                SqlCmd.Parameters.Add(ParNombre1);

                SqlParameter ParNombre2 = new SqlParameter();
                ParNombre2.ParameterName = "@Nombre_2";
                ParNombre2.SqlDbType = SqlDbType.VarChar;
                ParNombre2.Size = 50;
                ParNombre2.Value = Empleado.Nombre2;
                SqlCmd.Parameters.Add(ParNombre2);

                SqlParameter ParNombre3 = new SqlParameter();
                ParNombre3.ParameterName = "@Nombre_3";
                ParNombre3.SqlDbType = SqlDbType.VarChar;
                ParNombre3.Size = 50;
                ParNombre3.Value = Empleado.Nombre3;
                SqlCmd.Parameters.Add(ParNombre3);

                SqlParameter ParApellido1 = new SqlParameter();
                ParApellido1.ParameterName = "@Apellido_1";
                ParApellido1.SqlDbType = SqlDbType.VarChar;
                ParApellido1.Size = 50;
                ParApellido1.Value = Empleado.Apellido1;
                SqlCmd.Parameters.Add(ParApellido1);

                SqlParameter ParApellido2 = new SqlParameter();
                ParApellido2.ParameterName = "@Apellido_2";
                ParApellido2.SqlDbType = SqlDbType.VarChar;
                ParApellido2.Size = 50;
                ParApellido2.Value = Empleado.Apellido2;
                SqlCmd.Parameters.Add(ParApellido2);

                SqlParameter ParApellido3 = new SqlParameter();
                ParApellido3.ParameterName = "@Apellido_3";
                ParApellido3.SqlDbType = SqlDbType.VarChar;
                ParApellido3.Size = 50;
                ParApellido3.Value = Empleado.Apellido3;
                SqlCmd.Parameters.Add(ParApellido3);

                SqlParameter ParFecha_Nacimiento = new SqlParameter();
                ParFecha_Nacimiento.ParameterName = "@Fecha_Nac";
                ParFecha_Nacimiento.SqlDbType = SqlDbType.DateTime;
                ParFecha_Nacimiento.Value = Empleado.Fecha_Nac;
                SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@Sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 50;
                ParSexo.Value = Empleado.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 2054;
                ParDireccion.Value = Empleado.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);


                SqlParameter ParIdMunicipio = new SqlParameter();
                ParIdMunicipio.ParameterName = "@Id_Municipio";
                ParIdMunicipio.SqlDbType = SqlDbType.VarChar;
                ParIdMunicipio.Value = Empleado.Id_Municipio;
                SqlCmd.Parameters.Add(ParIdMunicipio);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 2054;
                ParTelefono.Value = Empleado.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParIdPuesto = new SqlParameter();
                ParIdPuesto.ParameterName = "@Id_Puesto";
                ParIdPuesto.SqlDbType = SqlDbType.VarChar;
                ParIdPuesto.Value = Empleado.Id_Puesto;
                SqlCmd.Parameters.Add(ParIdPuesto);

                SqlParameter ParFoto = new SqlParameter();
                ParFoto.ParameterName = "@Foto";
                ParFoto.SqlDbType = SqlDbType.Image;
                ParFoto.Value = Empleado.Foto;
                SqlCmd.Parameters.Add(ParFoto);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@Correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 2054;
                ParCorreo.Value = Empleado.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParEstado.Value = Empleado.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParFechaIngreso = new SqlParameter();
                ParFechaIngreso.ParameterName = "@Fecha_Ingreso";
                ParFechaIngreso.SqlDbType = SqlDbType.VarChar;
                ParFechaIngreso.Value = Empleado.Fecha_Ingreso;
                SqlCmd.Parameters.Add(ParFechaIngreso);

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
            DataTable DtResultado = new DataTable("Empleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_empleado";
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

        public DataTable Apellido(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("Empleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_empleado_apellido";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Empleado.TextoBuscar;
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


        public DataTable Nombre(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("Empleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_empleado_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Empleado.TextoBuscar;
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

        public DataTable dpi(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("Empleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_empleado_dpi";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Empleado.TextoBuscar;
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
