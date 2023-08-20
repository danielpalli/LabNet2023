using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.Actividad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PuntoUno();
        }

        public static void PuntoUno()
        {
            Console.WriteLine("Ingrese un valor:");
            double valor = double.Parse(Console.ReadLine());

            try
            {
                GenerarExcepcion(valor);
                Console.WriteLine("Operacion exitosa");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Si se muestra esto, termino de realizarse la operacion");
            }
        }
        public static void GenerarExcepcion(double valor)
        {
            double denominador = 0;

            if (denominador == 0) throw new DivideByZeroException();

            double resultado = valor / denominador;

            Console.WriteLine(resultado);
        }
    }
}
