using System;

namespace labNetPractica2.Actividad2
{
    internal class Logic { 
        public void MostrarExepcion()
        {
            throw new Exception("Esta es una excepcion");
        }
        public static void ExepPersonalizada()
        {
            throw new ExepcionPersonalizada();
        }
    }
}
