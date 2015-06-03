using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WashSystem
{
    [DataContract]
    public class Program
    {
        [DataMember]
        public string Name { get; private set; }
        [DataMember]
        public int Duration { get; private set; }
        [DataMember]
        public Detergents Detergent { get; private set; }
        [DataMember]
        public int Temperature { get; private set; }
        [DataMember]
        public int Centrifuging { get; private set; }

        public Program(string name, int duration, Detergents detergent, int temperature, int centrifuging)
        {
            Name = name;
            Duration = duration;
            Detergent = detergent;
            Temperature = temperature;
            Centrifuging = centrifuging;
        }
    }
}
