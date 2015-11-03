using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            ShowTrackerEntities db = new ShowTrackerEntities();
            Fan f = new Fan();
            FanLogin fl = new FanLogin();
            fl.Fan = f;

            f.FanName = txtFirstName.Text + " " + txtLastName.Text;
            f.FanEmail = txtEmail.Text;
            f.FanDateEntered = DateTime.Now;

            fl.FanLoginUserName = txtUserName.Text;
            fl.FanLoginDateAdded = DateTime.Now;
            fl.FanLoginPasswordPlain = txtPassword.Text;

            KeyCode kc = new KeyCode();
            int code = kc.GetKeyCode();

            PasswordHash ph = new PasswordHash();
            Byte[] hashed = ph.HashIt(txtPassword.Text, code.ToString());

            fl.FanLoginRandom = code;
            fl.FanLoginHashed = hashed;

            db.Fans.Add(f);

            fl.Fan = f;
            db.FanLogins.Add(fl);

            db.SaveChanges();
            lblErrorSuccess.Text = "Reviewer Saved";
        }
        catch (Exception ex)
        {
            lblErrorSuccess.Text = ex.Message;
        }
    }
}