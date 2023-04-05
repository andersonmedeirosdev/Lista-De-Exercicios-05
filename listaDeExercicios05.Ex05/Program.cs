namespace listaDeExercicios05.Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera atributoEsfera = new Esfera();

            Console.WriteLine("O volume da esfera é: " + atributoEsfera.CalcularVolume() );
            Console.ReadLine();
        }
    }
}