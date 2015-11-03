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
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //instantiate the service
        FanServiceReference.FanRegisterLoginServiceClient frlsc = new FanServiceReference.FanRegisterLoginServiceClient();
        //call the method
        int key = frlsc.FanLogin(txtFanLoginPasswordPlain.Text, txtFanLoginUserName.Text);
        //check results
        if (key != 0)
        {
            Session["FanKey"] = key;
            lblResult.Text = "You have successfully logged in";
        }
        else
        {
            lblResult.Text = "Login failed, please try again";
        }
    }
}