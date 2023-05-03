using System.Globalization;
using System;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do Porduto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();            
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quanttidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {p}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine($"Dados do produto atualizados: {p}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine($"Dados do produto atualizados: {p}");
        }
    }
}