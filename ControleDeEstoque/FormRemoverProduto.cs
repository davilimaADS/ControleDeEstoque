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
    public partial class FormRemoverProduto : Form
    {
        ConexaoDb conexao = new ConexaoDb();
        public FormRemoverProduto()
        {
            InitializeComponent();
        }

        private void FormRemoverProduto_Load(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void ListarProdutos()
        {
            List<Produtos> produtos = conexao.ListarProdutos();
            dgvProduto.DataSource = produtos;

            dgvProduto.Columns["Id"].HeaderText = "ID";
            dgvProduto.Columns["Nome"].HeaderText = "Nome do Produto";
            dgvProduto.Columns["Quantidade"].HeaderText = "Quantidade";
            dgvProduto.Columns["Preco"].HeaderText = "Preço";
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            
            if (dgvProduto.SelectedRows.Count > 0)
            {
                int idProduto = Convert.ToInt32(dgvProduto.SelectedRows[0].Cells["Id"].Value);

                
                var confirmar = MessageBox.Show("Deseja realmente remover este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar == DialogResult.Yes)
                {
                  
                    conexao.ExcluirProdutos(idProduto);

                    ListarProdutos();

                    MessageBox.Show("Produto removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
       
    
}
