using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent_Pessoa;
using Ent_PessoaFornecedor;

namespace ProjetoReceitasDAvovo
{
    class ListStatic
    {
        public static List<Pessoa> StaticCadastradas = new List<Pessoa>();
        public static List<PessoaFornecedor> StaticFornecedores = new List<PessoaFornecedor>();

        public void inserir(Pessoa pessoa)
        {
            StaticCadastradas.Add(pessoa);
        }

        public void inserirFornecedor(PessoaFornecedor pessoaFornecedor)
        {
            StaticFornecedores.Add(pessoaFornecedor);
        }
    }
}
