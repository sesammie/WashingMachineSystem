using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WashSystem
{
    [DataContract]
    public class Programs
    {
        [DataMember]
        public string Name { get; private set; }
        [DataMember]
        public int NormalDuration { get; private set; }
        [DataMember]
        public int ShortDuration { get; private set; }
        [DataMember]
        public int Temperature { get; private set; }
        [DataMember]
        public int Centrifuging { get; private set; }
        [DataMember]
        public int MaxWeight { get; private set; }

        public Programs(string name, int normalDuration, int shortDuration,int temperature, int centrifuging, int maxWeight)
        {
            Name = name;
            NormalDuration = normalDuration;
            ShortDuration = ShortDuration;
            Temperature = temperature;
            Centrifuging = centrifuging;
            MaxWeight = maxWeight;
        }
    }
}
