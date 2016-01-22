using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCFLabb1AddTwoNumbers
{
    /// <summary>
    /// Summary description for AddTwoNumbers
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AddTwoNumbers : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add2Numbers(string x, string y)
        {
            return int.Parse(x) + int.Parse(y);
        }
    }
}
