namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CNH\n");
            Console.WriteLine("Lista de siglas: \nBR - Brasil \nUS - Estados Unidos \nCA - Canada \nCH - China \nRU - Russia \n");

            Console.Write("Digite a sigla desejada de acordo com a tabela acima (para paises não listados digite o nome do pais): ");
            string pais = Console.ReadLine().ToUpper();

            CNH cnh = new CNH(pais);
            Console.WriteLine($"\nPara a CNH no(a) {pais} é necessario ter no minimo {cnh.Idade} anos.\n");

            cnh.ValidarBrasil(pais);
        }
    }
}