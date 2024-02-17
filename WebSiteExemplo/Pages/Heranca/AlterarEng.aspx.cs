using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteExemplo.Classes.Equipe;
using WebSiteExemplo.Persistencia.Equipe;

public partial class Pages_Heranca_AlterarEng : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            EngenheiroBD bd = new EngenheiroBD();
            Engenheiro engenheiro = bd.Select(Convert.ToInt32(Session["ID"]));
            txtNome.Text = engenheiro.Nome;
            txtContrato.Text = engenheiro.Contrato;
            txtCREA.Text = engenheiro.CREA;
        }
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        EngenheiroBD bd = new EngenheiroBD();
        Engenheiro engenheiro = bd.Select(Convert.ToInt32(Session["ID"]));
        engenheiro.Nome = txtNome.Text;
        engenheiro.Contrato = txtContrato.Text;
        engenheiro.CREA = txtCREA.Text;
        if (bd.Update(engenheiro))
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