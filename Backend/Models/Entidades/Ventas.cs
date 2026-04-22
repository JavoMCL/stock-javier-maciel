using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Utils;

namespace Backend.Models.Entidades
{
    public class Ventas
    {
        public int idVenta { get; set; }
        public int? idCliente { get; set; }
        public Cliente cliente { get; set; }
        public DateTime fechaVenta { get; set; }
        public float total { get; set; }
        public string formaPago { get; set; }


        public void guardar()
        {

            DataBase.guardarVenta(this);
        }

        public static Array obtenerDatos()
        {
            return DataBase.ObtenerVentas();
        }
    }

}

