using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1.Transporte
{
    public class Taxi : TransportePublico
    {
        public Taxi() { }
        public override string Avanzar() => $"{pasajeros} pasajeros";
        public override void Detenerse() { }
    }
}
