using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace lion_finance_app
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try{

                // Abri instancia para a classe de acessoDB
                AcessoDB acessoDB = new AcessoDB();

                //acessando metodo de consulta ao banco de dados para acesso do usuario
                DataTable registroUsuario = acessoDB.AcessoUsuario(txtLogin.Text, txtSenha.Text);

                if (registroUsuario.Rows.Count == 1){
                    TelaRelatorio financeiro = new(txtLogin.Text); // Passando o nome do usuário como argumento
                    financeiro.Show();
                    this.Hide();
                }else{
                    MessageBox.Show("Usuário ou Senha Incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception erro){
                MessageBox.Show(erro.Message);
            }
        }
    }
}
