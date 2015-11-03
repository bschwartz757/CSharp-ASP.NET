using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegisterLoginServiceReference;

public partial class VenueRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        VenueRegisterLoginClient vrlc = new VenueRegisterLoginClient();
        Venue v = new Venue();
        v.VenueName = txtVenueName.Text;
        v.VenueAddress = txtVenueAddress.Text;
        v.VenueCity = txtVenueCity.Text;
        v.VenueState = txtVenueState.Text;
        v.VenueZipCode = txtVenueZipCode.Text;
        v.VenuePhone = txtVenuePhone.Text;
        v.VenueEmail = txtVenueEmail.Text;
        v.VenueWebPage = txtVenueWebPage.Text;
        v.VenueAgeRestriction = int.Parse(txtVenueAgeRestriction.Text);
        v.VenueDateAdded = DateTime.Now;


        VenueLogin vl = new VenueLogin();
        vl.VenueLoginUserName = txtVenueLoginUsername.Text;
        vl.VenueLoginPasswordPlain = txtConfirm.Text;
        vl.VenueLoginDateAdded = DateTime.Now;


        bool result = vrlc.RegisterVenue(v, vl);

        if (result)
            lblResult.Text = "You have been successfully registered";
        else
            lblResult.Text = "Registration failed";
    }
}