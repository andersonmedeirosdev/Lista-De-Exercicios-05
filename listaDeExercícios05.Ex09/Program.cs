namespace listaDeExercícios05.Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaHarmonica media = new MediaHarmonica();

            Console.WriteLine("A média harmônica é: " + media.CalcularMedia() );
            Console.ReadLine();
        }
    }
}