using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "http://MyCompany.com")]
    public interface IBasicMath
    {
        [OperationContract]
        int Add(int x, int y);

        // TODO: Add your service operations here
    }


}
