using AplicacaoExample.Services;
using AplicationExample.Resoucers.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace AplicacaoExample.Modules
{
    public class NewExampleModule
    {
        IConfigurationResource _configurationResource;
        IModuleResource _moduleResource;

        public NewExampleModule(IConfigurationResource configurationResource, IModuleResource moduleResource)
        {
            _configurationResource = configurationResource;
            _moduleResource = moduleResource;
        }

        public void Load()
        {
            var applicationUrl = _configurationResource.AppUrl;
            var apiUrl = _configurationResource.ApiUri;


            Resolve<IService>(_moduleResource.ServiceName1);
            Resolve<IService>(_moduleResource.ServiceName2);
            Resolve<IService>(_moduleResource.ServiceName3);
            Resolve<IService>(_moduleResource.ServiceName2);
            Resolve<IService>(_moduleResource.ServiceName1);
            Resolve<IService>(_moduleResource.ServiceName3);
        }

        private void Resolve<T>(string dado)
        {
            // faz alguma coisa
        }
    }
}
