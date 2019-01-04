using AplicacaoExample.Modules;
using AplicationExample.Resoucers;
using AplicationExample.Resoucers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            OldExampleModule oldExampleModule = new OldExampleModule();
            oldExampleModule.Load();

            // Injeção de dependencia
            IConfigurationResource configurationResource = new ConfigurationResource();
            IModuleResource moduleResource = new ModuleResource();

            NewExampleModule newExampleModule = new NewExampleModule(configurationResource, moduleResource);
            newExampleModule.Load();


        }
    }
}
