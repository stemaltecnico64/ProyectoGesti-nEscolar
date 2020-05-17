using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocios
{
   public class NCarrera
    {
        public static string Insertar(string nombre)
        {
            DCarrera Obj = new DCarrera();
            Obj.Nombre = nombre;
            return Obj.Insertar(Obj);
        }

        public static string Editar(int idcarrera, string nombre)
        {
            DCarrera Obj = new DCarrera();
            Obj.IdCarrera = idcarrera;
            Obj.Nombre = nombre;
            return Obj.Editar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DCarrera().Mostrar();
        }
    }
}
