using System;

namespace labNetPractica2.Actividad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PuntoUno();
            //PuntoDos();
        }

        public static void PuntoDos()
        {
            try
            {
                Console.Write("Ingrese el numerador:");
                double dividendo = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el denominador:");
                double divisor = double.Parse(Console.ReadLine());

                double resultado = Program.Division(dividendo, divisor);
                Console.WriteLine(resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("¡Seguro ingresó una letra o no ingresó nada!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("¡Solo Chuck Norris divide por cero!");
            }
        }


        public static double Division(double a, double b)
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("¡Solo Chuck Norris divide por cero!");
                }

                return a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return -1; //La unica forma que no me tire error. Sino me marcaba error. Hay alguna forma de resolver esto sin retornar -1?
            }
        }
       
        public static void PuntoUno()
        {
            try {

                double denominador = 0;
                Console.WriteLine("Ingrese un valor:");
                double valor = double.Parse(Console.ReadLine());
                double result = denominador.GenerarExcepcion(valor);

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

    }
}
