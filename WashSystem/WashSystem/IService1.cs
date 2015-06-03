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
        List<Program> GetProgramList();
        [OperationContract]
        List<WashTypes> GetWashTypeList();
        [OperationContract]
        List<Detergents> GetDetergentList();
    }   
}
