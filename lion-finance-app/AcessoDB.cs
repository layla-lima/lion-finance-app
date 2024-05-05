using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lion_finance_app
{
    public class AcessoDB
    {
        // string de conexão para o banco de dados Access
        string stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\nikol\OneDrive\Documentos\projetos\lion-finance-app\lion-finance-app\LionFinance.mdb";


        private OleDbConnection AbrirConexaoDB()
        {
            try
            {
                // Abrir conexão com o banco de dados Access
                OleDbConnection conn = new OleDbConnection(stringcon);
                conn.Open();
                return conn;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }
        }

        private void FecharConexaoDB(OleDbConnection conn)
        {
            conn.Close(); // Fechar conexão com o banco de dados Access
        }

        public DataTable AcessoUsuario(string txtLogin, string txtSenha)
        {
            //abertura conexão com o banco de dados
            OleDbConnection conn = AbrirConexaoDB();

            // Consultar o banco de dados Access
            string query = "SELECT * FROM Usuarios WHERE Nome = @Nome AND Senha = @Senha";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@Nome", txtLogin);
            cmd.Parameters.AddWithValue("@Senha", txtSenha);

            OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            //fechar conexão com o banco
            FecharConexaoDB(conn);

            return dt;

        }

        public DadosFinanceirosEntity AcessoFinancias(string nomeUsuario)
        {
            //abertura conexão com o banco de dados
            OleDbConnection conn = AbrirConexaoDB();

            // Consulta SQL para obter as informações desejadas do banco de dados
            string SQL = "SELECT Financias.* FROM Financias WHERE Financias.id_financias IN (SELECT Usuarios.id_financias FROM Usuarios WHERE Usuarios.Nome = @nome)";
            OleDbCommand cmd = new OleDbCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@nome", nomeUsuario);
            OleDbDataReader reader = cmd.ExecuteReader();

            DadosFinanceirosEntity financeirosEntity = null;

            // Verificar se há resultados
            if (reader.Read())
            {
                // Extrair os valores do banco de dados
                double financiamento = Convert.ToDouble(reader["financiamento"]);
                double conta = Convert.ToDouble(reader["contas"]);
                double parcelamento = Convert.ToDouble(reader["parcelamentos"]);
                double aluguel = Convert.ToDouble(reader["aluguel_mensal"]);
                double compras = Convert.ToDouble(reader["compras"]);
                double lazer = Convert.ToDouble(reader["lazer"]);
                double transporte = Convert.ToDouble(reader["transporte"]);
                double rendaFixa = Convert.ToDouble(reader["renda_fixa"]);
                double rendaVariavel = Convert.ToDouble(reader["renda_variavel"]);

                financeirosEntity = new DadosFinanceirosEntity(rendaFixa, rendaVariavel,
                   new DadosFinanceirosEntity.DespesasEntity(financiamento, conta, parcelamento, aluguel, compras, lazer, transporte));
            }
            else
            {
                MessageBox.Show("Nenhuma informação encontrada no banco de dados.");
            }

            //fechar conexão com o banco
            FecharConexaoDB(conn);
            return financeirosEntity;

        }

        public void InsercaoUsuario(string txtNome, string txtEmail, string txtSenha)
        {
            //abertura conexão com o banco de dados
            OleDbConnection conn = AbrirConexaoDB();

            //insercao do registro na tabela Usuarios
            string SQL = "INSERT INTO Usuarios(Nome, Email, Senha) VALUES ";
            SQL += "('" + txtNome + "', '" + txtEmail + "', '" + txtSenha + "')";
            OleDbCommand cmd = new OleDbCommand(SQL, conn);
            cmd.ExecuteNonQuery();

            //fechar conexão com o banco
            FecharConexaoDB(conn);
        }

        public void InsercaoFinancias(string txtFinanc, 
            string txtConta, 
            string txtParc, 
            string txtAluguel, 
            string txtCompra,
            string txtLazer,
            string txtTransp,
            string txtRendaFixa,
            string txtRendaVari,
            string nome)
        {
            //abertura conexão com o banco de dados
            OleDbConnection conn = AbrirConexaoDB();

            //Inserir Dados financeiros do usuario
            string SQL = "INSERT INTO Financias(financiamento, contas, parcelamentos, " +
                "aluguel_mensal, compras, lazer, transporte, renda_fixa, renda_variavel) VALUES ";
            SQL += "('" + txtFinanc + "', '" 
                + txtConta + "', '" 
                + txtParc + "', '" 
                + txtAluguel + "', '" 
                + txtCompra + "', '" 
                + txtLazer + "', '" 
                + txtTransp + "', '" 
                + txtRendaFixa + "', '" 
                + txtRendaVari + "')";
            OleDbCommand cmd = new OleDbCommand(SQL, conn);
            cmd.ExecuteNonQuery();

            InsercaoIdFinanciasNoUsuario(conn, nome);

            //fechar conexão com o banco
            FecharConexaoDB(conn);
        }

        private void InsercaoIdFinanciasNoUsuario(OleDbConnection conn, string nome)
        {
            //Buscar o ultimo id_financias inserido (o que foi feito na linha acima)
            string SQLSelect = "SELECT MAX(id_financias) FROM Financias";
            OleDbCommand cmdSelect = new(SQLSelect, conn);
            int idFinancias = Convert.ToInt32(cmdSelect.ExecuteScalar());

            //atualizar a chave estrangeira na tabela usuarios com para ligar com os dados financeiros dele
            string SQLUpdate = "UPDATE Usuarios SET id_financias = @id_financias WHERE Nome = @nome";
            OleDbCommand cmdUpdate = new OleDbCommand(SQLUpdate, conn);
            cmdUpdate.Parameters.AddWithValue("@id_financias", idFinancias);
            cmdUpdate.Parameters.AddWithValue("@nome", nome);
            cmdUpdate.ExecuteNonQuery();
        }


    }
}
