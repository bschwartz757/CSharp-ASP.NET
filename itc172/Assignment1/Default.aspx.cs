using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        DateTime birthdate;
        string name;

        bool goodDate = DateTime.TryParse(txtDate.Text, out birthdate);

        if(goodDate)
        {
            DateTime today = DateTime.Now;
            int month;
            int years = today.Year - birthdate.Year;
            if(today.Month>birthdate.Month)
            {
                month = 12 - birthdate.Month;
            }
            else
            {
                month = birthdate.Month - today.Month;
                years-=1;
            }
            lblResult.Text = "You are " + years.ToString() + " years, " + month.ToString() + " months, ";
        }
        else
        {
            lblResult.Text = "Enter a valid date";
            txtDate.Text = "";
            txtDate.Focus();
        }
    }
}