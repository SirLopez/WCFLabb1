using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFLabb1Client.WeatherServiceReference;

namespace WCFLabb1Client
{
    public partial class WeatherForecast : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGetWeather_Click(object sender, EventArgs e)
        {
            var wr = new WebService1SoapClient();
            LabelResultWeather.Text = wr.WeatherForecast();
        }
    }
}