using System;

namespace labNetPractica2.Actividad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PuntoUno();
            PuntoDos();
            PuntoTres();
            PuntoCuatro();
            Console.ReadKey();
        }

        public static void PuntoCuatro()
        {
            try
            {
                Logic.ExepPersonalizada();
            }
            catch (ExepcionPersonalizada e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void PuntoTres()
        {
            try
            {
                Logic logic = new Logic();
                logic.MostrarExepcion();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }
        }

        public static void PuntoDos()
        {
            try
            {
                Console.Write("Ingrese el numerador:");
                double dividendo = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el denominador:");
                double divisor = double.Parse(Console.ReadLine());

                double resultado = Division(dividendo, divisor);
                Console.WriteLine(resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("¡Seguro ingresó una letra o no ingresó nada!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public static double Division(double dividendo, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("¡Solo Chuck Norris divide por cero!");
            }

            return dividendo / divisor;
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
