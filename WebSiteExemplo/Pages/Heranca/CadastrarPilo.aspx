<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.master" AutoEventWireup="true" CodeFile="CadastrarPilo.aspx.cs" Inherits="Pages_Heranca_CadastrarPilo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <h1 class="h3 mb-2 text-gray-800">Cadastro de Pilotos</h1>
        <div class="row justify-content-center">
            <div class="col-md-4">
                <div class="card p-3 m-1 rounded shadow-lg">
                    <form runat="server">
                        <div class="form-group mb-3">
                            <div class="my-2">
                                <asp:label id="lblNomeP" text="Nome" runat="server"></asp:label>
                                <asp:textbox class="form-control" id="txtNomeP" runat="server"></asp:textbox>
                            </div>
                            <div class="my-2">
                                <asp:label id="lblContratoP" text="Contrato" runat="server"></asp:label>
                                <asp:textbox class="form-control" id="txtContratoP" runat="server"></asp:textbox>
                            </div>
                            <div class="my-2">
                                <asp:label id="lblAlturaP" text="Altura" runat="server"></asp:label>
                                <asp:textbox class="form-control" id="txtAlturaP" runat="server"></asp:textbox>
                            </div>
                            <div class="my-2">
                                <asp:label id="lblPesoP" text="Peso" runat="server"></asp:label>
                                <asp:textbox class="form-control" id="txtPesoP" runat="server"></asp:textbox>
                            </div>

                        </div>
                        <div class="px-5">
                            <asp:button class="btn btn-primary btn-block" id="btnSalvar" text="Salvar" runat="server" onclick="btnSalvar_ClickP" />
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

