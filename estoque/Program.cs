using System;
using System.Globalization;

namespace estoque
{
    public class Program
    {
        static void Main(string[] args)
        {
            //escrevendo na tela para o usuario entrar com os valores
            Console.WriteLine("Entre com dados do produto: ");
            Console.Write("Nome: ");

            //pegando o que o usuario digita e colocando dentro da variavel nome
            string nome = Console.ReadLine();

            Console.Write("Preço: ");

            //pegando o que o usuario digita e colocando na variavel preco
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");

            //pegando o que o usuario digita e colocando na variavel quantidade
            int quantidade = int.Parse(Console.ReadLine());

            //chamando a classe produto
            produto p = new produto(nome, preco, quantidade);

            //passando as informações para o usuario
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");

            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            // resultado 1
            Console.WriteLine("Dados do atualizados: " + p);

            // resultado
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            // resultado final
            Console.WriteLine("Dados do atualizados: " + p);

            Console.ReadKey();
        }
    }
}
