using ExamenUnidad4y5.Capa_de_Negocio.Adapter.Adapters;
using ExamenUnidad4y5.Modelos;
using ExamenUnidad4y5.Modelos.Adapter;
using ExamenUnidad4y5.Modelos.Adapter.Adapters;
using ExamenUnidad4y5.Modelos.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad4y5.Capa_de_Negocio.Prototype
{
    internal class RuedaFortuna:Atraccion
    {
        private IComportamiento _comportamiento;

        public RuedaFortuna()
        {
            NombreAtraccion = "Rueda de la Fortuna";
            CapacidadAtraccion = 50;
            _comportamiento = new AdapterCarrusel();
        }

        public RuedaFortuna(RuedaFortuna original)
        {
            NombreAtraccion = original.NombreAtraccion;
            NumeroAtraccion = original.NumeroAtraccion;
            CapacidadAtraccion = original.CapacidadAtraccion;

            _comportamiento = new AdapterRuedaFortuna();

            EstadoActual = new Libre();
        }

        public override Atraccion Clone()
        {
            return new RuedaFortuna(this);
        }

        public override string VerAtraccion()
        {
            return $"{NumeroAtraccion}. {NombreAtraccion}, capacidad: {CapacidadAtraccion} personas";
        }

        public override void Iniciar() => _comportamiento.Iniciar();
        public override void Detener() => _comportamiento.Detener();
        public override void Seguridad() => _comportamiento.Seguridad();

    }
}
