using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
   
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    public class WebService1 : System.Web.Services.WebService
    {
       
        [WebMethod]
        public String CalculterDescription()
        {
            return "This is web services calcultor. which contain the function of calculator. 1.sum\n 2.add\n 3.Multiply\n 4.Divide";
        }
        
        [WebMethod]
        public int Add(int num1, int num2)
        {
            return num1+num2;
        }
        [WebMethod]
        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        [WebMethod]
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        [WebMethod]
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
