using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Utils;

namespace Backend.Models.Entidades
{
    public class Proveedor
    {
        public int idProveedor { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string direcccion { get; set; }
        public DateTime fechaRegistro { get; set; }

        public void guardar()
        {
            DataBase.guardarProveedor(this);
        }

        public static Array obtenerDatos()
        {
            return DataBase.obtenerProveedor();

        }
    }
}

