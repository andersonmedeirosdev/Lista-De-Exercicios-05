using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeExercicios05.Ex07
{
    internal class Salario
    {
        internal double salario = 1000, totalVendas = 10000;
        internal double percentualComissao = 0.01, totalSalario, comissao;

        public double CalcularSalario()
        {
            comissao = totalVendas * percentualComissao;
            return totalSalario = salario + comissao;
        }
    }
}
