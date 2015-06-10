using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WashSystem
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Programs> GetAllPrograms();
        [OperationContract]
        bool SendReceivedString(string x, string Location);
        [OperationContract]
        List<Garments> UpdateList(string location);
        [OperationContract]
        Wash GetWash();


    }   
}
