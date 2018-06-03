using Client.CRMServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class ServicesInit
    {
        public static readonly CRMServiceClient CRMService = new CRMServiceClient();

    }
}
