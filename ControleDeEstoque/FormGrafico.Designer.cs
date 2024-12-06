namespace ControleDeEstoque
{
    partial class FormGrafico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartProdutos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProdutos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProdutos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProdutos.Legends.Add(legend1);
            this.chartProdutos.Location = new System.Drawing.Point(116, 55);
            this.chartProdutos.Name = "chartProdutos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProdutos.Series.Add(series1);
            this.chartProdutos.Size = new System.Drawing.Size(553, 351);
            this.chartProdutos.TabIndex = 0;
            this.chartProdutos.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartProdutos);
            this.Name = "FormGrafico";
            this.Text = "FormGráfico";
            this.Load += new System.EventHandler(this.FormGrafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdutos;
        private System.Windows.Forms.Button button1;
    }
}