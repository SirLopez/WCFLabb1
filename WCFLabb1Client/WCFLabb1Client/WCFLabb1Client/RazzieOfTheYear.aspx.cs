using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFLabb1Client.RazzieOfTheYearServiceReference;

namespace WCFLabb1Client
{
    public partial class RazzieOfTheYear : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonResultRazzie_Click(object sender, EventArgs e)
        {
            var year = new RazzieOfTheYearSoapClient();
            if (TextBoxInput != null)
            {
                LabelResult.Text = year.RazzieYear(TextBoxInput.Text);
            }
        }
    }
}