using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCFLabb1RazzieOfTheYear
{
    /// <summary>
    /// Summary description for RazzieOfTheYear
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RazzieOfTheYear : WebService
    {

        [WebMethod]
        public string RazzieYear(string input)
        {
            var year =
                File.ReadAllLines(
                    @"C:\EC\2WIN14\Distribuerade system med WCF (20p)\Projekt\WCFLabb1repo\WCFLabb1RazzieOfTheYear\WCFLabb1RazzieOfTheYear\razzies.txt");

            var title = "";

            foreach (var y in year)
            {
                var movie = y.Split(':');
                if (movie.Contains(input))
                {
                    title += movie[1];
                }
            }
            return "Razzie of the year: " + title;
        }
    }
}
