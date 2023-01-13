namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PERFIL\n");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("\nAvatar: ");
            string avatar = Console.ReadLine();

            Console.Write("\nTema (L para CLARO e D para ESCURO): ");
            string tema = Console.ReadLine().ToUpper();

            Perfil perfil = new Perfil(nome, avatar, tema);
        }
    }
}