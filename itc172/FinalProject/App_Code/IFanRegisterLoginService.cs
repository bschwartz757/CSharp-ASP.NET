using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFanRegisterLoginService" in both code and config file together.
[ServiceContract]
public interface IFanRegisterLoginService
{
    [OperationContract]
    bool RegisterFan(Fan f, FanLogin fl);
    [OperationContract]
    int FanLogin(string password, string username);
}
