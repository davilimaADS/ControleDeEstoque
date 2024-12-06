using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using ControleDeEstoque.Models;

namespace ControleDeEstoque.Data
{
    internal class ConexaoDb
    {
        private string _conexao = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;

        public void AddProdutos(Produtos produtos)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conexao))
                {
                    var query = "INSERT INTO Produtos (Nome, Quantidade, Preco) VALUES (@Nome, @Quantidade, @Preco)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nome", produtos.Nome);
                    cmd.Parameters.AddWithValue("@Quantidade", produtos.Quantidade);
                    cmd.Parameters.AddWithValue("@Preco", produtos.Preco);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar produto: " + ex.Message);
            }
        }

        public List<Produtos> ListarProdutos()
        {
            try
            {
                List<Produtos> produtos = new List<Produtos>();
                using (SqlConnection conn = new SqlConnection(_conexao))
                {
                    var query = "SELECT * FROM Produtos";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        produtos.Add(new Produtos
                        {
                            Id = (int)reader["Id"],
                            Nome = reader["Nome"].ToString(),
                            Quantidade = (int)reader["Quantidade"],
                            Preco = (decimal)reader["Preco"]
                        });
                    }
                    return produtos;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar produtos: " + ex.Message);
            }
        }

        public void AtualizarProdutos(Produtos produtos)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conexao))
                {
                    var query = "UPDATE Produtos SET Nome = @Nome, Quantidade = @Quantidade, Preco = @Preco WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", produtos.Id);
                    cmd.Parameters.AddWithValue("@Nome", produtos.Nome);
                    cmd.Parameters.AddWithValue("@Quantidade", produtos.Quantidade);
                    cmd.Parameters.AddWithValue("@Preco", produtos.Preco);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar produto: " + ex.Message);
            }
        }

        public void ExcluirProdutos(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conexao))
                {
                    var query = "DELETE FROM Produtos WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir produto: " + ex.Message);
            }
        }

        public List<(string Nome, int Quantidade)> ObterDadosEstoque()
        {
            try
            {
                List<(string Nome, int Quantidade)> estoque = new List<(string Nome, int Quantidade)>();
                using (SqlConnection conn = new SqlConnection(_conexao))
                {
                    var query = "SELECT Nome, Quantidade FROM Produtos";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        estoque.Add((reader["Nome"].ToString(), (int)reader["Quantidade"]));
                    }
                    return estoque;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter dados do estoque: " + ex.Message);
            }
        }
    }
}
