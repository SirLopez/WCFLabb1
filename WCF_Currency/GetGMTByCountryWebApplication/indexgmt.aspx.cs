using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GetGMTByCountryWebApplication.GMTByCountryServiceReference;

namespace GetGMTByCountryWebApplication
{
    public partial class indexgmt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var client = new countrySoapClient("countrySoap");
            
            LabelGmt.Text = client.GetGMTbyCountry(TextBox1.Text);
        }
    }
}