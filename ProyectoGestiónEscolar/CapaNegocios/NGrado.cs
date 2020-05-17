using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
   public class NGrado
    {

        public static string Insertar(string nombre)
        {
            DGrado Obj = new DGrado();
            Obj.Nombre = nombre;
            return Obj.Insertar(Obj);
        }

        public static string Editar(int idgrado, string nombre)
        {
            DGrado Obj = new DGrado();
            Obj.IdGrado = idgrado;
            Obj.Nombre = nombre;
            return Obj.Editar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DGrado().Mostrar();
        }

    }
}
