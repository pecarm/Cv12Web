using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv12Web
{
    public partial class Vysledek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = Request.QueryString["A"];
            string b = Request.QueryString["B"];
            string op = Request.QueryString["op"];

            ServiceReference1.Service1Client sluzba = new ServiceReference1.Service1Client();

            if (a != null && b != null && op != null)
            {
                Response.Write(String.Format("{0} {1} {2} = {3}", a, op, b, sluzba.Spocti(Convert.ToDecimal(a), Convert.ToDecimal(b), op).ToString()));
            }
        }
    }
}