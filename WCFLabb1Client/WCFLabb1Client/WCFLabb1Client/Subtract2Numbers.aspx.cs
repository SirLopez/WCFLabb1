using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFLabb1Client.Subtract2NumbersReference;

namespace WCFLabb1Client
{
    public partial class Subtract2Numbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonResult_Click(object sender, EventArgs e)
        {
            var numbers = new Subtract2NumbersSoapClient();
            if (TextBoxNumber1.Text != null && TextBoxNumber2.Text != null)
                LabelResultSubstract.Text =
                    numbers.SubtractTwoNumbers(TextBoxNumber1.Text, TextBoxNumber2.Text).ToString();
        }
    }
}