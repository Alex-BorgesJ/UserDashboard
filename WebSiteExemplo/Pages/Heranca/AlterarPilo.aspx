<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.master" AutoEventWireup="true" CodeFile="AlterarPilo.aspx.cs" Inherits="Pages_Heranca_AlterarPilo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <h1 class="h3 mb-2 text-gray-800">Alterar Piloto</h1>
        <div class="row justify-content-center">
            <div class="card col-md-4 border-0 shadow-lg my-5">
                <form id="form1" runat="server">
                    <div class="form-group mb-3">
                        <asp:Label ID="lblNome" Text="Nome" runat="server"></asp:Label>
                        <asp:TextBox class="form-control" ID="txtNome" runat="server"></asp:TextBox>

                        <asp:Label ID="lblContrato" Text="Contrato" runat="server"></asp:Label>
                        <asp:TextBox class="form-control" ID="txtContrato" runat="server"></asp:TextBox>

                        <asp:Label ID="lblAltura" Text="Altura" runat="server"></asp:Label>
                        <asp:TextBox class="form-control" ID="txtAltura" runat="server"></asp:TextBox>

                        <asp:Label ID="lblPeso" Text="Peso" runat="server"></asp:Label>
                        <asp:TextBox class="form-control" ID="txtPeso" runat="server"></asp:TextBox>
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
</asp:Content>

