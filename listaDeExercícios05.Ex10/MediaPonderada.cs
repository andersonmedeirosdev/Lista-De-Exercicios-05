using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeExercícios05.Ex10
{
    internal class MediaPonderada
    {
        internal double nota1 = 10, nota2 = 8, nota3 = 7, nota4 = 6, mediaP, calculo1, calculo2;
        internal double peso1 = 1, peso2 = 2, peso3 = 3, peso4 = 4;

        public double CalcularMedia()
        {
            calculo1 = nota1 * peso1 + nota2 * peso2 + nota3 * peso3 + nota4 * peso4;
            calculo2 = peso1 + peso2 + peso3 + peso4;
            mediaP = calculo1 / calculo2;
            return mediaP;
        }
    }
}
