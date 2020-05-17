using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NAlumno
    {
        public static string Insertar(string codigo_alumno, string cui, string nombre1, string nombre2, string nombre3, string apellido1, string apellido2, string apellido3, DateTime fecha_nac,
            string sexo, string direccion, int id_municipio, string telefono, byte[] foto, int id_encargado, string Estado)
        {
            DAlumno Obj = new DAlumno();
            Obj.Codigo_Alumno = codigo_alumno;
            Obj.CUI = cui;
            Obj.Nombre1 = nombre1;
            Obj.Nombre2 = nombre2;
            Obj.Nombre3 = nombre3;
            Obj.Apellido1 = apellido1;
            Obj.Apellido2 = apellido2;
            Obj.Apellido3 = apellido1;
            Obj.Fecha_Nac = fecha_nac;
            Obj.Sexo = sexo;
            Obj.Direccion = direccion;
            Obj.Id_Municipio = id_municipio;
            Obj.Telefono = telefono;
            Obj.Foto = foto;
            Obj.Id_Encargado = id_encargado;
            Obj.Estado = Estado;
            return Obj.Insertar(Obj);
        }

        public static string Editar(int id_alumno, string codigo_alumno, string cui, string nombre1, string nombre2, string nombre3, string apellido1, string apellido2, string apellido3, DateTime fecha_nac,
            string sexo, string direccion, int id_municipio, string telefono, byte[] foto, int id_encargado, string Estado)
        {
            DAlumno Obj = new DAlumno();
            Obj.Id_Alumno = id_alumno;
            Obj.Codigo_Alumno = codigo_alumno;
            Obj.CUI = cui;
            Obj.Nombre1 = nombre1;
            Obj.Nombre2 = nombre2;
            Obj.Nombre3 = nombre3;
            Obj.Apellido1 = apellido1;
            Obj.Apellido2 = apellido2;
            Obj.Apellido3 = apellido1;
            Obj.Fecha_Nac = fecha_nac;
            Obj.Sexo = sexo;
            Obj.Direccion = direccion;
            Obj.Id_Municipio = id_municipio;
            Obj.Telefono = telefono;
            Obj.Foto = foto;
            Obj.Id_Encargado = id_encargado;
            Obj.Estado = Estado;
            return Obj.Editar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DAlumno().Mostrar();
        }
        public static DataTable Apellido(string textobuscar)
        {
            DAlumno Obj = new DAlumno();
            Obj.TextoBuscar = textobuscar;
            return Obj.Apellido(Obj);
        }
        public static DataTable Nombre(string textobuscar)
        {
            DAlumno Obj = new DAlumno();
            Obj.TextoBuscar = textobuscar;
            return Obj.Nombre(Obj);
        }

        public static DataTable cui(string textobuscar)
        {
            DAlumno Obj = new DAlumno();
            Obj.TextoBuscar = textobuscar;
            return Obj.cui(Obj);
        }
    }
}
