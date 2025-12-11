using ExamenUnidad4y5.Modelos.Adapter;
using ExamenUnidad4y5.Modelos.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad4y5.Modelos.Prototype
{
    internal class MontañaRusa : Atraccion
    {
        private IComportamiento _comportamiento;

        public MontañaRusa()
        {
            NombreAtraccion = "Montaña Rusa";
            CapacidadAtraccion = 20;
            _comportamiento = new AdapterMontañaRusa();
        }

        private MontañaRusa(MontañaRusa original)
        {
            NombreAtraccion = original.NombreAtraccion;
            NumeroAtraccion = original.NumeroAtraccion;
            CapacidadAtraccion = original.CapacidadAtraccion;

            _comportamiento = new AdapterMontañaRusa();

            EstadoActual = new Libre();
        }

        public override Atraccion Clone()
        {
            return new MontañaRusa(this);
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