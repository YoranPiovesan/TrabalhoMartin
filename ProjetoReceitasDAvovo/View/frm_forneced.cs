using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoReceitasDAvovo.View;
using Ent_PessoaFornecedor;

namespace ProjetoReceitasDAvovo.View
{
    public partial class frm_forneced : Form
    {
        public frm_forneced()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_forneced_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_fornecedores f = new frm_fornecedores();
            f.Show();
        }

        private void frm_forneced_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            frm_menu men = new frm_menu();
            men.Show();
        }

        private void Titu_Click(object sender, EventArgs e)
        {
            //PUXAR NOME DA EMPRESA
            PessoaFornecedor EmpresaCadastrada = new PessoaFornecedor();
            Titu.Text = EmpresaCadastrada._NomeEmpresa;
            Ender.Text = "ENDEREÇO: " + EmpresaCadastrada._EnderecoEmpresa;
            Bairr.Text = "BAIRRO: " + EmpresaCadastrada._BairroEmpresa;
            Estad.Text = "ESTADO: " + EmpresaCadastrada._EstadoEmpresa;
            Cep.Text = "CEP: " + EmpresaCadastrada._CepEmpresa;
        }

        private void Ender_Click(object sender, EventArgs e)
        {

        }
    }
}
