using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;
namespace CapaNegocios
{
    public class NPuesto
    {
        public static string Insertar(string puesto)
        {
            DPuesto Obj = new DPuesto();
            Obj.Puesto = puesto;
            return Obj.Insertar(Obj);
        }


        public static string Editar(int idpuesto, string puesto)
        {
            DPuesto Obj = new DPuesto();
            Obj.IdPuesto = idpuesto;
            Obj.Puesto = puesto;
            return Obj.Editar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DPuesto().Mostrar();
        }



        public static DataTable BuscarNombre(string textobuscar)
        {
            DPuesto Obj = new DPuesto();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

    }
}
