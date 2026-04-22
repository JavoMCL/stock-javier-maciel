using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Utils;

namespace Backend.Models.Entidades
{
    public class Compras
    {
        public int idCompra { get; set; }
        public int? idProveedor { get; set; }
        public Proveedor proveedor { get; set; }
        public DateTime fechaCompra { get; set; }
    
        public float total { get; set; }

        public void guardar()
        {
            DataBase.agregarCompra(this);
        }
        public static Array obtenerDatos()
        {
            return DataBase.ObtenerCompra();
        }

    }

}

