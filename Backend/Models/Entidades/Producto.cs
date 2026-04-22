using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Utils;

namespace Backend.Models.Entidades
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public string descripcionProducto { get; set; }
        public float precio { get; set; }
        public int stock { get; set; }
        public int? idProveedor { get; set; }
        public Proveedor proveedor { get; set; }

        public void guardar()
        {
            DataBase.agregarProducto(this);
        }
        public static Array obtenerDatos()
        {
            return DataBase.obtenerProducto();
        }

    }
}
