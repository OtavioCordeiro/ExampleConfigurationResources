using AplicationExample.Resoucers.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationExample.Resoucers
{
    internal class ConfigurationResource : IConfigurationResource
    {
        string IConfigurationResource.AppUrl => ConfigurationManager.AppSettings["AppUrl"];

        Uri IConfigurationResource.ApiUri => new Uri(ConfigurationManager.AppSettings["ApiUrl"]);

        public string ExampleDbConnectionString => ConfigurationManager.ConnectionStrings["ExampleDb"].ConnectionString;
    }
}
