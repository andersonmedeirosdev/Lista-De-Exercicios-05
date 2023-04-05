using System.Net.Http.Headers;

namespace listaDeExercicios05.Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro medida = new Cilindro();

            medida.raio = 10;
            medida.altura = 80;
            Console.Write("O volume do cilindro é: " + medida.CalcularVolume() );
        }
    }
}