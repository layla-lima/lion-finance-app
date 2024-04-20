using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace lion_finance_app
{
    public partial class TelaRelatorio : Form
    {
        public TelaRelatorio()
        {
            InitializeComponent();

            // Buscar e exibir informações do banco de dados
            ExibirInformacoesDoBancoDeDados();
            ExibirTop5Despesas();
            ExibirTop5Entradas();
        }

        private void ExibirInformacoesDoBancoDeDados()
        {
            try
            {
                string stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Layla\Documents\lion-finance-app\lion-finance-app\lion-finance-app\LionFinance.mdb";
                using (OleDbConnection conn = new OleDbConnection(stringcon))
                {
                    conn.Open();

                    // Consulta SQL para obter as informações desejadas do banco de dados
                    string SQL = "SELECT aluguel_mensal, lazer, transporte, parcelamentos FROM Financias";
                    using (OleDbCommand cmd = new OleDbCommand(SQL, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            // Verificar se há resultados
                            if (reader.Read())
                            {
                                // Extrair os valores do banco de dados
                                double aluguel = Convert.ToDouble(reader["aluguel_mensal"]);
                                double lazer = Convert.ToDouble(reader["lazer"]);
                                double transporte = Convert.ToDouble(reader["transporte"]);
                                double parcelas = Convert.ToDouble(reader["parcelamentos"]);

                                // Exibir os valores em labels
                                lblAluguel.Text = $"Aluguel: R$ {aluguel:F2}";
                                lblLazer.Text = $"Lazer: R$ {lazer:F2}";
                                lblTransporte.Text = $"Transporte: R$ {transporte:F2}";
                                lblParcelas.Text = $"Parcelas: R$ {parcelas:F2}";
                            }
                            else
                            {
                                MessageBox.Show("Nenhuma informação encontrada no banco de dados.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
            }
        }

        private void ExibirTop5Despesas()
        {
            // Criar o modelo de plotagem
            var plotModel = new PlotModel { Title = "Top 5 Despesas", TitleColor = OxyColors.White, TextColor = OxyColors.White };

            // Definindo as cores para o gráfico de pizza
            var coresPizza = new List<OxyColor>
            {
                OxyColor.FromRgb(201, 160, 80),
                OxyColor.FromRgb(161, 130, 67),
                OxyColor.FromRgb(142, 115, 61),
                OxyColor.FromRgb(122, 100, 54),
                OxyColor.FromRgb(112, 92, 51)
            };

            // Adicionando série de pizza com cores personalizadas
            var series = new PieSeries
            {
                StrokeThickness = 2.0,
                AngleSpan = 360,
                StartAngle = 0,
                InnerDiameter = 0.6, // Define o tamanho do buraco no meio (valor entre 0 e 1)
            };

            // Adicionando dados à série com cores personalizadas
            for (int i = 0; i < coresPizza.Count; i++)
            {
                series.Slices.Add(new PieSlice($"Categoria {i + 1}", 20) { Fill = coresPizza[i] });
            }

            // Adicionando a série ao modelo de plotagem
            plotModel.Series.Add(series);

            // Criando e configurando o PlotView
            var plotView = new PlotView
            {
                Model = plotModel,
                Width = 300, // Define a largura do controle
                Height = 300, // Define a altura do controle
            };

            // Definindo a localização do canto superior direito do controle
            plotView.Location = new Point(this.ClientSize.Width - plotView.Width - 20, 20);

            // Adicionando o PlotView ao formulário
            Controls.Add(plotView);
        }

        private void ExibirTop5Entradas()
        {
            // Crie o modelo do gráfico
            var plotModel = new PlotModel { Title = "Top 5 Entradas", TitleColor = OxyColors.White, TextColor = OxyColors.White };

            // Defina o eixo de categoria (eixo X)
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.None,
                TicklineColor = OxyColors.White,
                TextColor = OxyColors.White // Cor do texto
            };
            plotModel.Axes.Add(categoryAxis);

            // Defina o eixo de valor (eixo Y)
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.None,
                TicklineColor = OxyColors.White,
                TextColor = OxyColors.White // Cor do texto
            };
            plotModel.Axes.Add(valueAxis);

            // Adicione os dados das colunas
            var columnData = new List<ColumnData>
            {
                new ColumnData { Category = "Categoria 1", Value = 10 },
                new ColumnData { Category = "Categoria 2", Value = 20 },
                new ColumnData { Category = "Categoria 3", Value = 15 },
                new ColumnData { Category = "Categoria 4", Value = 25 }
            };

            // Espaço entre as colunas
            double espacoEntreColunas = 0.2;

            // Adicione as barras manualmente
            for (int i = 0; i < columnData.Count; i++)
            {
                var series = new RectangleBarSeries
                {
                    Items = { new RectangleBarItem(i + espacoEntreColunas / 2, 0, i + 1 - espacoEntreColunas / 2, columnData[i].Value) },
                    FillColor = OxyColor.FromRgb(201, 160, 80) // Cor da coluna
                };
                plotModel.Series.Add(series);
                categoryAxis.Labels.Add(columnData[i].Category);
            }

            // Defina a cor das linhas do gráfico para branco
            plotModel.DefaultColors = new List<OxyColor> { OxyColors.White };

            // Crie o visualizador do OxyPlot
            var plotView = new OxyPlot.WindowsForms.PlotView
            {
                Model = plotModel,
                Width = 400,
                Height = 300,
                Location = new System.Drawing.Point(10, 10) // Posicione o gráfico à esquerda do formulário
            };

            // Adicione o visualizador ao formulário
            Controls.Add(plotView);

        }

        // Classe para representar os dados das colunas
        private class ColumnData
        {
            public string Category { get; set; }
            public double Value { get; set; }
        }
    }
}
