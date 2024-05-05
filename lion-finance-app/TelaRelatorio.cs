using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static lion_finance_app.TelaRelatorio;

namespace lion_finance_app
{
    public partial class TelaRelatorio : Form
    {

        private string nomeUsuario;

        public TelaRelatorio(string nomeUsuario)
        {
            InitializeComponent();

            this.nomeUsuario = nomeUsuario;

            // Retorna objeto com os dados financeiros do cliente por consulta sql
            DadosFinanceirosEntity dadosFinanceirosEntity = retornaDadosFinanceirosCliente();

            if(dadosFinanceirosEntity != null) {

                // Exibir informações do banco de dados
                ExibirInformacoesDoBancoDeDados(dadosFinanceirosEntity);

                // Exibir top 5 maiores despesas
                ExibirTop5Despesas(dadosFinanceirosEntity);

                // Exibir porcentual das duas entradas
                ExibirPorcentualEntradas(dadosFinanceirosEntity);

                // Exibir total das entradas e saídas
                totalEntradasSaidas(dadosFinanceirosEntity);

                // Exibir valor líquido
                ExibirValorLiquido(dadosFinanceirosEntity);
            }

            this.Hide();
        }

        // Método para retornar os dados financeiros do cliente do banco de dados
        private DadosFinanceirosEntity retornaDadosFinanceirosCliente()
        {
            // Abri instancia para a classe de acessoDB
            AcessoDB acessoDB = new AcessoDB();
            return acessoDB.AcessoFinancias(nomeUsuario);
        }

        // Método para calcular o valor líquido
        private double CalcularValorLiquido(DadosFinanceirosEntity dados)
        {
            // Calcula o total das entradas
            double totalEntradas = dados.RendaFixa + dados.RendaVariavel;

            // Calcula o total das despesas
            double totalDespesas = dados.Despesas.Aluguel +
                                    dados.Despesas.Parcelamento +
                                    dados.Despesas.Lazer +
                                    dados.Despesas.Compras +
                                    dados.Despesas.Contas +
                                    dados.Despesas.Financiamento +
                                    dados.Despesas.Transporte;

            // Calcula o valor líquido
            double valorLiquido = totalEntradas - totalDespesas;

            return valorLiquido;
        }

        // Método para exibir o valor líquido
        private void ExibirValorLiquido(DadosFinanceirosEntity dados)
        {
            double valorLiquido = CalcularValorLiquido(dados);
            lblLiquidado.Text = $"Valor líquido: R$ {valorLiquido:F2}";
        }


        private void ExibirInformacoesDoBancoDeDados(DadosFinanceirosEntity entity)
        {

            // Exibir os valores em labels
            lblAluguel.Text = $"Aluguel: R$ {entity.Despesas.Aluguel:F2}";
            lblLazer.Text = $"Lazer: R$ {entity.Despesas.Lazer:F2}";
            lblTransporte.Text = $"Transporte: R$ {entity.Despesas.Transporte:F2}";
            lblParcelas.Text = $"Parcelas: R$ {entity.Despesas.Parcelamento:F2}";

        }

        private void ExibirTop5Despesas(DadosFinanceirosEntity dadosFinanceirosEntity)
{
    // Criar o modelo de plotagem
    var plotModel = new PlotModel { Title = "Top 5 Despesas", TitleColor = OxyColors.White, TextColor = OxyColors.White };

    // Ajustar o padding do título para afastá-lo um pouco do gráfico
    plotModel.TitlePadding = 20; 
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

    var maioresDespesas = ObterMaioresDespesas(dadosFinanceirosEntity);

    // Adicionando dados à série com cores personalizadas
    foreach (var (categoria, valor) in maioresDespesas)
    {
        series.Slices.Add(new PieSlice(categoria, valor) { Fill = coresPizza[series.Slices.Count % coresPizza.Count] });
    }

    // Adicionando a série ao modelo de plotagem
    plotModel.Series.Add(series);

    // Criando e configurando o PlotView
    var plotView = new PlotView
    {
        Model = plotModel,
        Width = 500, // Define a largura do controle
        Height = 350, // Define a altura do controle
    };

    // Definindo a localização do canto superior direito do controle
    plotView.Location = new Point(this.ClientSize.Width - plotView.Width - 20, 20);

    // Adicionando o PlotView ao formulário
    Controls.Add(plotView);
}


        // Método para retornar as 5 maiores despesas
        public Dictionary<string, double> ObterMaioresDespesas(DadosFinanceirosEntity dados)
        {
            var despesas = new Dictionary<string, double>
            {
                { "Financiamento", dados.Despesas.Financiamento },
                { "Contas", dados.Despesas.Contas },
                { "Parcelamento", dados.Despesas.Parcelamento },
                { "Aluguel", dados.Despesas.Aluguel },
                { "Compras", dados.Despesas.Compras },
                { "Lazer", dados.Despesas.Lazer },
                { "Transporte", dados.Despesas.Transporte }
            };

            // Ordena as despesas por valor em ordem decrescente
            var despesasOrdenadas = despesas.OrderByDescending(pair => pair.Value);

            // Seleciona os 5 primeiros elementos
            var maioresDespesas = despesasOrdenadas.Take(5);

            // Converte os 5 primeiros elementos de volta em um dicionário
            return maioresDespesas.ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        private void ExibirPorcentualEntradas(DadosFinanceirosEntity dados)
        {
            // Crie o modelo do gráfico
            var plotModel = new PlotModel { Title = "Porcentual Entradas", TitleColor = OxyColors.White, TextColor = OxyColors.White };
            plotModel.TitlePadding = 20; // Ajuste este valor conforme necessário para a distância desejada

            // Criar a série de pizza
            var series = new PieSeries
            {
                // Adicionar os dados da série
                Slices =
        {
            // Adicionar a fatia para a renda fixa
            new PieSlice("Renda Fixa", dados.RendaFixa)
            {
                // Definir a cor da fatia
                Fill = OxyColor.FromRgb(201, 160, 80)
            },
            // Adicionar a fatia para a renda variável
            new PieSlice("Renda Variável", dados.RendaVariavel)
            {
                // Definir a cor da fatia
                Fill = OxyColor.FromRgb(161, 130, 67)
            }
        },
                // Definir a espessura do traçado
                StrokeThickness = 2.0,
                // Definir o ângulo de partida
                StartAngle = 0,
                // Definir o ângulo de extensão
                AngleSpan = 360
            };

            // Adicionar a série ao modelo do gráfico
            plotModel.Series.Add(series);

            // Criar o visualizador do OxyPlot
            var plotView = new PlotView
            {
                Model = plotModel,
                Width = 400,
                Height = 300,
                Location = new System.Drawing.Point(10, 20) // Posicionar o gráfico no formulário
            };
            plotView.Left = 30; // mover gráfico pra direita em 30 pixels 

            // Adicionar o visualizador ao formulário
            Controls.Add(plotView);
        }


        // Classe para representar os dados das colunas
        private class ColumnData
        {
            public string Category { get; set; }
            public double Value { get; set; }
        }

        private void totalEntradasSaidas(DadosFinanceirosEntity dados)
        {
            // Criando os dois painéis
            Panel panel1 = new Panel();
            Panel panel2 = new Panel();

            // Definindo um tom de dourado mais suave para Entradas
            System.Drawing.Color douradoSuaveEntradas = System.Drawing.Color.FromArgb(201, 160, 80);
            // Definindo um tom mais escuro para Despesas
            System.Drawing.Color marromEscuroDespesas = System.Drawing.Color.FromArgb(161, 130, 67);

            // Definindo propriedades dos painéis
            panel1.BackColor = douradoSuaveEntradas; // Cor para Entradas
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Size = new System.Drawing.Size(180, 120); // Reduzindo o tamanho do primeiro painel
            panel1.Location = new System.Drawing.Point(50, this.ClientSize.Height - panel1.Height - 100); // Ajustando a posição do primeiro painel

            panel2.BackColor = marromEscuroDespesas; // Cor para Despesas
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Size = new System.Drawing.Size(180, 120); // Reduzindo o tamanho do segundo painel
            panel2.Location = new System.Drawing.Point(panel1.Right + 30, this.ClientSize.Height - panel2.Height - 100); // Ajustando a posição do segundo painel

            // Adicionando títulos aos painéis
            Label label1 = new Label();
            label1.Text = "Entradas";
            label1.Location = new System.Drawing.Point(panel1.Left + 10, panel1.Top - 30); // Ajustando a posição do título do primeiro painel
            label1.BackColor = Color.Transparent; // Removendo o fundo do título
            label1.ForeColor = Color.White; // Definindo a cor do texto como branco
            label1.Font = new Font(label1.Font, FontStyle.Bold); // Definindo o estilo da fonte como negrito
            label1.AutoSize = true; // Permitindo que o tamanho do título seja ajustado automaticamente

            Label label2 = new Label();
            label2.Text = "Despesas";
            label2.Location = new System.Drawing.Point(panel2.Left + 10, panel2.Top - 30); // Ajustando a posição do título do segundo painel
            label2.BackColor = Color.Transparent; // Removendo o fundo do título
            label2.ForeColor = Color.White; // Definindo a cor do texto como branco
            label2.Font = new Font(label2.Font, FontStyle.Bold); // Definindo o estilo da fonte como negrito
            label2.AutoSize = true; // Permitindo que o tamanho do título seja ajustado automaticamente

            double entradas = dados.RendaVariavel + dados.RendaFixa;
            double despesas = dados.Despesas.Aluguel
                + dados.Despesas.Parcelamento
                + dados.Despesas.Lazer
                + dados.Despesas.Compras
                + dados.Despesas.Contas
                + dados.Despesas.Financiamento
                + dados.Despesas.Transporte;

            // Adicionando um valor dentro do primeiro painel
            Label labelValorPanel1 = new Label();
            labelValorPanel1.Text = "R$ " + entradas;
            labelValorPanel1.Location = new System.Drawing.Point(0, 0); // Posição do valor dentro do painel
            labelValorPanel1.ForeColor = Color.White; // Definindo a cor do texto como branco
            labelValorPanel1.Font = new Font(label2.Font, FontStyle.Bold); // Definindo o estilo da fonte como negrito
            labelValorPanel1.TextAlign = ContentAlignment.MiddleCenter; // Alinhando o texto ao centro
            labelValorPanel1.Size = panel1.Size; // Definindo o tamanho do label igual ao tamanho do painel
            panel1.Controls.Add(labelValorPanel1); // Adicionando o controle de texto ao painel

            // Adicionando um valor dentro do segundo painel
            Label labelValorPanel2 = new Label();
            labelValorPanel2.Text = "R$ " + despesas;
            labelValorPanel2.Location = new System.Drawing.Point(0, 0); // Posição do valor dentro do painel
            labelValorPanel2.ForeColor = Color.White; // Definindo a cor do texto como branco
            labelValorPanel2.Font = new Font(label2.Font, FontStyle.Bold); // Definindo o estilo da fonte como negrito
            labelValorPanel2.TextAlign = ContentAlignment.MiddleCenter; // Alinhando o texto ao centro
            labelValorPanel2.Size = panel2.Size; // Definindo o tamanho do label igual ao tamanho do painel
            panel2.Controls.Add(labelValorPanel2); // Adicionando o controle de texto

            // Adicionando os controles ao formulário
            this.Controls.Add(panel1);
            this.Controls.Add(panel2);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
        }

    }
}