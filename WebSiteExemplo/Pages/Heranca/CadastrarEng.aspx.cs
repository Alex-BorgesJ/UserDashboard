using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteExemplo.Classes.Equipe;
using WebSiteExemplo.Persistencia.Equipe;


public partial class Pages_Heranca_Cadastrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtNomeH.Focus();
    }

    private void LimparCampos()
    {
        txtNomeH.Text = "";
        txtContratoH.Text = "";
        txtCREAH.Text = "";
    }

    protected void btnSalvar_ClickH(object sender, EventArgs e)
    {
        Engenheiro engenheiro = new Engenheiro();
        engenheiro.Nome = txtNomeH.Text;
        engenheiro.Contrato = txtContratoH.Text;
        engenheiro.CREA = txtCREAH.Text;
        EngenheiroBD bd = new EngenheiroBD();
        int retorno = bd.Insert(engenheiro);
        switch (retorno)
        {
            case 0:
                LimparCampos();
                txtNomeH.Focus();
                lblMensagem.Text = "Cadastro realizado com sucesso";
                break;
            case 1:
                //Erro no banco de dados
                lblMensagem.Text = "Não foi possível realizar o cadastro.";
                break;
            case 2:
                //Erro geral
                lblMensagem.Text = "Não foi possível realizar o cadastro.";
                break;
            default:
                break;
        }
    }


}