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
using System.Xml;

namespace FL
{
    public partial class bilar : System.Web.UI.Page
    {
        //List<Bil> bilLista = new List<Bil>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AppendCars(XmlToList());
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("bilar.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNode root = doc.DocumentElement;

            XmlElement newCar = doc.CreateElement("bil");

            XmlElement make = doc.CreateElement("märke");
            make.InnerText = txtMake.Text;
            XmlElement model = doc.CreateElement("modell");
            model.InnerText = txtModel.Text;

            newCar.AppendChild(make);
            newCar.AppendChild(model);
            root.AppendChild(newCar);

            doc.Save(path);

            AppendCars(XmlToList());

            Response.Redirect("bilar.aspx");

        }
        public void XmlSwitchCase()
        {
            string bilar = "";

            string path = Server.MapPath("bilar.xml");

            XmlTextReader xreader = new XmlTextReader(path);

            while (xreader.Read())
            {
                switch (xreader.Name)
                {
                    case "märke":
                        bilar += xreader.ReadString() +" ";
                        break;
                }
            }

            allamärken.InnerHtml = bilar;
        }
        public void AppendCars(List<Bil> bilLista)
        {
            foreach (Bil b in bilLista)
            {
                HtmlGenericControl div = new HtmlGenericControl("div");
                //div.InnerText = b.märke + " " + b.modell;
                //div.InnerHtml = "<div>" + b.märke + "</div>";
                div.Attributes.Add("class", "biltext");
                
                HtmlGenericControl innerdiv = new HtmlGenericControl("div");
                innerdiv.InnerText = b.märke + " " + b.modell;
                div.Controls.Add(innerdiv);

                allabilar.Controls.Add(div);
            }
        }
        public List<Bil> XmlToList()
        {
            List<Bil> bilLista = new List<Bil>();

            string path = Server.MapPath("bilar.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNodeList allCars = doc.SelectNodes("/garage/garageport/bil");

            foreach (XmlNode node in allCars)
            {
                Bil b = new Bil();
                b.märke = node["märke"].InnerText;
                b.modell = node["modell"].InnerText;
                bilLista.Add(b);

            }

            return bilLista;
        }

    }
}