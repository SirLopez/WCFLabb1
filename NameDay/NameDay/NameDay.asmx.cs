using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace NameDay
{
    /// <summary>
    /// Summary description for NameDay
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NameDay : WebService
    {

        [WebMethod]
        public string DateDependingOnTheName(string input)
        {
            var dateName = File.ReadAllLines(@"C:\EC\2WIN14\Distribuerade system med WCF (20p)\Projekt\WCFLabb1repo\NameDay\NameDay\Namnsdagar.txt");

            var theDate = "";

            foreach (var x in dateName)
            {
                var name = x.Split(' ', ',');
                if (name.Contains(input))
                {
                    theDate = name[0] + "/" + name[1];
                }
                else
                {
                    return "Sorry, that name isn´t celebrated, or you misspelled it, try again.";
                }
            }
            return theDate;
        }
    }
}
