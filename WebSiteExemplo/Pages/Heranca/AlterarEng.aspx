<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.master" AutoEventWireup="true" CodeFile="AlterarEng.aspx.cs" Inherits="Pages_Heranca_AlterarEng" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <h1 class="h3 mb-2 text-gray-800">Alterar Engenheiro</h1>
        <div class="row justify-content-center">
            <div class="card col-md-4 border-0 shadow-lg my-5">
                <form id="form1" runat="server">
                    <div class="form-group mb-3">
                        <asp:label id="lblNome" text="Nome" runat="server"></asp:label>
                        <asp:textbox class="form-control" id="txtNome" runat="server"></asp:textbox>

                        <asp:label id="lblContrato" text="Contrato" runat="server"></asp:label>
                        <asp:textbox class="form-control" id="txtContrato" runat="server"></asp:textbox>

                        <asp:label id="lblCREA" text="CREA" runat="server"></asp:label>
                        <asp:textbox class="form-control" id="txtCREA" runat="server"></asp:textbox>
                    </div>
                    <div class="px-5">
                        <asp:button class="btn btn-primary btn-block" id="btnSalvar" text="Salvar" runat="server" onclick="btnSalvar_Click" />
                        <br>
                    </div>
                    <br>
                    <div class="text-center text-success my-2" role="alert">
                        <asp:label id="lblMensagem" text="" runat="server"></asp:label>
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>

