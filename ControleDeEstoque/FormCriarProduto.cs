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
    public partial class FormCriarProduto : Form
    {
        ConexaoDb conexao = new ConexaoDb();

        public FormCriarProduto()
        {
            InitializeComponent();
        }

        private void FormCriarProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos
            {
                Nome = txtNome.Text,
                Preco = decimal.Parse(txtPreco.Text),
                Quantidade = int.Parse(txtQuantidade.Text)
            };
            conexao.AddProdutos(produtos);
            MessageBox.Show("Produto Cadastrado!");
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
