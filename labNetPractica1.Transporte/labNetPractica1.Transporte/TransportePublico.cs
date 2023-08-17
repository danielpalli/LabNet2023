using System;
using System.Collections.Generic;

namespace labNetPractica1.Transporte
{
    public abstract class TransportePublico
    {
        public int pasajeros { get; set; }
        public TransportePublico() { }
        public TransportePublico(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }
        public abstract void Avanzar();
        public abstract void Detenerse();
    }
}
