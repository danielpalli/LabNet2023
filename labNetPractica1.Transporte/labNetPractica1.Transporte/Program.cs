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

            MostrarInformacion(transportesTaxis, "Taxis");
            MostrarInformacion(transportesBuses, "Omnibus");

            Console.ReadKey();
        }

        public static void MostrarInformacion(List<TransportePublico> transportes, string tipoTransporte)
        {
            int i = 1;
            foreach (var transporte in transportes)
            {
                Console.WriteLine($"{tipoTransporte} {i}: {transporte.Avanzar()}");
                i++;
            }
        }
    }
}
