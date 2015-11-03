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
    protected void Button1_Click(object sender, EventArgs e)
    {
        LoginClass lc = new LoginClass(txtPassword.Text, txtUserName.Text);
        int key = lc.ValidateLogin();
        if(key != 0)
        {
            lblError.Text = "Sucessful Login";
            Session["userKey"] = key;
        }
        else 
        {
            lblError.Text = "Failed Login";
        }
    }
}