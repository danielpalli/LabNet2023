using System;
using System.Collections.Generic;

namespace labNetPractica1.Transporte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TransportePublico> transportesBuses = AgregarPasajeroTransporte<Omnibus>("Omnibus");
            List<TransportePublico> transportesTaxis = AgregarPasajeroTransporte<Taxi>("Taxi");

            MostrarInformacionTransporte(transportesBuses, "Omnibus");
            MostrarInformacionTransporte(transportesTaxis, "Taxis");

            Console.ReadKey();
        }

        public static List<TransportePublico> AgregarPasajeroTransporte<T>(string tipoTransporte) where T : TransportePublico, new()
        {
            List<TransportePublico> transportes = new List<TransportePublico>();
            for (int i = 1; i <= 5; i++)
            {
                T transporte = new T();
                Console.WriteLine($"Ingrese la cantidad de pasajeros para el {tipoTransporte} {i}.");
                transporte.pasajeros = int.Parse(Console.ReadLine());
                //Faltaria agregar otras validaciones como si no es un numero, tambien si supera la capacidad maxima del transporte
                if (transporte.pasajeros < 0) transporte.pasajeros = 0;
                
                transportes.Add(transporte);
            }
            return transportes;
        }

        public static void MostrarInformacionTransporte(List<TransportePublico> transportes, string tipoTransporte)
        {
            int i = 1;
            foreach (var transporte in transportes)
            {
                Console.WriteLine($"{tipoTransporte} {i}: {transporte.pasajeros} pasajeros");
                i++;
            }
        }
    }
}
