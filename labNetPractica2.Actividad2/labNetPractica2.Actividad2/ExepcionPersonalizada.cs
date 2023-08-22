using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.Actividad2
{
    internal class ExepcionPersonalizada : Exception
    {

        public ExepcionPersonalizada() : base("Mensaje excepcion nuevo")
        {

        }
    }
}
