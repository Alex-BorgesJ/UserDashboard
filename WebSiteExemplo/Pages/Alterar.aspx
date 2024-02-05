<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.master" AutoEventWireup="true" CodeFile="Alterar.aspx.cs" Inherits="Pages_Alterar2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row justify-content-center">
        <div class="card col-md-4 border-0 shadow-lg my-5">
            <form id="form1" runat="server">
                <div class="form-group mb-3">
                    <asp:label id="lblNome" text="Nome" runat="server"></asp:label>
                    <asp:textbox class="form-control" id="txtNome" runat="server"></asp:textbox>

                    <asp:label id="lblSalario" text="Salário" runat="server"></asp:label>
                    <asp:textbox class="form-control" id="txtSalario" runat="server"></asp:textbox>

                    <asp:label id="lblCracha" text="Crachá" runat="server"></asp:label>
                    <asp:textbox class="form-control" id="txtCracha" runat="server"></asp:textbox>
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


</asp:Content>

