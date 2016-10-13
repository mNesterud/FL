using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FL
{
    public partial class index : System.Web.UI.Page
    {
        int tryck = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["knappTryck"] != null)
            {
                tryck = Convert.ToInt32(Session["knappTryck"]);
            }
            if (!IsPostBack)
            {
                Label1.Text = "Välkommen";
                Session["knappTryck"] = 0;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tryck++;
            Session["knappTryck"] = tryck;
            Label1.Text = "Du har tryckt på knappen " + tryck.ToString() + " gånger!";
        }

    }
}