using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace estoque
{
    public class Produto
    {
        // declarando variaveis
        public string Nome;
        public double Preco;
        public int Quantidade;

        //construindo as variaveis
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // construindo o valor do estoque
        public double ValorEstoque()
        { 
            return Preco * Quantidade;
        }

        // construindo a adição de produtos
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        // construindo a remoção de produtos
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        // construtor
        public override string ToString()
        {
            return Nome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: R$ " + ValorEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
