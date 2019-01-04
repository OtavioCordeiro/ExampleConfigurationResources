using AplicacaoExample.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace AplicacaoExample.Modules
{
    public class OldExampleModule
    {
        public void Load()
        {
            var applicationUrl = ConfigurationManager.AppSettings["appUrl"];

            var apiUrl = ConfigurationManager.AppSettings["apiUrl"];
            Uri apiUri = new Uri(apiUrl);

            Resolve<IService>("ServiceExample1");
            Resolve<IService>("ServiceExample2");
            Resolve<IService>("ServiceExample3");
            Resolve<IService>("ServiceExample4");
            Resolve<IService>("ServiceExample1");
            Resolve<IService>("ServiceExample3");
        }

        private void Resolve<T>(string dado)
        {
            // faz alguma coisa
        }
    }
}
