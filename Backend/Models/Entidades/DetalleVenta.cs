using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models.Entidades
{
    public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }
        public int? idVenta { get; set; }
        public Ventas venta { get; set; }
        public int? idProducto { get; set; }
        public Producto producto { get; set; }
        public int cantidad { get; set; }
        public float precioUnitario { get; set; } 
    public float subTotal { get; set; }

    }
}
