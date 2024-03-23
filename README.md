# lion-finance-app
 Aplicativo de finanças que cria relatórios e estatísticas baseado nos gastos e lucros pessoais.

## Requisitos
- Visual Studio Community
- Access
- Arquivo do Banco de Dados (LionFinance.mdb)
  <br>
  <br>
### ATENÇÃO
Para que o aplicativo funcione corretamente, é <strong>obrigatório</strong> conectar o banco de dados do Access (arquivo LionFinance.mdb) ao Visual Studio Community: 
- Com o projeto aberto no Visual Studio Community, clique na aba superior Ferramentas > Conectar-se a Banco de Dados > Em "fonte de dados" selecionar a opção Arquivo Access > em "Nome do arquivo de banco de dados" clicar em "Procurar" e selecionar o arquivo LionFinance.mdb > Clicar em "Testar Conexão".
- Se a conexão for bem sucedida, clique em Avançado, copie a linha "Provider=Microsoft[...]" inteira e clique em OK nas duas telas. 
- Após o processo, colar o caminho do arquivo .mdb (Provider=Microsoft[...]) no código da TelaLogin(linha 11) e TelaCadastro (linha 18).
<br>
<i>Observação: Devido a questões de segurança, o arquivo do banco de dados LionFinance.mdb não pode ser armazenado diretamente no GitHub. Se quiser contribuir com o código e ter acesso ao arquivo, entre em contato comigo para obte-lo.

## Andamento do Projeto

- Tela de Login: <i>Concluído</i>
- Tela de Cadastro: <i>Concluído</i>
- Tela Principal: <i>Em andamento</i>
- Conexão com Banco de Dados SQL Server: <i>Concluído</i>

## Tela Login

![telaloginLionFinance](https://github.com/layla-lima/lion-finance-app/assets/129623575/ca00daef-4d9e-4876-b2fa-9ef37a6c4d0b)

## Tela de Cadastro

![telaCadastro](https://github.com/layla-lima/lion-finance-app/assets/129623575/c52d009b-3d4d-48b6-98d9-4bee471141f4)

## Tela Principal
<i>Em andamento</i>

