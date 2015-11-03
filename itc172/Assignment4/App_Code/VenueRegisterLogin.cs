using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "VenueRegisterLogin" in code, svc and config file together.
public class VenueRegisterLogin : IVenueRegisterLogin
{
    ShowTrackerEntities showTrackerDb = new ShowTrackerEntities();
    public bool RegisterVenue(Venue v, VenueLogin vl)
    {
        bool result = true;
        //put it all in  a try
        // you will want to disable the try catch
        //to troubleshoot errors.
        try
        {
            //set up the classes and methods to create
            //the hashed password

            PasswordHash phash = new PasswordHash();
            KeyCode keycode = new KeyCode();
            int key = keycode.GetKeyCode();
            byte[] hash = phash.HashIt(vl.VenueLoginPasswordPlain, key.ToString());

            Venue venue = new Venue();
            venue.VenueName = v.VenueName;
            venue.VenueAddress = v.VenueAddress;
            venue.VenueAgeRestriction = v.VenueAgeRestriction;
            venue.VenueCity = v.VenueCity;
            venue.VenueEmail = v.VenueEmail;
            venue.VenuePhone = v.VenuePhone;
            venue.VenueState = v.VenueState;
            venue.VenueWebPage = v.VenueWebPage;
            venue.VenueZipCode = v.VenueZipCode;
            venue.VenueDateAdded = DateTime.Now;
            showTrackerDb.Venues.Add(venue);

            VenueLogin venueLogin = new VenueLogin();
            venueLogin.Venue = venue;
            venueLogin.VenueLoginPasswordPlain = vl.VenueLoginPasswordPlain;
            venueLogin.VenueLoginRandom = key;
            venueLogin.VenueLoginUserName = vl.VenueLoginUserName;
            venueLogin.VenueLoginDateAdded = DateTime.Now;
            venueLogin.VenueLoginHashed = hash;
            showTrackerDb.VenueLogins.Add(venueLogin);

            showTrackerDb.SaveChanges();
        }
        catch
        {
            result = false;
        }
        return result;
    }

    public int Login(string pass, string username)
    {
        LoginClass login = new LoginClass(pass, username);
        int key = login.ValidateLogin();
        return key;
    }
}
