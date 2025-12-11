using ExamenUnidad4y5.Modelos.Adapter;
using ExamenUnidad4y5.Modelos.Adapter.Adapters;
using ExamenUnidad4y5.Modelos.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad4y5.Modelos.Prototype
{
    internal class Carrusel:Atraccion
    {
        private IComportamiento _comportamiento;

        public Carrusel()
        {
            NombreAtraccion = "Carrusel";
            CapacidadAtraccion = 12;
            _comportamiento = new AdapterCarrusel();
        }

        private Carrusel(Carrusel original)
        {
            NombreAtraccion = original.NombreAtraccion;
            NumeroAtraccion = original.NumeroAtraccion;
            CapacidadAtraccion = original.CapacidadAtraccion;

            _comportamiento = new AdapterCarrusel();

            EstadoActual = new Libre();
        }

        public override Atraccion Clone()
        {
            return new Carrusel(this);
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
