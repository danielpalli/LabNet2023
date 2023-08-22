using System;


namespace labNetPractica2.Actividad2
{
    public static class PuntoUno
    {
        public static double GenerarExcepcion(this double denominador, double valor)
        {
            if (denominador == 0) throw new DivideByZeroException();
            return valor / denominador;
        }
    }
}
