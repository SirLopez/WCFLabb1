using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFLabb1Client.MovieOfTheYearServiceReference;

namespace WCFLabb1Client
{
    public partial class MovieOfTheYear : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonResult_Click(object sender, EventArgs e)
        {
            var year = new MovieYearSoapClient();
            if (TextBoxInputYear != null)
            {
                LabelResultMovie.Text = year.MovieOfTheYear(TextBoxInputYear.Text);
            }
        }
    }
}