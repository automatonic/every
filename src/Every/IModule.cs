using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Every
{
    /// <summary>
    /// Implement this interface (with a parameterless constructor) to indicate a runnable every module
    /// </summary>
    public interface IModule : INinjectModule
    {

    }
}
