using System;
using AplicacaoExample.Modules;
using AplicationExample.Resoucers.Interfaces;
using AplicationExample.Tests.Resoucers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AplicationExample.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            // Injeção de dependencia
            IConfigurationResource configurationResource = new ConfigurationResourceTest();
            IModuleResource moduleResource = new ModuleResourceTest();

            NewExampleModule newExampleModule = new NewExampleModule(configurationResource, moduleResource);
            newExampleModule.Load();
        }

        [TestMethod]
        public void LoadOldExample()
        {
            OldExampleModule oldExampleModule = new OldExampleModule();
            oldExampleModule.Load();
        }
    }
}
