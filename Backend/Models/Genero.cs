using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Utils;

namespace Backend.Models
{
    public class Genero
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public void guardar()
        {
            DataBase.guardarGenero(this);
        }

        public static Array obtener()
        {
            return DataBase.obtenerGeneros();
        }

        public void actualizar()
        {
            DataBase.guardarGenero(this);
        }

        public void eliminar()
        {
            throw new NotImplementedException("Eliminar genero no esta implementado todavia.");
        }
    }
}