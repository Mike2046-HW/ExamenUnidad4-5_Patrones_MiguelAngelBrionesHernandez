using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad4y5.Modelos.State
{
    public interface IEstado
    {
        void PonerLibre(Atraccion atraccion);
        void PonerOcupada(Atraccion atraccion);
        void PonerMantenimiento(Atraccion atraccion);
    }

}
