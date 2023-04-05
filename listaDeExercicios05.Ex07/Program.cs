namespace listaDeExercicios05.Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario vendedor = new Salario();

            Console.Write("O salário total do vendedor é: " + vendedor.CalcularSalario() );
            Console.ReadLine();
        }
    }
}