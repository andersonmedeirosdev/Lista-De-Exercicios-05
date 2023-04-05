using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeExercicios05.Ex03
{
    internal class Cilindro
    {
        internal int raio;
        internal int altura;

        public decimal CalcularVolume()
        {
            return 3.14M * (raio * raio) * altura;
        }
    }
}
