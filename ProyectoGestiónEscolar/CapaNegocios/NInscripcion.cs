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


        public static string Editar(int id_inscripcion, int id_ciclo, int id_carrera, int id_tipo_inscripcion, int id_alumno, int id_grado, int id_seccion, DateTime fecha, string estado)
        {
            DInscripcion Obj = new DInscripcion();
            Obj.IdInscripcion = id_inscripcion;
            Obj.IdCiclo = id_ciclo;
            Obj.IdCarrera = id_carrera;
            Obj.IdTipoInscripcion = id_tipo_inscripcion;
            Obj.IdAlumno = id_alumno;
            Obj.IdGrado = id_grado;
            Obj.IdSeccion = id_seccion;
            Obj.Fecha = fecha;
            Obj.Estado = estado;
            return Obj.Editar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DInscripcion().Mostrar();
        }
        public static DataTable BuscarCUI(string textobuscar)
        {
            DInscripcion Obj = new DInscripcion();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCUI(Obj);
        }
    }
}
