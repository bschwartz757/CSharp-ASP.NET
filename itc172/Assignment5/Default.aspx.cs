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
        RegisterLoginServiceReference.VenueRegisterLoginClient vrlc = new RegisterLoginServiceReference.VenueRegisterLoginClient();
        //call the method
        int key = vrlc.Login(txtVenueLoginPasswordPlain.Text, txtVenueLoginUserName.Text);
        //check results
        if (key!=0)
        {
            Session["VenueKey"] = key;
            lblResult.Text = "You have successfully logged in";
        }
        else
        {
            lblResult.Text = "Login failed, please try again";
        }
    }
}