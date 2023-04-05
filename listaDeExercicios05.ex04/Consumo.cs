using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeExercicios05.ex04
{
    internal class Consumo
    {
        internal double kminicial = 10000;
        internal double kmfinal = 15000;
        internal double kmtotal;
        internal double litrosgastos;
        internal double consumototal;

        public double CalcularConsumo()
        {
            kmtotal = kmfinal - kminicial;
            litrosgastos = 120;
            consumototal = (kmtotal / litrosgastos);
            return Math.Round(consumototal, 2);
        }
    }
}
