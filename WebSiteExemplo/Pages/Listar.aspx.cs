using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteExemplo.Persistencia;

public partial class Pages_Listar2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Carrega();
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
                Response.Redirect("Alterar.aspx");
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
