using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FanServiceReference;

public partial class FanRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        FanRegisterLoginServiceClient frlsc = new FanRegisterLoginServiceClient();
        Fan f = new Fan();
        f.FanName = txtFanName.Text;
        f.FanEmail = txtFanEmail.Text;
        f.FanDateEntered = DateTime.Now;

        FanLogin fl = new FanLogin();
        fl.FanLoginUserName = txtFanLoginUsername.Text;
        fl.FanLoginPasswordPlain = txtFanLoginPasswordPlain.Text;
        fl.FanLoginDateAdded = DateTime.Now;


        bool result = frlsc.RegisterFan(f, fl);

        if (result)
            lblResult.Text = "You have been successfully registered";
        else
            lblResult.Text = "Registration failed";
    }
}