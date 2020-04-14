using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocios
{
    public class NEncargado
    {
        public static string Insertar(string dpi, string nombre1, string nombre2, string nombre3, string apellido1, string apellido2, string apellido3, DateTime fecha_nac,
            string sexo, string direccion, int id_municipio, string telefono, byte[] foto, int id_tipo_encargado, string Estado)
        {
            DEncargado Obj = new DEncargado();
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
            Obj.Foto = foto;
            Obj.Id_Tipo_Encargado = id_tipo_encargado;
            Obj.Estado = Estado;
            return Obj.Insertar(Obj);
        }

        public static string Editar(int id_encargado, string dpi, string nombre1, string nombre2, string nombre3, string apellido1, string apellido2, string apellido3, DateTime fecha_nac,
            string sexo, string direccion, int id_municipio, string telefono, byte[] foto, int id_tipo_encargado, string Estado)
        {
            DEncargado Obj = new DEncargado();
            Obj.Id_Encargado = id_encargado;
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
            Obj.Foto = foto;
            Obj.Id_Tipo_Encargado = id_tipo_encargado;
            Obj.Estado = Estado;
            return Obj.Editar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DEncargado().Mostrar();
        }
        public static DataTable Dpi(string textobuscar)
        {
            DEncargado Obj = new DEncargado();
            Obj.TextoBuscar = textobuscar;
            return Obj.Dpi(Obj);
        }

        public static DataTable Apellido(string textobuscar)
        {
            DEncargado Obj = new DEncargado();
            Obj.TextoBuscar = textobuscar;
            return Obj.Apellido(Obj);
        }
    }
}
