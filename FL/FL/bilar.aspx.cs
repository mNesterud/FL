using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Diagnostics;
using System.Configuration;
using System.Globalization;
using System.Threading;

namespace FL
{
    public partial class bilar : System.Web.UI.Page
    {
        List<Bil> bilLista = new List<Bil>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["bilar"] != null)
            //{
            //    bilLista = (List<Bil>)Session["bilar"];
            //}
            

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Bil b = new Bil();
            b.märke = txtMake.Text;
            b.modell = txtModel.Text;
            bilLista.Add(b);
            //Session["bilar"] = bilLista;

            foreach (Bil B in bilLista)
            {
                HtmlGenericControl div = new HtmlGenericControl("div");
                div.InnerHtml = B.märke + " " + B.modell;
                allabilar.Controls.Add(div);
            }



        }
    }
}