using System;
using System.Globalization;

namespace estoque
{
    public class Program
    {
        static void Main(string[] args)
        {
            //escrevendo para o usuario entrar com o valor
            Console.WriteLine("Entre com dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            // chamando a classe produto
            AUTO_PROPERTIES p = new AUTO_PROPERTIES(nome, preco, quantidade);

            
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
    
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            // resultado
            Console.WriteLine("Dados do atualizados: " + p);

            // resultado
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            // resultado
            Console.WriteLine("Dados do atualizados: " + p);

            Console.ReadKey();
        }
    }
}
