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
    public partial class FormEditarProduto : Form
    {
        ConexaoDb conexao = new ConexaoDb();
        public FormEditarProduto()
        {
            InitializeComponent();
        }

        private void FormEditarProduto_Load(object sender, EventArgs e)
        {
            ListarProdutos();
        }
        private void ListarProdutos()
        {
            List<Produtos> produtos = conexao.ListarProdutos();
            dgvProdutos.DataSource = produtos;

            dgvProdutos.Columns["Id"].HeaderText = "ID";
            dgvProdutos.Columns["Nome"].HeaderText = "Nome do Produto";
            dgvProdutos.Columns["Quantidade"].HeaderText = "Quantidade";
            dgvProdutos.Columns["Preco"].HeaderText = "Preço";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                try
                {
                    // Obter os valores editados no formulário
                    int idProduto = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["Id"].Value);
                    string nome = txtNome.Text;
                    int quantidade = int.Parse(txtQuantidade.Text);
                    decimal preco = decimal.Parse(txtPreco.Text);

                    // Criar objeto produto atualizado
                    Produtos produtoAtualizado = new Produtos
                    {
                        Id = idProduto,
                        Nome = nome,
                        Quantidade = quantidade,
                        Preco = preco
                    };

                    // Atualizar no banco de dados
                    conexao.AtualizarProdutos(produtoAtualizado);

                    // Atualizar DataGridView
                    ListarProdutos();

                    MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Preencher os campos do formulário com os dados da linha selecionada
                DataGridViewRow row = dgvProdutos.Rows[e.RowIndex];
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtQuantidade.Text = row.Cells["Quantidade"].Value.ToString();
                txtPreco.Text = row.Cells["Preco"].Value.ToString();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
