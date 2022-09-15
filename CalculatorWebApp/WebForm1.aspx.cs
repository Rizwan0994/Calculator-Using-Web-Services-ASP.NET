using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            CalculatorService.WebService1SoapClient addService = new CalculatorService.WebService1SoapClient();
           int result= addService.Add(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text));
            lblResult.Text = result.ToString();
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            CalculatorService.WebService1SoapClient subService = new CalculatorService.WebService1SoapClient();
            int result = subService.Subtract(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text));
            lblResult.Text = result.ToString();
        }

        protected void btnMul_Click(object sender, EventArgs e)
        {
            CalculatorService.WebService1SoapClient mulService = new CalculatorService.WebService1SoapClient();
            int result = mulService.Multiply(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text));
            lblResult.Text = result.ToString();
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            CalculatorService.WebService1SoapClient divService = new CalculatorService.WebService1SoapClient();
            int result = divService.Divide(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text));
            lblResult.Text = result.ToString();
        }
    }
}