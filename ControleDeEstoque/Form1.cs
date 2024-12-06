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
    public partial class Form1 : Form
    {
        ConexaoDb conxao = new ConexaoDb();
        public Form1()
        {
            InitializeComponent();
        }

        private void criarProduto_Click(object sender, EventArgs e)
        {
           FormCriarProduto formCriarProduto = new FormCriarProduto();
            formCriarProduto.ShowDialog();
        }

        private void listarProdutos_Click(object sender, EventArgs e)
        {
            FormListarProduto formListarProdutos = new FormListarProduto();
            formListarProdutos.ShowDialog();
        }

        private void removerProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRemoverProduto formRemoverProduto = new FormRemoverProduto();
            formRemoverProduto.ShowDialog();
        }

        private void editarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditarProduto formEditarProduto = new FormEditarProduto();
            formEditarProduto.ShowDialog();
        }

        private void Gráfico_Click(object sender, EventArgs e)
        {
            FormGrafico formGrafico = new FormGrafico();
            formGrafico.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
