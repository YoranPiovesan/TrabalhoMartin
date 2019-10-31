using Ent_Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ent_PessoaFornecedor;
using ProjetoReceitasDAvovo;
using ProjetoReceitasDAvovo.View;
using Ent_Cupons;
using System.Windows.Forms;
using ProdutoEntidade;

namespace Dao
{
    class DAOpessoa
    {
       List<Pessoa> cadastradas = new List<Pessoa>();
       // List<PessoaFornecedor> fornecedorescadastro = new List<PessoaFornecedor>();


        public void inserir(Pessoa pessoa)
        {
            ListStatic.StaticCadastradas.Add(pessoa);
        }

        public void inserirFornecedor(PessoaFornecedor pessoafornecedores)
        {
            ListStatic.StaticFornecedores.Add(pessoafornecedores);
        }

        //public void listarFornecedor(PessoaFornecedor pessoafornecedores) //**************VERIFICAR FORNECEDOR***************//
        //{
        //    foreach(PessoaFornecedor fornece in fornecedorescadastro)
        //    {
                
        //       string i = fornece._EnderecoEmpresa;
        //    }
        //}

        public Boolean fazerLogin(string login, string senha)
        {
            int contCadastradas = ListStatic.StaticCadastradas.Count();
            if (contCadastradas == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //public double cuponsDesconto(double valortotal, PessoaCupons cupons)
        //{
        //    double resultado = (valortotal / 100) * Convert.ToDouble(cupons);
        //    return resultado;
        //}
        public List<Pessoa> getAllListaCadastro()
        {
            return cadastradas;
        }
  
    }
}
