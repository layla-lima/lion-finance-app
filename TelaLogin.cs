using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lion_finance_app
{
    public partial class TelaLogin : Form
    {
        // ref da conexao:
        SqlConnection Conexao = new SqlConnection(@"Data Source=DESKTOP-M2PRVUH; integrated security=SSPI;initial catalog=LionFinance");

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

        // button click - evento clicar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Conexao.Open(); // abrir conexão com o database
            string query = "SELECT * FROM Usuarios WHERE Nome = '" + txtLogin.Text + "' AND Senha = '" + txtSenha.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query,Conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                TelaPrincipal principal = new TelaPrincipal();
                this.Hide();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
