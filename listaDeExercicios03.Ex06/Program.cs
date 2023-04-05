namespace listaDeExercicios05.Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura celsius = new Temperatura();

            Console.WriteLine("A temperatura em Fahrenheit é: " + celsius.CalcularTemperaturaF() );
        }
    }
}