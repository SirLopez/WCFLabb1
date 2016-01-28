using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFLabb1Client.NameDayReference;

namespace WCFLabb1Client
{
    public partial class NameDays : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonResultDate_Click(object sender, EventArgs e)
        {
            var name = new NameDaySoapClient();
            if (TextBoxInput != null)
            {
                LabelResultDate.Text = name.DateDependingOnTheName(TextBoxInput.Text);
            }
        }
    }
}