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
                // Verificar se as senhas coincidem
                if (txtSenha.Text != txtConfSenha.Text)
                {
                    MessageBox.Show("As senhas não coincidem. Por favor, digite novamente.");
                    return; // Retorna sem prosseguir com a criação da conta
                }

                // Abri instancia para a classe de acessoDB
                AcessoDB acessoDB = new AcessoDB();

                //acesso metodo de insercao do registro do usuario na tabela
                acessoDB.InsercaoUsuario(txtNome.Text, txtEmail.Text, txtSenha.Text);

                MessageBox.Show("Conta criada com sucesso!");

                // Enviar nome do usuário pelo construtor para a tela de cadastro financeiro
                TelaCadastroFinanceiro telaCadastroFinanceiro = new TelaCadastroFinanceiro(txtNome.Text);

                // Limpar dados após criar conta:
                txtEmail.Clear();
                txtNome.Clear();
                txtSenha.Clear();
                txtConfSenha.Clear();

                // Abrir a tela de login após usuário criar conta
                telaCadastroFinanceiro.Show();
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
