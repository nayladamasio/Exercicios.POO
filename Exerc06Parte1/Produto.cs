using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc06Parte1
{
    internal class Produto
    {
        public string Nomeproduto { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

        public Produto(string nomeproduto, double preco, int quantidadeestoque)
        {
            Nomeproduto = nomeproduto;
            Preco = preco;
            QuantidadeEstoque = quantidadeestoque;
        }

        public double ValorTotalEstoque()
        {
            return Preco * QuantidadeEstoque;
        }

        public bool Disponivel()
        {
            return QuantidadeEstoque > 0;
        }
    }
}
