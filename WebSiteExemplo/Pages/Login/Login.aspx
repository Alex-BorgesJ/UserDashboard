<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Login_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">

        <!-- Outer Row -->
        <div class="row justify-content-center">

            <div class="col-xl-5 col-lg-7 col-md-8">

                <div class="card o-hidden border-0 shadow-lg my-5">
                    <div class="card-body p-0">
                        <!-- Nested Row within Card Body -->
                        <div class="row">
                            <div class="col-lg-12">
                                <div class="p-5">
                                    <div class="text-center">
                                        <h1 class="h4 text-gray-900 mb-4">Bem vindo de volta!</h1>
                                    </div>
                                    <form class="user" runat="server">
                                        <div class="text-center text-danger my-2" role="alert">
                                            <asp:Label ID="lblMensagem" Text="" runat="server"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblEmail" Text="Email" runat="server"></asp:Label>
                                            <asp:TextBox class="form-control" ID="txtEmail" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblSenha" Text="Senha" runat="server"></asp:Label>
                                            <asp:TextBox class="form-control" ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
                                        </div>
                                        <asp:Button class="btn btn-primary btn-block" ID="btnLogin" Text="Entrar" runat="server" OnClick="btnLogin_Click" />
                                        <hr>
                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>

    </div>
</asp:Content>

