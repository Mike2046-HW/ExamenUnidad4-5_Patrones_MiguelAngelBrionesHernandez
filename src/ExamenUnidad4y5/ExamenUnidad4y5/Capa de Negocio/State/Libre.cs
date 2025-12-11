using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad4y5.Modelos.State
{
    public class Libre : IEstado
    {
        public void PonerLibre(Atraccion atraccion)
        {
            Console.WriteLine("La atracción ya está libre.");
        }

        public void PonerOcupada(Atraccion atraccion)
        {
            Console.WriteLine("La atracción pasa a estar ocupada.");
            atraccion.EstadoActual = new Ocupada();
        }

        public void PonerMantenimiento(Atraccion atraccion)
        {
            Console.WriteLine("La atracción se pone en mantenimiento.");
            atraccion.EstadoActual = new Mantenimiento();
        }
    }

}
