<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.master" AutoEventWireup="true" CodeFile="Cadastrar.aspx.cs" Inherits="Pages_Cadastrat2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <h1 class="h3 mb-2 text-gray-800">Cadastro</h1>
        <div class="row justify-content-center">
            <div class="col-md-4">
                <div class="card p-3 m-1 rounded shadow-lg">
                    <form runat="server">
                        <div class="form-group mb-3">
                            <div class="my-2">
                                <asp:Label ID="lblNome" Text="Nome" runat="server"></asp:Label>
                                <asp:TextBox class="form-control" ID="txtNome" runat="server"></asp:TextBox>
                            </div>
                            <div class="my-2">
                                <asp:Label ID="lblSalario" Text="Salário" runat="server"></asp:Label>
                                <asp:TextBox class="form-control" ID="txtSalario" runat="server"></asp:TextBox>
                            </div>
                            <div class="my-2">
                                <asp:Label ID="lblCracha" Text="Crachá" runat="server"></asp:Label>
                                <asp:TextBox class="form-control" ID="txtCracha" runat="server"></asp:TextBox>
                            </div>

                        </div>
                        <div class="px-5">
                            <asp:Button class="btn btn-primary btn-block" ID="btnSalvar" Text="Salvar" runat="server" OnClick="btnSalvar_Click" />
                            <br>
                        </div>
                        <br>
                        <div class="text-center text-success my-2" role="alert">
                            <asp:Label ID="lblMensagem" Text="" runat="server"></asp:Label>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

