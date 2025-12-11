using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad4y5.Modelos.Adapter
{
    public interface IComportamiento
    {
        void Iniciar();
        void Detener();
        void Seguridad();
    }
}
