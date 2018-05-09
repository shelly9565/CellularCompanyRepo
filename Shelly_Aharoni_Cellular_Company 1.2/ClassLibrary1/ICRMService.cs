using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICRMService" in both code and config file together.
    [ServiceContract]
    public interface ICRMService
    {
        [OperationContract]
        void DoWork();
    }

}
