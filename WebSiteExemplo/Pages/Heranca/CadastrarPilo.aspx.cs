using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteExemplo.Classes.Equipe;
using WebSiteExemplo.Persistencia.Equipe;

public partial class Pages_Heranca_CadastrarPilo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtNomeP.Focus();
    }

    private void LimparCampos()
    {
        txtNomeP.Text = "";
        txtContratoP.Text = ""; 
        txtAlturaP.Text = "";
        txtPesoP.Text = "";
    }

    protected void btnSalvar_ClickP(object sender, EventArgs e)
    {
        Piloto piloto = new Piloto();
        piloto.Nome = txtNomeP.Text;
        piloto.Contrato = txtContratoP.Text;
        piloto.Altura = Convert.ToDouble(txtAlturaP.Text);
        piloto.Peso = Convert.ToDouble(txtPesoP.Text);
        PilotoBD bd = new PilotoBD();
        int retorno = bd.Insert(piloto);
        switch (retorno)
        {
            case 0:
                LimparCampos();
                txtNomeP.Focus();
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