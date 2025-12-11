using ExamenUnidad4y5.Modelos.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad4y5.Capa_de_Negocio.Adapter.Adapters
{
    internal class AdapterMegaDrop:IComportamiento
    {
        public void Iniciar()
        {
            Console.WriteLine("Subiendo plataforma de caída.");
        }
        public void Detener()
        {
            Console.WriteLine("Bajando plataforma de caída.");
        }
        public void Seguridad()
        {
            Console.WriteLine("Comprobando cinturones de seguridad y sistema de frenado de plataforma.");
        }
    }
}
