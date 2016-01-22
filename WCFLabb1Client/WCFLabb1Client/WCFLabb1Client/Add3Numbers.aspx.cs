using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFLabb1Client.Add3NumbersReference;

namespace WCFLabb1Client
{
    public partial class Add3Numbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonResultAdd3_Click(object sender, EventArgs e)
        {
            var numbers = new AddThreeNumbersSoapClient();
            if (TextBoxNumber1.Text != null && TextBoxNumber2.Text != null && TextBoxNumber3.Text != null)
                LabelResultAdd3.Text =
                    numbers.Add3Numbers(TextBoxNumber1.Text, TextBoxNumber2.Text, TextBoxNumber3.Text).ToString();
        }
    }
}