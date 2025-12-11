using ExamenUnidad4y5.Modelos.Adapter;
using ExamenUnidad4y5.Modelos.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad4y5.Modelos
{
    public abstract class Atraccion : IComportamiento
    {
        protected int _numero;
        protected string _nombre;
        protected int _capacidad;

        public int NumeroAtraccion { get => _numero; set => _numero = value; }
        public string NombreAtraccion { get => _nombre; set => _nombre = value; }
        public int CapacidadAtraccion { get => _capacidad; set => _capacidad = value; }

        public IEstado EstadoActual { get; set; }

        public Atraccion()
        {
            EstadoActual = new Libre();
        }

        public abstract Atraccion Clone();
        public abstract string VerAtraccion();

        public abstract void Iniciar();
        public abstract void Detener();
        public abstract void Seguridad();
    }

}