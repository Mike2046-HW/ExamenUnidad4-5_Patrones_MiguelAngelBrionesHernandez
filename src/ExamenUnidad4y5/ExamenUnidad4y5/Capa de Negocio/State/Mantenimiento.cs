using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad4y5.Modelos.State
{
    public class Mantenimiento : IEstado
    {
        public void PonerLibre(Atraccion atraccion)
        {
            Console.WriteLine("Atracción lista, pasa a estado libre.");
            atraccion.EstadoActual = new Libre();
        }

        public void PonerOcupada(Atraccion atraccion)
        {
            Console.WriteLine("No se puede ocupar: está en mantenimiento.");
        }

        public void PonerMantenimiento(Atraccion atraccion)
        {
            Console.WriteLine("La atracción ya está en mantenimiento.");
        }
    }

}
