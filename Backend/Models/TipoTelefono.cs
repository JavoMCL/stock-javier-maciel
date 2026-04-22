using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Backend.Utils;

namespace Backend.Models
{
    public class TipoTelefono
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public void guardar()
        {
            DataBase.guardarTipoTelefono(this);
        }

        public static Array obtener()
        {
            return DataBase.obtenerTipoTelefono();
        }

        public void actualizar()
        {
            DataBase.guardarTipoTelefono(this);
        }

        public void eliminar()
        {
            throw new NotImplementedException("Eliminar tipo de telefono no esta implementado todavia.");
        }
    }
}