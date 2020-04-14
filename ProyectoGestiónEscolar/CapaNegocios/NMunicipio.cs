using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocios
{
   public class NMunicipio
    {
        public static string Insertar(string nombre, string descripcion, int iddepartamento)
        {
            DMunicipio Obj = new DMunicipio();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.IdDepartamento = iddepartamento;
            return Obj.Insertar(Obj);
        }


        public static string Editar(int idmunicipio, string nombre, string descripcion, int iddepartamento)
        {
            DMunicipio Obj = new DMunicipio();
            Obj.IdMunicipio = idmunicipio;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.IdDepartamento = iddepartamento;
            return Obj.Editar(Obj);
        }


        public static string Eliminar(int idmunicipio)
        {
            DMunicipio Obj = new DMunicipio();
            Obj.IdMunicipio = idmunicipio;
            return Obj.Eliminar(Obj);
        }


        public static DataTable Mostrar()
        {
            return new DMunicipio().Mostrar();
        }



        public static DataTable BuscarNombre(string textobuscar)
        {
            DMunicipio Obj = new DMunicipio();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
