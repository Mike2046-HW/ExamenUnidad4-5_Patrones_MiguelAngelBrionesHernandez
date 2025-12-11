using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad4y5.Modelos.Adapter
{
    internal class AdapterMontañaRusa : IComportamiento
    {
        public void Iniciar()
        {
            Console.WriteLine("Montaña rusa acelerando.");
        }
        public void Detener()
        {
            Console.WriteLine("Montaña rusa desacelerando... Regresando a plataforma.");
        }
        public void Seguridad()
        {
            Console.WriteLine("Comprobando medidas de seguridad.");
        }
    }
}
