namespace listaDeExercicios05.Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LataDeOleo lata = new LataDeOleo();

            Console.WriteLine("O volume da Lata de Óleo é: " + lata.CalcularVolume() );
            Console.ReadLine();
        }
    }
}