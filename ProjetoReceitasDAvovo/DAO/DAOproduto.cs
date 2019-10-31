using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProdutoEntidade;
using System.Threading.Tasks;

namespace ProdutosDAO
{
    class DAOproduto
    {
        private List<Produto> produtos;
        public DAOproduto()
        {
            this.produtos = new List<Produto>()
            {
                new Produto
                {
                    nome = "Tomate",
                    preco = 0.50
                },
                 new Produto
                {
                    nome = "Leite",
                    preco = 0.99
                },
                  new Produto
                {
                    nome = "Farinha",
                    preco = 2.00
                },
                  new Produto
                {
                    nome = "Feijoada",
                    preco = 10
                },
            };
        }
        public List<Produto> Lista()
        {
            return this.produtos;
        }
        public Produto encontrar(string nome)
        {
            return this.produtos.Single(p => p.nome.Equals(nome));
        }


    }
}
