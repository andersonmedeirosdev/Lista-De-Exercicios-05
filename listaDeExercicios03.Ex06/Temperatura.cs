using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeExercicios05.Ex06
{
    internal class Temperatura
    {
        internal double celsius = 30, fahrenheit;

        public double CalcularTemperaturaF()
        {
           return fahrenheit = (celsius * 1.8) + 32;
        }
    }
}
