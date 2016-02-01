using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WhoISWebApplication.ServiceReference1;

namespace WhoISWebApplication
{
    public partial class WHOIS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            whoisSoapClient client = new whoisSoapClient("whoisSoap");
            
            LabelResult.Text = client.GetWhoIS(TextBox1.Text);
        }
    }
}