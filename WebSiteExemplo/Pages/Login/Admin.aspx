﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Pages_Login_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <h1 class="h3 mb-2 text-gray-800">Interface de Administrador</h1>
        <form class="user" runat="Server">
            <nav class="navbar-nav navbar-expand topbar mb-4 static-top">
                <ul class="navbar-nav ml-auto">
                    <asp:button class="btn btn-primary" id="btnSair" text="Sair" runat="Server" onclick="btnSair_Click" />
                </ul>
            </nav>
            <div class="card-body shadow-lg">
                <div class="table-responsive">
                    <asp:gridview id="GridView" runat="server" autogeneratecolumns="False" onrowcommand="GridView_RowCommand" class="table table-bordered">
            <Columns>
                <asp:BoundField HeaderText="Nome" DataField="fun_nome" />
                <asp:BoundField HeaderText="Salário" DataField="fun_salario" />
                <asp:BoundField HeaderText="Crachá" DataField="fun_cracha" />

                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lbAlterar" runat="server" CommandName="Alterar"
                            CommandArgument='<%# Bind("fun_codigo")%>' class="btn btn-info mx-4">Alterar</asp:LinkButton>
                 
                        <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar"
                            CommandArgument='<%# Bind("fun_codigo")%>' class="btn btn-danger">Excluir</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:gridview>
                </div>
            </div>
        </form>
    </div>
</asp:Content>

