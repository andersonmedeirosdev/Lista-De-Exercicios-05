using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeExercícios05.Ex09
{
    internal class MediaHarmonica
    {
        internal double nota1 = 8, nota2 = 7, nota3 = 6, nota4 = 9, mediaH;

        public double CalcularMedia() 
        {
            mediaH = 4 / (1/nota1 + 1/nota2 + 1/nota3 + 1/nota4);
            return Math.Round(mediaH, 2);
        }
    }
}
