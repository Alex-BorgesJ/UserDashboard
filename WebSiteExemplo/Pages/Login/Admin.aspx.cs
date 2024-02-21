using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Login_Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["TipoUsuario"] != null && (int)Session["TipoUsuario"] == 0)
        {

        }
        else if (Session["TipoUsuario"] != null && (int)Session["TipoUsuario"] == 1)
        {
            Response.Redirect("Cliente.aspx");
        }
        else {
            Response.Redirect("Login.aspx");
        }
    }
}