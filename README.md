# UserDashboard

##WebSiteExemplo
## Descrição

WebSiteExemplo é uma aplicação web simples para gerenciar informações de funcionários. Inclui classes para representar funcionários (`Funcionario`), uma camada de acesso a dados (`FuncionarioBD`) para operações no banco de dados, e uma utilidade de conexão ao banco (`Mapped`).

## Estrutura do Código

- Funcionario: Classe que representa um funcionário com propriedades como `Codigo`, `Nome`, `Salario` e `Cracha`.
- FuncionarioBD: Gerencia operações no banco de dados relacionadas a funcionários, incluindo inserção, seleção, atualização e exclusão.
- Mapped: Fornece funções de utilidade para operações no banco de dados, incluindo abertura de conexão, execução de comandos, criação de adaptadores e criação de parâmetros.

## Linguagens e Frameworks

- Linguagem: C#
- Banco de Dados: MySQL
- Frameworks: ASP.NET

## Criação do Banco de Dados
  CREATE DATABASE esbd;
  USE esbd;
  CREATE TABLE tbl_funcionario (
    fun_codigo INT PRIMARY KEY,
    fun_nome VARCHAR(255),
    fun_salario DECIMAL(10, 2),
    fun_cracha INT
  );

## Configuração do Banco de Dados

A aplicação utiliza um banco de dados MySQL. Para configurar a conexão com o banco, atualize o valor de `strConexao` no arquivo `Web.config` localizado na pasta raiz.

<appSettings>
    <add key="strConexao" value="Database=esbd;Data Source=localhost;User Id=Your_User;Password=Your_Password; pooling=false; SslMode=None"/>
</appSettings>
