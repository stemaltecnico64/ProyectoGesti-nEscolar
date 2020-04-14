using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocios
{
    public class NDepartamento
    {
        public static string Insertar(string nombre, string descripcion)
        {
            DDepartamento Obj = new DDepartamento();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }


        public static string Editar(int iddepartamento, string nombre, string descripcion)
        {
            DDepartamento Obj = new DDepartamento();
            Obj.IdDepartamento = iddepartamento;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }


        public static string Eliminar(int iddepartamento)
        {
            DDepartamento Obj = new DDepartamento();
            Obj.IdDepartamento = iddepartamento;
            return Obj.Eliminar(Obj);
        }


        public static DataTable Mostrar()
        {
            return new DDepartamento().Mostrar();
        }



        public static DataTable BuscarNombre(string textobuscar)
        {
            DDepartamento Obj = new DDepartamento();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }


    }
}
