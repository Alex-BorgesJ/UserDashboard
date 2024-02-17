using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteExemplo.Persistencia.Equipe;

public partial class Pages_Heranca_Equipe_Listar_Heranca : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Carrega();
    }

    private void Carrega()
    {
        EngenheiroBD bd = new EngenheiroBD();
        DataSet ds = bd.SelectAll();
        //verifica a quantidade de engenheiros no dataset
        int quantidade = ds.Tables[0].Rows.Count;
        if (quantidade > 0)
        {
            grvEngenheiros.DataSource = ds.Tables[0].DefaultView;
            grvEngenheiros.DataBind();
            lblMensagem.Text = "Existem " + quantidade + " engenheiros cadastrados";
        }
        else
        {
            lblMensagem.Text = "Nenhum engenheiro cadastrado";
        }
    }

    protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int codigo = 0;
        switch (e.CommandName)
        {
            case "Alterar":
                codigo = Convert.ToInt32(e.CommandArgument);
                Session["ID"] = codigo;
                Response.Redirect("AlterarEng.aspx");
                break;
            case "Deletar":
                codigo = Convert.ToInt32(e.CommandArgument);
                EngenheiroBD bd = new EngenheiroBD();
                bd.Delete(codigo);
                Carrega();
                break;
            default:
                break;
        }
    }

}