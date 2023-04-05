namespace listaDeExercicios05.Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit temperatura = new Fahrenheit();

            temperatura.fahrenheit = 110;

            Console.Write("A temperatura em Farenheit é: " + temperatura.CalcularCelsius() );
        }
    }
}