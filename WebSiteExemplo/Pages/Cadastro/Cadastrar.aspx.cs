using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteExemplo.Classes;
using WebSiteExemplo.Persistencia; 

public partial class Pages_Cadastrat2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Funcionario funcionario = new Funcionario();
        funcionario.Nome = txtNome.Text;
        funcionario.Salario = Convert.ToDouble(txtSalario.Text);
        funcionario.Cracha = txtCracha.Text;
        FuncionarioBD bd = new FuncionarioBD();
        if (bd.Insert(funcionario))
        {
            lblMensagem.Text = "Funcionário cadastrado com sucesso";
            txtNome.Text = "";
            txtCracha.Text = "";
            txtSalario.Text = "";
            txtNome.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }
}