using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteExemplo.Classes;
using WebSiteExemplo.Persistencia;
public partial class Pages_Alterar2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FuncionarioBD bd = new FuncionarioBD();
            Funcionario funcionario = bd.Select(Convert.ToInt32(Session["ID"]));
            txtNome.Text = funcionario.Nome;
            txtSalario.Text = funcionario.Salario.ToString();
            txtCracha.Text = funcionario.Cracha;
        }
    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        FuncionarioBD bd = new FuncionarioBD();
        Funcionario funcionario = bd.Select(Convert.ToInt32(Session["ID"]));
        funcionario.Nome = txtNome.Text;
        funcionario.Salario = Convert.ToDouble(txtSalario.Text);
        funcionario.Cracha = txtCracha.Text;
        if (bd.Update(funcionario))
        {
            lblMensagem.Text = "Funcionário alterado com sucesso";
            txtNome.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }
}