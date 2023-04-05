using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeExercicios05.Ex02
{
    internal class Fahrenheit
    {
        internal double fahrenheit;

        public double CalcularCelsius()
        {
            return (fahrenheit - 32) / 1.8;
        }
    }
}
