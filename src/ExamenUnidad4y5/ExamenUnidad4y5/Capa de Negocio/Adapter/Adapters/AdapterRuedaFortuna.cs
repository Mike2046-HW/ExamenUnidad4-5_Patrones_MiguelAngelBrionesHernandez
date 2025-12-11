using ExamenUnidad4y5.Modelos.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad4y5.Capa_de_Negocio.Adapter.Adapters
{
    internal class AdapterRuedaFortuna:IComportamiento
    {
        public void Iniciar()
        {
            Console.WriteLine("Acelerando rueda de la fortuna.");
        }
        public void Detener()
        {
            Console.WriteLine("Reduciendo velocidad de giro.");
        }
        public void Seguridad()
        {
            Console.WriteLine("Comprobando sistema de giro y puertas de cabinas");
        }
    }
}
