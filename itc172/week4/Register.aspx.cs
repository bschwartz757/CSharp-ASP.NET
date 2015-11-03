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
        try{
            BookReviewDbEntities db = new BookReviewDbEntities();
            Reviewer r = new Reviewer();
            r.ReviewerLastName = txtLastName.Text;
            r.ReviewerFirstName = txtFirstName.Text;
            r.ReviewerEmail = txtEmail.Text;
            r.ReviewerUserName = txtUserName.Text;
            r.ReviewerDateEntered = DateTime.Now;
            r.ReviewPlainPassword = txtPassword.Text;

            KeyCode kc = new KeyCode();
            int code = kc.GetKeyCode();

            PasswordHash ph = new PasswordHash();
            Byte[] hashed = ph.HashIt(txtPassword.Text, code.ToString());

            r.ReviewerKeyCode = code;
            r.ReviewerHashedPass = hashed;

            db.Reviewers.Add(r);

            CheckinLog c = new CheckinLog();
            c.CheckinDateTime = DateTime.Now;
            c.Reviewer = r;
            db.CheckinLogs.Add(c);

            db.SaveChanges();
            lblErrorSuccess.Text = "Reviewer Saved";
            }
        catch(Exception ex)
         {
            lblErrorSuccess.Text = ex.Message;
         }
    }
}