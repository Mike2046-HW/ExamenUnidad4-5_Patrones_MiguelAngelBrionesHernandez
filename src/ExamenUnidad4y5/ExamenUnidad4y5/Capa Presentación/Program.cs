using ExamenUnidad4y5.Modelos.Prototype;
using ExamenUnidad4y5.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenUnidad4y5.Modelos.State;
using ExamenUnidad4y5.Capa_de_Negocio.Prototype;

namespace ExamenUnidad4y5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MontañaRusa plantillaMontaña = new MontañaRusa();
            Carrusel plantillaCarrusel = new Carrusel();
            RuedaFortuna plantillaRueda = new RuedaFortuna();
            BarcoPirata plantillaBarco = new BarcoPirata();
            MegaDrop plantillaM = new MegaDrop();

            Atraccion montañaRusa = plantillaMontaña.Clone(); montañaRusa.NumeroAtraccion = 1;
            Atraccion carrusel = plantillaCarrusel.Clone(); carrusel.NumeroAtraccion = 2;
            Atraccion ruedaF = plantillaRueda.Clone(); ruedaF.NumeroAtraccion = 3;
            Atraccion barco = plantillaBarco.Clone(); barco.NumeroAtraccion = 4;
            Atraccion mega = plantillaM.Clone(); mega.NumeroAtraccion = 5;

            List<Atraccion> atracciones = new List<Atraccion>()
            {
                montañaRusa, carrusel, ruedaF, barco, mega
            };

            MenuPrincipal(atracciones);
        }

        static decimal dineroTotal = 0;
        static decimal precioUso = 15;

        static void MenuPrincipal(List<Atraccion> atracciones)
        {
            string opcion = "";

            while (opcion != "0")
            {
                Console.Clear();
                Console.WriteLine("=== PARQUE DE ATRACCIONES ===\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Ingresos totales del parque: ${dineroTotal}\n");
                Console.ResetColor();


                foreach (var atr in atracciones)
                {
                    string estado = atr.EstadoActual.GetType().Name;

                    switch (estado)
                    {
                        case "Libre":
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case "Ocupada":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        case "Mantenimiento":
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                    }

                    Console.WriteLine($"{atr.NumeroAtraccion}. {atr.NombreAtraccion} - Estado: {estado}");
                    Console.ResetColor();
                }

                Console.Write("\nSeleccione una atracción (0 para salir): ");
                opcion = Console.ReadLine();

                if (opcion == "0")
                    break;

                if (int.TryParse(opcion, out int num))
                {
                    var seleccionada = atracciones.FirstOrDefault(a => a.NumeroAtraccion == num);

                    if (seleccionada != null)
                        MenuAtraccion(seleccionada);
                    else
                    {
                        Console.WriteLine("Atracción no encontrada.");
                        Console.ReadKey();
                    }
                }
            }

            Console.WriteLine("Saliendo del sistema...");
        }

        static void MenuAtraccion(Atraccion atr)
        {
            string opcion = "";

            while (opcion != "0")
            {
                Console.Clear();
                Console.WriteLine($"=== CONTROL DE {atr.NombreAtraccion.ToUpper()} ===\n");

                Console.WriteLine(atr.VerAtraccion());
                Console.WriteLine($"Estado actual: {atr.EstadoActual.GetType().Name}");
                Console.WriteLine($"Dinero del parque: {dineroTotal}\n");

                Console.WriteLine("1. Operación (Iniciar / Detener / Seguridad)");
                Console.WriteLine("2. Cambiar Estado (Libre / Ocupada / Mantenimiento)");
                Console.WriteLine("0. Volver al menú principal");
                Console.Write("\nSeleccione una opción: ");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        SubMenuOperacion(atr);
                        break;

                    case "2":
                        SubMenuEstados(atr);
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void SubMenuOperacion(Atraccion atr)
        {
            string opcion = "";

            while (opcion != "0")
            {
                Console.Clear();
                Console.WriteLine($"--- OPERACIÓN: {atr.NombreAtraccion} ---\n");

                Console.WriteLine("1. Iniciar (marca Ocupada y genera dinero)");
                Console.WriteLine("2. Detener (marca Libre)");
                Console.WriteLine("3. Seguridad");
                Console.WriteLine("0. Volver\n");
                Console.Write("Opción: ");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        atr.Iniciar();
                        atr.EstadoActual.PonerOcupada(atr);
                        GenerarIngreso();
                        break;

                    case "2":
                        atr.Detener();
                        atr.EstadoActual.PonerLibre(atr);
                        break;

                    case "3":
                        atr.Seguridad();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine("\nPresione cualquier tecla...");
                Console.ReadKey();
            }
        }

        static void SubMenuEstados(Atraccion atr)
        {
            string opcion = "";

            while (opcion != "0")
            {
                Console.Clear();
                Console.WriteLine($"--- ESTADOS: {atr.NombreAtraccion} ---\n");

                Console.WriteLine("1. Poner Libre");
                Console.WriteLine("2. Poner Ocupada");
                Console.WriteLine("3. Poner Mantenimiento");
                Console.WriteLine("0. Volver\n");
                Console.Write("Opción: ");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        atr.EstadoActual.PonerLibre(atr);
                        break;

                    case "2":
                        atr.EstadoActual.PonerOcupada(atr);
                        GenerarIngreso();
                        break;

                    case "3":
                        atr.EstadoActual.PonerMantenimiento(atr);
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine("\nPresione cualquier tecla...");
                Console.ReadKey();
            }
        }

        static void GenerarIngreso()
        {
            dineroTotal += precioUso;
        }
    }
}