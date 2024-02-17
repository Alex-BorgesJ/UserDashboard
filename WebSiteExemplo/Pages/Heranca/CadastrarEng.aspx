<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.master" AutoEventWireup="true" CodeFile="CadastrarEng.aspx.cs" Inherits="Pages_Heranca_Cadastrar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <h1 class="h3 mb-2 text-gray-800">Cadastro de Engenheiros</h1>
        <div class="row justify-content-center">
            <div class="col-md-4">
                <div class="card p-3 m-1 rounded shadow-lg">
                    <form runat="server">
                        <div class="form-group mb-3">
                            <div class="my-2">
                                <asp:label id="lblNomeH" text="Nome" runat="server"></asp:label>
                                <asp:textbox class="form-control" id="txtNomeH" runat="server"></asp:textbox>
                            </div>
                            <div class="my-2">
                                <asp:label id="lblContratoH" text="Contrato" runat="server"></asp:label>
                                <asp:textbox class="form-control" id="txtContratoH" runat="server"></asp:textbox>
                            </div>
                            <div class="my-2">
                                <asp:label id="lblCREAH" text="CREA" runat="server"></asp:label>
                                <asp:textbox class="form-control" id="txtCREAH" runat="server"></asp:textbox>
                            </div>

                        </div>
                        <div class="px-5">
                            <asp:button class="btn btn-primary btn-block" id="btnSalvar" text="Salvar" runat="server" onclick="btnSalvar_ClickH" />
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
    </div>
</asp:Content>

