using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Data.OleDb;
using static lion_finance_app.TelaRelatorio.DadosFinanceirosEntity;

namespace lion_finance_app
{
    public partial class TelaRelatorio : Form
    {
        private double rendaFixa;
        private double rendaVariavel;
        private double financiamento;
        private double conta;
        private double parcelamento;
        private double aluguel;
        private double compras;
        private double lazer;
        private double transporte;
        private string nomeUsuario;


        public TelaRelatorio(string nomeUsuario)
        {
            InitializeComponent();

            this.nomeUsuario = nomeUsuario;

            //Retorna objeto com os dados financeiros do cliente por consulta sql
            DadosFinanceirosEntity dadosFinanceirosEntity = retornaDadosFinanceirosCliente();

            // exibir informações do banco de dados
            ExibirInformacoesDoBancoDeDados(dadosFinanceirosEntity);

            // exibir top 5 maiores despesas
            ExibirTop5Despesas(dadosFinanceirosEntity);

            //exibir porcentual das duas entradas
            ExibirPorcentualEntradas(dadosFinanceirosEntity);

            //exibir total das entradas e saidas
            totalEntradasSaidas(dadosFinanceirosEntity);

        }

        private DadosFinanceirosEntity retornaDadosFinanceirosCliente() {
            try
            {
                string stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\nikol\OneDrive\Documentos\projetos\unip\lion-finance-app\lion-finance-app\LionFinance.mdb";
                OleDbConnection conn = new OleDbConnection(stringcon);
                conn.Open();

                // Consulta SQL para obter as informações desejadas do banco de dados
                string SQL = "SELECT Financias.* FROM Financias WHERE Financias.id_financias IN (SELECT Usuarios.id_financias FROM Usuarios WHERE Usuarios.Nome = @nome)";
                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@nome", nomeUsuario);
                OleDbDataReader reader = cmd.ExecuteReader();

               // Verificar se há resultados
                if (reader.Read()){

                    // Extrair os valores do banco de dados
                     financiamento = Convert.ToDouble(reader["financiamento"]);
                     conta = Convert.ToDouble(reader["contas"]);
                     parcelamento = Convert.ToDouble(reader["parcelamentos"]);
                     aluguel = Convert.ToDouble(reader["aluguel_mensal"]);
                     compras = Convert.ToDouble(reader["compras"]);
                     lazer = Convert.ToDouble(reader["lazer"]);
                     transporte = Convert.ToDouble(reader["transporte"]);
                     rendaFixa = Convert.ToDouble(reader["renda_fixa"]);
                     rendaVariavel = Convert.ToDouble(reader["renda_variavel"]);

                     DadosFinanceirosEntity financeirosEntity = new DadosFinanceirosEntity(rendaFixa, rendaVariavel, 
                        new DespesasEntity(financiamento, conta, parcelamento, aluguel, compras, lazer, transporte));

                     return financeirosEntity;

                }else{
                     MessageBox.Show("Nenhuma informação encontrada no banco de dados.");
                }     
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
            }
            return null;
        }

        //Classe para comportar a entidade "Financias" do clienet
        public class DadosFinanceirosEntity
        {
            // Propriedades públicas para os dados financeiros
            public double RendaFixa { get; set; }
            public double RendaVariavel { get; set; }
            public DespesasEntity Despesas { get; set; }

            // Construtor da classe DadosFinanceirosEntity
            public DadosFinanceirosEntity(double rendaFixa, double rendaVariavel, DespesasEntity despesas)
            {
                RendaFixa = rendaFixa;
                RendaVariavel = rendaVariavel;
                Despesas = despesas;
            }

            // Definição da classe DespesasEntity
            public class DespesasEntity
            {
                // Propriedades públicas para os dados de despesas
                public double Financiamento { get; set; }
                public double Contas { get; set; }
                public double Parcelamento { get; set; }
                public double Aluguel { get; set; }
                public double Compras { get; set; }
                public double Lazer { get; set; }
                public double Transporte { get; set; }

                // Construtor da classe DespesasEntity
                public DespesasEntity(double financiamento, double contas, double parcelamento, double aluguel, double compras, double lazer, double transporte)
                {
                    Financiamento = financiamento;
                    Contas = contas;
                    Parcelamento = parcelamento;
                    Aluguel = aluguel;
                    Compras = compras;
                    Lazer = lazer;
                    Transporte = transporte;
                }
            }
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
            int index = 0;
            foreach (var (categoria, valor) in maioresDespesas)
            {
                series.Slices.Add(new PieSlice(categoria, valor) { Fill = coresPizza[index++] });
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

            // Calcula a porcentagem da renda fixa em relação ao total
            double percentualRendaFixa = (dados.RendaFixa / (dados.RendaFixa + dados.RendaVariavel)) * 100;

            // Calcula a porcentagem da renda variável em relação ao total
            double percentualRendaVariavel = (dados.RendaVariavel / (dados.RendaFixa + dados.RendaVariavel)) * 100;

            // Adicione os dados das colunas
            var columnData = new List<ColumnData>
            {
                new ColumnData { Category = "Fixa", Value = percentualRendaFixa },
                new ColumnData { Category = "Variavel", Value = percentualRendaVariavel },
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

        private void totalEntradasSaidas(DadosFinanceirosEntity dados)
        {
            // Criando os dois painéis
            Panel panel1 = new Panel();
            Panel panel2 = new Panel();

            // Definindo um tom de dourado mais suave
            System.Drawing.Color douradoSuave = System.Drawing.Color.FromArgb(201, 160, 80);

            // Definindo propriedades dos painéis
            panel1.BackColor = douradoSuave;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Size = new System.Drawing.Size(200, 150); // Aumentando o tamanho do primeiro painel
            panel1.Location = new System.Drawing.Point(50, this.ClientSize.Height - panel1.Height - 100); // Ajustando a posição do primeiro painel

            panel2.BackColor = douradoSuave;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Size = new System.Drawing.Size(200, 150); // Aumentando o tamanho do segundo painel
            panel2.Location = new System.Drawing.Point(panel1.Right + 50, this.ClientSize.Height - panel2.Height - 100); // Ajustando a posição do segundo painel

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
