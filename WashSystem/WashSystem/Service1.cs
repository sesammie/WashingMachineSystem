using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WashSystem
{
    public class Service1 : IService1
    {
        public ClothesTypes x(Clothes clothes)
        {
            return clothes.ClothesType;
        }
    }
}
//    [ServiceContract(Namespace = "MyWebshopContract")]
//    public interface IWebshop
//    {
//        [OperationContract]
//        Program Program1();
//        [OperationContract]
//        Program Program2();
//        [OperationContract]
//        Program Program3();
//        [OperationContract]
//        Program Program4();
//        [OperationContract]
//        bool AddClothes();
//    }

//}
