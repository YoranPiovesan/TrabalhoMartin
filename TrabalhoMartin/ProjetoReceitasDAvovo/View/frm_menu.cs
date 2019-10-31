using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoReceitasDAvovo.View
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_forneced janelafornecedorprincipal = new frm_forneced();
            janelafornecedorprincipal.Show();
            this.Hide();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
