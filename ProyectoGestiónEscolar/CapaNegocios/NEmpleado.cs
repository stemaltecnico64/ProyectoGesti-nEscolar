using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocios
{
    public class NEmpleado
    {
        public static string Insertar(string dpi, string nombre1, string nombre2, string nombre3, string apellido1, string apellido2, string apellido3, DateTime fecha_nac,
            string sexo, string direccion, int id_municipio, string telefono, int id_puesto, byte[] foto, string correo, string Estado, DateTime fecha_ingreso)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.DPI = dpi;
            Obj.Nombre1 = nombre1;
            Obj.Nombre2 = nombre2;
            Obj.Nombre3 = nombre3;
            Obj.Apellido1 = apellido1;
            Obj.Apellido2 = apellido2;
            Obj.Apellido3 = apellido3;
            Obj.Fecha_Nac = fecha_nac;
            Obj.Sexo = sexo;
            Obj.Direccion = direccion;
            Obj.Id_Municipio = id_municipio;
            Obj.Telefono = telefono;
            Obj.Id_Puesto = id_puesto;
            Obj.Foto = foto;
            Obj.Correo = correo;
            Obj.Estado = Estado;
            Obj.Fecha_Ingreso = fecha_ingreso;
            return Obj.Insertar(Obj);
        }

        public static string Editar(int id_empleado, string dpi, string nombre1, string nombre2, string nombre3, string apellido1, string apellido2, string apellido3, DateTime fecha_nac,
            string sexo, string direccion, int id_municipio, string telefono, int id_puesto, byte[] foto, string correo, string Estado, DateTime fecha_ingreso)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Id_Empleado = id_empleado;
            Obj.DPI = dpi;
            Obj.Nombre1 = nombre1;
            Obj.Nombre2 = nombre2;
            Obj.Nombre3 = nombre3;
            Obj.Apellido1 = apellido1;
            Obj.Apellido2 = apellido2;
            Obj.Apellido3 = apellido1;
            Obj.Fecha_Nac = fecha_nac;
            Obj.Sexo = sexo;
            Obj.Direccion = direccion;
            Obj.Id_Municipio = id_municipio;
            Obj.Telefono = telefono;
            Obj.Id_Puesto = id_puesto;
            Obj.Foto = foto;
            Obj.Correo = correo;
            Obj.Estado = Estado;
            Obj.Fecha_Ingreso = fecha_ingreso;
            return Obj.Editar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DEmpleado().Mostrar();
        }
        public static DataTable Apellido(string textobuscar)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.TextoBuscar = textobuscar;
            return Obj.Apellido(Obj);
        }
        public static DataTable Nombre(string textobuscar)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.TextoBuscar = textobuscar;
            return Obj.Nombre(Obj);
        }

        public static DataTable dpi(string textobuscar)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.TextoBuscar = textobuscar;
            return Obj.dpi(Obj);
        }

    }
}
