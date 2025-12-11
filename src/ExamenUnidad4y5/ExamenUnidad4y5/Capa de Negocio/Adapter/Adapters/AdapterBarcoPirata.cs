using ExamenUnidad4y5.Modelos.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad4y5.Capa_de_Negocio.Adapter.Adapters
{
    internal class AdapterBarcoPirata:IComportamiento
    {
        public void Iniciar()
        {
            Console.WriteLine("Mesiendo barco pirata");
        }
        public void Detener()
        {
            Console.WriteLine("Desacelerando barco pirata.");
        }
        public void Seguridad()
        {
            Console.WriteLine("Comprobando sistema de sugeción del barco.");
        }
    }
}
