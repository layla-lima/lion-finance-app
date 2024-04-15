using System;
using System.Data.OleDb;
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
        }

        private void ExibirInformacoesDoBancoDeDados()
        {
            try
            {
                string stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\laysa\OneDrive\Documents\LionFinance\lion-finance-app\lion-finance-app\LionFinance.mdb";
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
    }
}
