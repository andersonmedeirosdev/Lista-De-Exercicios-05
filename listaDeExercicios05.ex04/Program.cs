namespace listaDeExercicios05.ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Consumo veiculo = new Consumo();

            Console.Write("O consumo por Km é: " + veiculo.CalcularConsumo() );
            Console.ReadLine();
        }
    }
}