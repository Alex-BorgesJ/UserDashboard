<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.master" AutoEventWireup="true" CodeFile="Cliente.aspx.cs" Inherits="Pages_Login_Cliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <h1 class="h3 mb-2 text-gray-800">Interface de Cliente</h1>
        <form class="user" runat="Server">
            <nav class="navbar-nav navbar-expand topbar mb-4 static-top">
                <ul class="navbar-nav ml-auto">
                    <asp:Button class="btn btn-primary" ID="btnSair" Text="Sair" runat="Server" OnClick="btnSair_Click" />
                </ul>
            </nav>
            <div class="card-body shadow-lg">
                <div class="table-responsive">
                    <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" class="table table-bordered">
                        <Columns>
                            <asp:BoundField HeaderText="Nome" DataField="fun_nome" />
                            <asp:BoundField HeaderText="Salário" DataField="fun_salario" />
                            <asp:BoundField HeaderText="Crachá" DataField="fun_cracha" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </form>
    </div>
</asp:Content>

