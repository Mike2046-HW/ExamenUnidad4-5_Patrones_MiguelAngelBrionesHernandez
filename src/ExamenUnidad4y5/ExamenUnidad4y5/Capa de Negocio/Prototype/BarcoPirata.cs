using ExamenUnidad4y5.Modelos;
using ExamenUnidad4y5.Modelos.Adapter.Adapters;
using ExamenUnidad4y5.Modelos.Adapter;
using ExamenUnidad4y5.Modelos.Prototype;
using ExamenUnidad4y5.Modelos.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenUnidad4y5.Capa_de_Negocio.Adapter.Adapters;

namespace ExamenUnidad4y5.Capa_de_Negocio.Prototype
{
    internal class BarcoPirata:Atraccion
    {
        private IComportamiento _comportamiento;

        public BarcoPirata()
        {
            NombreAtraccion = "Barco Pirata";
            CapacidadAtraccion = 25;
            _comportamiento = new AdapterBarcoPirata();
        }

        private BarcoPirata(BarcoPirata original)
        {
            NombreAtraccion = original.NombreAtraccion;
            NumeroAtraccion = original.NumeroAtraccion;
            CapacidadAtraccion = original.CapacidadAtraccion;

            _comportamiento = new AdapterBarcoPirata();

            EstadoActual = new Libre();
        }

        public override Atraccion Clone()
        {
            return new BarcoPirata(this);
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
