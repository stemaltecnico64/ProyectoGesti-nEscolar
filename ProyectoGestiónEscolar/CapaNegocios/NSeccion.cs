using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocios
{
   public class NSeccion
    {
        public static string Insertar(string nombre)
        {
            DSeccion Obj = new DSeccion();
            Obj.Nombre = nombre;
            return Obj.Insertar(Obj);
        }

        public static string Editar(int idseccion, string nombre)
        {
            DSeccion Obj = new DSeccion();
            Obj.IdSeccion = idseccion;
            Obj.Nombre = nombre;
            return Obj.Editar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DSeccion().Mostrar();
        }

    }
}
