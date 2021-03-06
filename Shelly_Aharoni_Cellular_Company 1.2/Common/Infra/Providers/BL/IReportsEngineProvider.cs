﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infra.Providers.BL
{
    public interface IReportsEngineProvider
    {
        IEnumerable<string> MostValuableClients();
        IEnumerable<string> MostCallingToCenterClients();

    }
}
