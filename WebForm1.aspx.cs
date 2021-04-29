using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cv12Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void spocti_Click(object sender, EventArgs e)
        {
            string op = null;
            switch (operatorDropDown.SelectedValue)
            {
                case "+":
                    op = "%2B";
                    break;
                case "-":
                    op = "%2D";
                    break;
                case "*":
                    op = "%2A";
                    break;
                case "/":
                    op = "%2F";
                    break;
            }
            Response.Redirect(String.Format("Vysledek.aspx?A={0}&B={1}&op={2}", operandA.Text, operandB.Text, op));
        }
    }
}