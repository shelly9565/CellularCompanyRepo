﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server.Infra
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOptimalPackageService" in both code and config file together.
    [ServiceContract]
    public interface IOptimalPackageService
    {
        [OperationContract]
        void DoWork();
    }
}
