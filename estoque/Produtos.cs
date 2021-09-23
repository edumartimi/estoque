using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace estoque
{
    public class produto
    {
        //Declarando as variaveis do produto
        private string _nome;
        private double _preco;
        private int _quantidade;

        //Declarando as variaveis do construtor
        public produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Construindo o produto
        public produto()
        {

        }

        //Criando uma função para pegar a variavel _nome
        public string GetNome()
        {
            return _nome;
        }

        //Criando uma função para setar o coteudo de nome na variavel _nome
        public void SetNome(string nome)
        {
            _nome = nome;
        }

        //Criando uma função para pegar a variavel _preco
        public double GetPreco()
        {
            return _preco;
        }

        //Criando uma função para pegar a variavel _quantidade
        public int GetQuantidade()
        {
            return _quantidade;
        }

        //criando uma função para calcular o valor do estoque
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
