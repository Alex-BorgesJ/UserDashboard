using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteExemplo.Classes.Equipe;
using WebSiteExemplo.Persistencia.Equipe;

public partial class Pages_Heranca_AlterarPilo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            PilotoBD bd = new PilotoBD();
            Piloto piloto = bd.Select(Convert.ToInt32(Session["ID"]));
            txtNome.Text = piloto.Nome;
            txtContrato.Text = piloto.Contrato;
            txtAltura.Text = Convert.ToString(piloto.Altura);
            txtPeso.Text = Convert.ToString(piloto.Peso);
        }
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        PilotoBD bd = new PilotoBD();
        Piloto piloto = bd.Select(Convert.ToInt32(Session["ID"]));
        piloto.Nome = txtNome.Text;
        piloto.Contrato = txtContrato.Text;
        piloto.Altura = Convert.ToDouble(txtAltura.Text);
        piloto.Peso = Convert.ToDouble(txtPeso.Text);
        if (bd.Update(piloto))
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