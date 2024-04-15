using System.Data.OleDb;

namespace lion_finance_app

{
    public partial class TelaCadastroFinanceiro : Form
    {
        public string TxtNome;
        public TelaCadastroFinanceiro(string txtNome)
        {
            InitializeComponent();
            this.TxtNome = txtNome;
        }


        private void btnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir conexão com o banco de dados Access
                string stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\laysa\OneDrive\Documents\LionFinance\lion-finance-app\lion-finance-app\LionFinance.mdb";
                OleDbConnection conn = new OleDbConnection(stringcon);
                conn.Open();

                //Inserir Dados financeiros do usuario
                string SQL = "INSERT INTO Financias(financiamento, contas, parcelamentos, aluguel_mensal, compras, lazer, transporte, renda_fixa, renda_variavel) VALUES ";
                SQL += "('" + txtFinanc.Text + "', '" + txtConta.Text + "', '" + txtParc.Text + "', '" + txtAluguel.Text + "', '" + txtCompra.Text + "', '" + txtLazer.Text + "', '" + txtTransp.Text + "', '" + txtRendaFixa.Text + "', '" + txtRendaVari.Text + "')";
                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.ExecuteNonQuery();

                //Buscar o ultimo id_financias inserido (o que foi feito na linha acima)
                string SQLSelect = "SELECT MAX(id_financias) FROM Financias";
                OleDbCommand cmdSelect = new(SQLSelect, conn);
                int idFinancias = Convert.ToInt32(cmdSelect.ExecuteScalar());

                //atualizar a chave estrangeira na tabela usuarios com para ligar com os dados financeiros dele
                string SQLUpdate = "UPDATE Usuarios SET id_financias = @id_financias WHERE Nome = @nome";
                OleDbCommand cmdUpdate = new OleDbCommand(SQLUpdate, conn);
                cmdUpdate.Parameters.AddWithValue("@id_financias", idFinancias);
                cmdUpdate.Parameters.AddWithValue("@nome", TxtNome);
                cmdUpdate.ExecuteNonQuery();

                MessageBox.Show("Finanças salvas com sucesso!");

                TelaRelatorio telaRelatorio = new TelaRelatorio();
                telaRelatorio.Show();
                this.Close();

                conn.Close();


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
