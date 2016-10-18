using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;
using System.Configuration;

namespace FL
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login_Command(object sender, CommandEventArgs e)
        {
            string uID = e.CommandArgument.ToString();
            Session["uID"] = uID;

            Response.Redirect("bilar.aspx");
          

        }
    }
}