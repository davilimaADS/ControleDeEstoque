using ControleDeEstoque.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ControleDeEstoque
{
    public partial class FormGrafico : Form
    {
        ConexaoDb conexao = new ConexaoDb();

        public FormGrafico()
        {
            InitializeComponent();
        }

        private void FormGrafico_Load(object sender, EventArgs e)
        {
            CarregarGrafico();
        }

        private void CarregarGrafico()
        {
            chartProdutos.Series.Clear();

            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Estoque",
                IsValueShownAsLabel = true,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
            };
          
            chartProdutos.Series.Add(series);
            List<(string Nome, int Quantidade)> dados = conexao.ObterDadosEstoque();

            foreach (var (Nome, Quantidade) in dados)
            {
                series.Points.AddXY(Nome, Quantidade);
            }
            chartProdutos.Titles.Clear();
            chartProdutos.Titles.Add("Estoque");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
