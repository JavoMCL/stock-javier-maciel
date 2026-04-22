using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Utils;

namespace Backend.Models.Entidades
{
    public class Cliente
    {
        public int idCliente { get; set; }
 
        public string nombreCliente { get; set; }
       public string apellidoCliente { get; set; }
        public string numDocumento { get; set; }

        public string emailCliente { get; set; }
        public int? idGenero { get; set; }
        public Genero genero { get; set; }
        public int? idTipoTelefono { get; set; }
        public TipoTelefono tipoTelefono { get; set; }
        public string telefonoCliente { get; set; }
        public string direccionCliente { get; set;}
        public DateTime fechaRegistroCliente { get; set; }

        public void guardar()
        {
            DataBase.guardarCliente(this);
        }

        public static Array obtenerDatos()
        {
            return DataBase.obtenerCliente();
        }
        
    }
}
