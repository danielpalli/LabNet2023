using System;
using System.Collections.Generic;

namespace labNetPractica1.Transporte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TransportePublico> transportesBuses = new List<TransportePublico>();
            List<TransportePublico> transportesTaxis = new List<TransportePublico>();

            for (int i = 1; i <= 5; i++)
            {
                Omnibus omnibus = new Omnibus();
                Console.WriteLine($"Ingrese la cantidad de pasajeros para el Omnibus {i}.");
                omnibus.pasajeros = int.Parse(Console.ReadLine());
                transportesBuses.Add( omnibus );
            }

            for (int i = 1; i <= 5; i++)
            {
                Taxi taxis = new Taxi();
                Console.WriteLine($"Ingrese la cantidad de pasajeros para el Taxi {i}.");
                taxis.pasajeros = int.Parse(Console.ReadLine());
                transportesTaxis.Add( taxis );
            }

            int j = 1;
            foreach (var bus in transportesBuses)
            {
                Console.WriteLine($"Ominbus {j}: {bus.Avanzar()}");
                j++;
            }

            j = 1;
            foreach (var taxi in transportesTaxis)
            {
                Console.WriteLine($"Taxi {j}: {taxi.Avanzar()}");
                j++;
            }
            Console.ReadKey();
        }
    }
}
