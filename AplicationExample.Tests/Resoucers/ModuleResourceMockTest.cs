using AplicationExample.Resoucers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationExample.Tests.Resoucers
{
    public class ModuleResourceMockTest : IModuleResource
    {
        public string ServiceName1 => "ServiceName1Mock";

        public string ServiceName2 => "ServiceName2Mock";

        public string ServiceName3 => "ServiceName3Mock";
    }
}
