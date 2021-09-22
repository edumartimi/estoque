using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace estoque
{
    class AUTO_PROPERTIES
    {
        //Declaração das variaveis do produto
        private string _nome;
        //Declaração de variavel,ler e tornar a variavel private para seguraça
        public double _preco { get; private set; }
        public int _quantidade { get; private set; }

        //Declaração do construtor
        public AUTO_PROPERTIES(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //contrutor padrao
        public AUTO_PROPERTIES()
        {

        }

        public string Nome
        {
            //lendo o conteudo da variante _nome
            get { return _nome; }
            //gravando o conteudo de value em _nome depois da validação
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //Função para calcular o valor total do estoque
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        //Função para adicionar Produtos ao estoque
        public void AdicionarProduto(int qtd)
        {
            _quantidade += qtd;
        }

        //Função para remover produtos do estoque
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
