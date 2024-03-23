using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace lion_finance_app
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            try
            {
                string stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Layla\Documents\Database\LionFinance.mdb";
                OleDbConnection conn = new OleDbConnection(stringcon);
                conn.Open();

                string SQL = "INSERT INTO Usuarios(Nome, Email, Senha) VALUES ";
                SQL += "('" + txtNome.Text + "', '" + txtEmail.Text + "', '" + txtSenha.Text + "')";
                OleDbCommand cmd = new OleDbCommand(SQL, conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Conta criada com sucesso!");

                // Limpar dados após criar conta:
                txtEmail.Clear();
                txtNome.Clear();
                txtSenha.Clear();
                txtConfSenha.Clear();
                // fechar conexao
                conn.Close();

                // Abrir a tela de login após usuario criar conta
                TelaLogin telaLogin = new TelaLogin();
                telaLogin.Show();
                this.Hide(); // Esconde a tela de cadastro após abrir a tela de login
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
