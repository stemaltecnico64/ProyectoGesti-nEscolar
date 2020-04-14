using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocios
{
   public class NTipo_Encargado
    {
        public static string Insertar(string nombre)
        {
            DTipo_Encargado Obj = new DTipo_Encargado();
            Obj.Nombre = nombre;
            return Obj.Insertar(Obj);
        }

        public static string Editar(int idTipoEncargado, string nombre)
        {
            DTipo_Encargado Obj = new DTipo_Encargado();
            Obj.IdTipoEncargado = idTipoEncargado;
            Obj.Nombre = nombre;
            return Obj.Editar(Obj);
        }

        public static string Eliminar(int idTipoEncargado)
        {
            DTipo_Encargado Obj = new DTipo_Encargado();
            Obj.IdTipoEncargado = idTipoEncargado;
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DTipo_Encargado().Mostrar();
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DTipo_Encargado Obj = new DTipo_Encargado();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
