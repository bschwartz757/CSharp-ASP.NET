using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FanRegisterLoginService" in code, svc and config file together.
public class FanRegisterLoginService : IFanRegisterLoginService
{
    ShowTrackerEntities showTrackerDb = new ShowTrackerEntities();
    public bool RegisterFan(Fan f, FanLogin fl)
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
            byte[] hash = phash.HashIt(fl.FanLoginPasswordPlain, key.ToString());

            Fan fan = new Fan();
            fan.FanName = f.FanName;
            fan.FanEmail = f.FanEmail;
            fan.FanDateEntered = DateTime.Now;
            showTrackerDb.Fans.Add(fan);

            FanLogin fanLogin = new FanLogin();
            fanLogin.Fan = fan;
            fanLogin.FanLoginUserName = fl.FanLoginUserName;
            fanLogin.FanLoginPasswordPlain = fl.FanLoginPasswordPlain;
            fanLogin.FanLoginRandom = key;
            fanLogin.FanLoginHashed = hash;
            fanLogin.FanLoginDateAdded = DateTime.Now;
            showTrackerDb.FanLogins.Add(fanLogin);

            showTrackerDb.SaveChanges();
        }
        catch
        {
            result = false;
        }
        return result;
    }

    public int FanLogin(string pass, string username)
    {
        LoginClass login = new LoginClass(pass, username);
        int key = login.ValidateLogin();
        return key;
    }
}