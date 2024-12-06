using ControleDeEstoque.Data;
using ControleDeEstoque.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque
{
    public partial class FormListarProduto : Form
    {
        ConexaoDb conexao = new ConexaoDb();
        public FormListarProduto()
        {
            InitializeComponent();
        }

        private void FormListarProduto_Load(object sender, EventArgs e)
        {
            ListarProdutos();
        }
        private void ListarProdutos()
        {
            List<Produtos> produtos = conexao.ListarProdutos();
            dgvProdutos.DataSource = produtos;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
