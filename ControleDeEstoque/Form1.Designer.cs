namespace ControleDeEstoque
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.removerProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Gráfico = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarProduto,
            this.listarProdutos,
            this.removerProdutosToolStripMenuItem,
            this.editarProdutosToolStripMenuItem});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // criarProduto
            // 
            this.criarProduto.Name = "criarProduto";
            this.criarProduto.Size = new System.Drawing.Size(172, 22);
            this.criarProduto.Text = "Criar Produto";
            this.criarProduto.Click += new System.EventHandler(this.criarProduto_Click);
            // 
            // listarProdutos
            // 
            this.listarProdutos.Name = "listarProdutos";
            this.listarProdutos.Size = new System.Drawing.Size(172, 22);
            this.listarProdutos.Text = "Listar Produtos";
            this.listarProdutos.Click += new System.EventHandler(this.listarProdutos_Click);
            // 
            // removerProdutosToolStripMenuItem
            // 
            this.removerProdutosToolStripMenuItem.Name = "removerProdutosToolStripMenuItem";
            this.removerProdutosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.removerProdutosToolStripMenuItem.Text = "Remover Produtos";
            this.removerProdutosToolStripMenuItem.Click += new System.EventHandler(this.removerProdutosToolStripMenuItem_Click);
            // 
            // editarProdutosToolStripMenuItem
            // 
            this.editarProdutosToolStripMenuItem.Name = "editarProdutosToolStripMenuItem";
            this.editarProdutosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.editarProdutosToolStripMenuItem.Text = "Editar Produtos";
            this.editarProdutosToolStripMenuItem.Click += new System.EventHandler(this.editarProdutosToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Gráfico});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // Gráfico
            // 
            this.Gráfico.Name = "Gráfico";
            this.Gráfico.Size = new System.Drawing.Size(112, 22);
            this.Gráfico.Text = "Gráfico";
            this.Gráfico.Click += new System.EventHandler(this.Gráfico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarProduto;
        private System.Windows.Forms.ToolStripMenuItem listarProdutos;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Gráfico;
        private System.Windows.Forms.ToolStripMenuItem editarProdutosToolStripMenuItem;
    }
}

