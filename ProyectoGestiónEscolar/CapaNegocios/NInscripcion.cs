using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocios
{
    public class NInscripcion
    {
        public static string Insertar(int id_ciclo, int id_carrera, int id_tipo_inscripcion, int id_alumno, int id_grado, int id_seccion, DateTime fecha, string estado)
        {
            DInscripcion Obj = new DInscripcion();
            Obj.IdCiclo = id_ciclo;
            Obj.IdCarrera = id_carrera;
            Obj.IdTipoInscripcion = id_tipo_inscripcion;
            Obj.IdAlumno = id_alumno;
            Obj.IdGrado = id_grado;
            Obj.IdSeccion = id_seccion;
            Obj.Fecha = fecha;
            Obj.Estado = estado;
            return Obj.Insertar(Obj);
        }
    }
}
