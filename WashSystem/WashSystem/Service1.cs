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
        public string x()
        {
            return "x";
        }
    }
}
