using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Login_Cliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((int) Session["TipoUsuario"] == 1 || (int) Session["TipoUsuario"] == 0)
        {
        }
        else {
            Response.Redirect("Login.aspx");
        }
    }
}