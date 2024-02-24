using System;
using System.Data;
using System.Web.UI.WebControls;
using WebSiteExemplo.Persistencia;


public partial class Pages_Login_Cliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["TipoUsuario"] != null &&  ((int) Session["TipoUsuario"] == 1 || (int) Session["TipoUsuario"] == 0))
        {
            Carrega();
        }
        else {
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
}