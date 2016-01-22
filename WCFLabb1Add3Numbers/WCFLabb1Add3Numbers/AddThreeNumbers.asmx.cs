using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCFLabb1Add3Numbers
{
    /// <summary>
    /// Summary description for AddThreeNumbers
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AddThreeNumbers : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add3Numbers(string x, string y, string z)
        {
            return int.Parse(x) + int.Parse(y) + int.Parse(z);
        }
    }
}
