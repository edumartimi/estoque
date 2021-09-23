using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace estoque
{
    public class produto
    {
        //Criando as variaveis do produto
        private string _nome;
        //criando a variavel,ler e tornar a variavel private para seguraça
        public double _preco { get; private set; }
        public int _quantidade { get; private set; }

        //criando o construtor
        public produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Construindo um produto
        public produto()
        {

        }

        public string Nome
        {
            //pegando o conteudo da variante _nome
            get { return _nome; }
            //setando o conteudo de value em _nome depois da validação
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //criando uma função para calcular o valor total do estoque
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        //criando uma função para adicionar Produtos ao estoque
        public void AdicionarProduto(int qtd)
        {
            _quantidade += qtd;
        }

        //criando uma função para remover produtos do estoque
        public void RemoverProdutos(int qtd)
        {
            _quantidade = _quantidade - qtd;
        }

        //fazendo ela ficar em um formato para o ToString
        public override string ToString()
        {
            return _nome
            + ",R$"
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ","
            + _quantidade
            + " unidades,Total: R$"
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
