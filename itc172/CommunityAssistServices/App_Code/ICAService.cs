﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICAService" in both code and config file together.
[ServiceContract]
public interface ICAService
{
    [OperationContract]
    List<string> GetCommunityServices();

    [OperationContract]
    List<ServiceGrant> GetGrants(string service);
}