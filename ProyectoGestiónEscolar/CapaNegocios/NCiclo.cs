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
        public static string Insertar(string ciclo, string descripcion, DateTime fecha_g, string estado)
        {
            DCiclo Obj = new DCiclo();
            Obj.Ciclo = ciclo;
            Obj.Descripcion = descripcion;
            Obj.Fecha_G = fecha_g;
            Obj.Estado = estado;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int idciclo, string ciclo, string descripcion, DateTime fecha_g, string estado)
        {
            DCiclo Obj = new DCiclo();
            Obj.IdCiclo = idciclo;
            Obj.Ciclo = ciclo;
            Obj.Descripcion = descripcion;
            Obj.Fecha_G = fecha_g;
            Obj.Estado = estado;
            return Obj.Editar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DCiclo().Mostrar();
        }

        public static DataTable MostrarCicloActivos()
        {
            return new DCiclo().MostrarCicloActivos();
        }
    }
}
