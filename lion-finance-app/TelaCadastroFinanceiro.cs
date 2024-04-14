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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContas_Click(object sender, EventArgs e)
        {

        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lblSalario_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFinanc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFixos_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir conexão com o banco de dados Access
                string stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\nikol\OneDrive\Documentos\projetos\unip\lion-finance-app\lion-finance-app\LionFinance.mdb";
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


                txtFinanc.Clear();
                txtConta.Clear();
                txtParc.Clear();
                txtAluguel.Clear();
                txtCompra.Clear();
                txtLazer.Clear();
                txtTransp.Clear();
                txtRendaFixa.Clear();
                txtRendaVari.Clear();

                conn.Close();


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
