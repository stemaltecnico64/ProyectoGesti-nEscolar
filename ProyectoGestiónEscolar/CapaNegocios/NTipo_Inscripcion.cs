using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocios
{
    public class NTipo_Inscripcion
    {

        public static string Insertar(string nombre)
        {
            DTipo_Inscripcion Obj = new DTipo_Inscripcion();
            Obj.Nombre = nombre;
            return Obj.Insertar(Obj);
        }

        public static string Editar(int idtipoinscripcion, string nombre)
        {
            DTipo_Inscripcion Obj = new DTipo_Inscripcion();
            Obj.IdTipoInscripcion = idtipoinscripcion;
            Obj.Nombre = nombre;
            return Obj.Editar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DTipo_Inscripcion().Mostrar();
        }

    }
}
