using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeExercicios05.Ex01
{
    internal class CaixaRetangular
    {
        internal int altura;
        internal int comprimento;
        internal int largura;

        public decimal CalcularVolume()
        {
            return altura * comprimento * largura;
        }
    }
}
