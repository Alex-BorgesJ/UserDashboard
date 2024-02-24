using System;
using System.Data;
using System.Web.UI.WebControls;
using WebSiteExemplo.Persistencia;

public partial class Pages_Login_Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["TipoUsuario"] != null && (int)Session["TipoUsuario"] == 0)
        {
            Carrega();
        }
        else if (Session["TipoUsuario"] != null && (int)Session["TipoUsuario"] == 1)
        {
            Response.Redirect("Cliente.aspx");
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void btnSair_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        Response.Redirect("Login.aspx");
    }

    private void Carrega()
    {
        FuncionarioBD bd = new FuncionarioBD();
        DataSet ds = bd.SelectAll();
        GridView.DataSource = ds.Tables[0].DefaultView;
        GridView.DataBind();
    }
    protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int codigo = 0;
        switch (e.CommandName)
        {
            case "Alterar":
                codigo = Convert.ToInt32(e.CommandArgument);
                Session["ID"] = codigo;
                Response.Redirect("~/Pages/Cadastro/Alterar.aspx");
                break;
            case "Deletar":
                codigo = Convert.ToInt32(e.CommandArgument);
                FuncionarioBD bd = new FuncionarioBD();
                bd.Delete(codigo);
                Carrega();
                break;
            default:
                break;
        }        
    }
}