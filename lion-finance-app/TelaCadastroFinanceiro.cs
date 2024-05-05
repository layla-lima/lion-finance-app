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
                // Abri instancia para a classe de acessoDB
                AcessoDB acessoDB = new AcessoDB();

                acessoDB.InsercaoFinancias(txtFinanc.Text, txtConta.Text, 
                    txtParc.Text, txtAluguel.Text, 
                    txtCompra.Text, txtLazer.Text, 
                    txtTransp.Text, txtRendaFixa.Text, 
                    txtRendaVari.Text, TxtNome);
                
                MessageBox.Show("Finanças salvas com sucesso!");

                TelaRelatorio telaRelatorio = new TelaRelatorio(TxtNome);

                telaRelatorio.Show();
                this.Hide();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
