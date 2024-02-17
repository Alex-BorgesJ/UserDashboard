<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.master" AutoEventWireup="true" CodeFile="ListarEng.aspx.cs" Inherits="Pages_Heranca_Equipe_Listar_Heranca" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <h1 class="h3 mb-2 text-gray-800">Lista de Engenheiros</h1>
        <form id="form1" runat="server">

            <div class="card-body shadow-lg">
                <div class="table-responsive">
                    <asp:gridview id="grvEngenheiros" runat="server" autogeneratecolumns="False" onrowcommand="GridView_RowCommand" class="table table-bordered">
                    <Columns>
                        <asp:BoundField HeaderText="Nome" DataField="mem_nome" />
                        <asp:BoundField HeaderText="Contrato" DataField="mem_contrato" />
                        <asp:BoundField HeaderText="CREA" DataField="mem_crea" />

                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lbAlterar" runat="server" CommandName="Alterar"
                                    CommandArgument='<%# Bind("mem_codigo")%>' class="btn btn-info mx-4">Alterar</asp:LinkButton>

                                <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar"
                                    CommandArgument='<%# Bind("mem_codigo")%>' class="btn btn-danger">Excluir</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>

                </asp:gridview>
                    <div class="text-center text-success my-2" role="alert">
                        <asp:label id="lblMensagem" text="" runat="server"></asp:label>
                    </div>
                </div>
            </div>
        </form>
    </div>
</asp:Content>

