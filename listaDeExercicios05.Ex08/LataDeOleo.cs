using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeExercicios05.Ex08
{
    internal class LataDeOleo
    {
        internal double raio = 10, altura = 30, volume;

        public double CalcularVolume()
        {
            volume = Math.PI * Math.Pow(raio, 3) * altura;
            return Math.Round(volume, 2);
        }
    }
}
