using AplicationExample.Resoucers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationExample.Tests.Resoucers
{
    public class ConfigurationResourceTest : IConfigurationResource
    {
        public string AppUrl => "appUrlMock";

        public Uri ApiUri => new Uri("http://apimock.com");

        public string ExampleDbConnectionString => "connectionStringMock";
    }
}
