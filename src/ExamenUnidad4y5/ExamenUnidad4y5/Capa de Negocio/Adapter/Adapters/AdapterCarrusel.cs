using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad4y5.Modelos.Adapter.Adapters
{
    internal class AdapterCarrusel:IComportamiento
    {
        public void Iniciar()
        {
            Console.WriteLine("Iniciando giro de carrusel.");
        }
        public void Detener()
        {
            Console.WriteLine("Desacelerando carrusel");
        }
        public void Seguridad()
        {
            Console.WriteLine("Comprobando estado de sistema de giro.");
        }
    }
}
