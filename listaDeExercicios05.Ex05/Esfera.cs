using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeExercicios05.Ex05
{
    internal class Esfera
    {
        internal double raio = 10, volume;

        public double CalcularVolume()
        {
          volume = (1.33 * Math.PI) * Math.Pow(raio, 3);
          return Math.Round(volume, 2);
        }
    }
}
