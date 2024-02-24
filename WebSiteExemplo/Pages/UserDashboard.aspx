<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.master" AutoEventWireup="true" CodeFile="UserDashboard.aspx.cs" Inherits="Pages_UserDashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">

        <!-- Page Heading -->
        <h1 class="h3 mb-2 text-gray-800">Navegador do UserDashboard</h1>
        <p class="mb-4">
            <a>Bem-vindo ao UserDashboard que explora diversas funcionalidades e aspectos fundamentais do
                        desenvolvimento ASP.net e MySQL! Neste espaço central, você pode acessar facilmente as
                        diferentes partes do sistema. Explore as seções do projeto através da lista abaixo ou do menu
                        lateral.</a>.
        </p>

        <!-- DataTales Example -->
        <div class="card-header py-3">
            <h6 class="m-0 font-weight-bold text-primary">Secções do UserDashboard</h6>
        </div>
        <div class="card-body">
            <div class="table-responsive">
                <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                    <thead>
                        <tr>
                            <th>Secção</th>
                            <th>Funcionalidades</th>
                            <th>Descrição</th>
                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>Secção</th>
                            <th>Funcionalidades</th>
                            <th>Descrição</th>
                        </tr>
                    </tfoot>
                    <tbody>
                        <!-- Inicio Sessão Cadastro -->
                        <tr>
                            <td rowspan="2" class="align-middle">
                                <h6>CADASTRO</h6>
                            </td>
                            <td>
                                <a class="d-block text-center" href="<%= UrlNav("Cadastro/Cadastrar.aspx")  %>">Cadastro</a>
                            </td>
                            <td>
                                <p>Através do link fornecido, você pode acessar uma interface responsiva para registrar dados em nosso banco MySQL de forma simples e eficiente, integrada à sessão de cadastro simplificado, desenvolvida com ASP.net</p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <a class="d-block text-center" href="<%= UrlNav("Cadastro/Listar.aspx")  %>">Listar</a>
                            </td>
                            <td>
                                <p>O link fornecido direciona para uma interface de listagem dos dados armazenados no banco de dados. Nessa interface, é possível visualizar os dados, realizar alterações e até mesmo excluí-los, tudo de forma intuitiva e simples, diretamente pela interface</p>
                            </td>
                        </tr>
                        <!-- Fim Sessão Cadastro -->

                        <!-- Inicio Sessão Herança -->
                        <tr>
                            <td rowspan="4" class="align-middle">
                                <h6>HERANÇA</h6>
                            </td>
                            <td>
                                <a class="d-block text-center" href="<%= UrlNav("Heranca/CadastrarEng.aspx")  %>">Cadastro de Engenheiros</a>
                            </td>
                            <td>
                                <p> Este link direciona para uma página onde é possível cadastrar novos engenheiros. Utilizando a metodologia de herança de classes, podemos criar diferentes formas de registro para indivíduos com formação em engenharia, mantendo-os dentro do mesmo banco de dados</p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <a class="d-block text-center" href="<%= UrlNav("Heranca/ListarEng.aspx")  %>">Lista de Engenheiros</a>
                            </td>
                            <td>
                                <p>Ao clicar neste link, você será redirecionado para uma página que exibe uma lista de todos os engenheiros cadastrados. Através da herança de classes, conseguimos gerenciar e visualizar esses registros de forma eficiente</p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <a class="d-block text-center" href="<%= UrlNav("Heranca/CadastrarPilo.aspx")  %>">Cadastro de Pilotos</a>
                            </td>
                            <td>
                                <p>Este link leva a uma página de cadastro específica para pilotos. Utilizando a herança de classes, podemos criar um formulário adaptado para o registro de dados de pilotos, mantendo a integridade dos dados no banco de dados</p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <a class="d-block text-center" href="<%= UrlNav("Heranca/ListarPilo.aspx")  %>">Lista de Pilotos</a>
                            </td>
                            <td>
                                <p>Ao clicar neste link, você acessará uma página que apresenta uma lista completa de todos os pilotos cadastrados. Através do uso da herança de classes, podemos garantir uma organização adequada dos registros de pilotos, facilitando a sua visualização e gerenciamento</p>
                            </td>
                        </tr>
                        <!-- Fim Sessão Herança -->
                        <!-- Inicio Sessão Login -->
                        <tr>
                            <td rowspan="1" class="align-middle">
                                <h6>LOGIN</h6>
                            </td>
                            <td>
                                <a class="d-block text-center" href="<%= UrlNav("Login/Login.aspx")  %>">Login</a>
                            </td>
                            <td>
                                <p>Este link direciona para uma página onde é possível interagir com uma interface de login. Por favor, utilize um email e senha válidos (por favor, cadastre tais dados dentro do seu banco de dados). Na página, você encontrará uma interface com design voltado para administradores, assim como outra destinada aos clientes</p>
                            </td>
                        </tr>                        
                        <!-- Fim Sessão Login -->

                    </tbody>
                </table>
            </div>
        </div>
    </div>
</asp:Content>

