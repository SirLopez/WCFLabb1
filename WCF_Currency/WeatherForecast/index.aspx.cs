using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeatherForecast.WatherServiceReference;

namespace WeatherForecast
{
    public partial class index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonResult_Click(object sender, EventArgs e)
        {
            var client = new WeatherSoapClient("WeatherSoap");

            WeatherReturn result = client.GetCityWeatherByZIP(TextBox1.Text);
            if (result.Success)
            {
                LabelCity.Text = result.City;
                LabelState.Text = result.State;
                LabelTemperature.Text = result.Temperature;
                LabelWind.Text = result.Wind;
            }
            else
            {
                LabelCity.Text = "Couldn´t be retrieved";
                LabelState.Text = "Couldn´t be retrieved";
                LabelTemperature.Text = "Couldn´t be retrieved";
                LabelWind.Text = "Couldn´t be retrieved";
            }
        }
    }
}