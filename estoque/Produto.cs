using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Diagnostics;

namespace estoque
{
    public class produto
    {
        //criando variaveis que definem o produto
        private string _nome;
        private double _preco;
        private int _quantidade;

        //criando o construtor
        public produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //instanciando o construtor
        public produto()
        {

        }

        public string Nome
        {
            //Pegando o conteudo da variavel _nome
            get { return _nome; }
            //Setando o conteudo da variavel value na variavel _nome depois da validação
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            //Pegando o conteudo de _preco
            get { return _preco; }
        }

        public int Quantidade
        {
            //Pegando o conteudo de _quantidade
            get { return _quantidade; }
        }

        //Criando uma função para calcular o valor total do estoque
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        //Criando uma função para colocar mais Produtos ao estoque
        public void AdicionarProduto(int qtd)
        {
            _quantidade += qtd;
        }

        //Criando uma função para fazer a retirada de produtos do estoque
        public void RemoverProdutos(int qtd)
        {
            _quantidade = _quantidade - qtd;
        }

        //Criando um formato para o ToString
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
