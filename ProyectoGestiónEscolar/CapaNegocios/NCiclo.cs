using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NCiclo
    {
        public static string Insertar(string ciclo, string descripcion, string fecha_g, string estado)
        {
            DCiclo Obj = new DCiclo();
            Obj.Ciclo = ciclo;
            Obj.Descripcion = descripcion;
            Obj.Fecha_G = fecha_g;
            Obj.Estado = estado;
            return Obj.Insertar(Obj);
        }
    }
}
