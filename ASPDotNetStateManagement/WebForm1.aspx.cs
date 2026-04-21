using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDotNetStateManagement
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["Clickscount"] = 0;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            count++;
            Label1.Text = "Count Clicks " + count;
            //int count = (int)ViewState["Clickscount"];
            //count++;
            //ViewState["Clickscount"] = count;
            //Label1.Text = "Click count" + count;
            
        }
    }
}
