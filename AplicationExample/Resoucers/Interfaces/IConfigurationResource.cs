using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationExample.Resoucers.Interfaces
{
    public interface IConfigurationResource
    {
        string AppUrl { get; }

        Uri ApiUri { get; }

        string ExampleDbConnectionString { get; }
    }
}
