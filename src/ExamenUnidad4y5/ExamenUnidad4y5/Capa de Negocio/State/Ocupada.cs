using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad4y5.Modelos.State
{
    public class Ocupada : IEstado
    {
        public void PonerLibre(Atraccion atraccion)
        {
            Console.WriteLine("La atracción ahora está libre.");
            atraccion.EstadoActual = new Libre();
        }

        public void PonerOcupada(Atraccion atraccion)
        {
            Console.WriteLine("La atracción ya está ocupada.");
        }

        public void PonerMantenimiento(Atraccion atraccion)
        {
            Console.WriteLine("No se puede poner en mantenimiento mientras está ocupada.");
        }
    }

}
