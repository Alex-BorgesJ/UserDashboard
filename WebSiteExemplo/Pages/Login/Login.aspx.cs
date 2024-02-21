using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteExemplo.Classes.Login;
using WebLogin.Persistencia;

public partial class Pages_Login_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private bool IsPreenchido(string str)
    {
        bool retorno = false;
        if (str != string.Empty)
        {
            retorno = true;
        }
        return retorno;
    }
    private bool UsuarioEncontrado(Pessoa pessoa)
    {
        bool retorno = false;
        if (pessoa != null)
        {
            retorno = true;
        }
        return retorno;
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string email = txtEmail.Text.Trim();
        string senha = txtSenha.Text.Trim();
        if (!IsPreenchido(email))
        {
            lblMensagem.Text = "Preencha o email";
            txtEmail.Focus();
            return;
        }
        if (!IsPreenchido(senha))
        {
            lblMensagem.Text = "Preencha a senha";
            txtSenha.Focus();
            return;
        }
        PessoaBD bd = new PessoaBD();
        Pessoa pessoa = new Pessoa();
        pessoa = bd.Autentica(email, senha);
        if (!UsuarioEncontrado(pessoa))
        {
            lblMensagem.Text = "Usuário não encontrado";
            txtEmail.Focus();
            return;
        }
        Session["TipoUsuario"] = pessoa.Tipo;
        Session["ID"] = pessoa.Codigo;
        switch (pessoa.Tipo)
        {
            case 0:
                Response.Redirect("Admin.aspx");
                break;
            case 1:
                Response.Redirect("Admin.aspx");
                break;
            default:
                break;
        }
    }
}