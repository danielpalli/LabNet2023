using System;

namespace labNetPractica1.Transporte
{
    public class Omnibus : TransportePublico
    {
        public Omnibus() { }
        public override string Avanzar() => $"{pasajeros} pasajeros";

        public override void Detenerse() { }
    }
}
