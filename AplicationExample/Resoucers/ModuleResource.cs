using AplicationExample.Resoucers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationExample.Resoucers
{
    internal class ModuleResource : IModuleResource
    {
        public string ServiceName1 => "ServiceExample1";

        public string ServiceName2 => "ServiceExample2";

        public string ServiceName3 => "ServiceExample3";
    }
}
