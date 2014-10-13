using NuGet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Every
{
    [ServiceContract(Namespace = "http://github.com/automatonic/every/management")]
    public interface IManagementService
    {
        [OperationContract]
        void InstallPackage(string packageName, SemanticVersion version);
    }
}
