using System.Reflection;

namespace ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CARRO\n");
            Carro carro = new Carro();

            Console.WriteLine("\nABASTECER");
            carro.Abastecer();
        }
    }
}