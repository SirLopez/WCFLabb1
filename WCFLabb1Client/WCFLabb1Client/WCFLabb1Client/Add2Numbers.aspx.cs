using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFLabb1Client.Add2NumbersReference;

namespace WCFLabb1Client
{
    public partial class Add2Numbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonResult_Click(object sender, EventArgs e)
        {
            var numbers = new AddTwoNumbersSoapClient();
            if (TextBoxNumberOne != null && TextBoxNumberTwo != null)
                LabelResultAddTwoNumbers.Text = numbers.Add2Numbers(TextBoxNumberOne.Text, TextBoxNumberTwo.Text).ToString();
            //No check if input is a string, dont need for the task
        }
    }
}