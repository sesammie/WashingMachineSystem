using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WashSystem
{
    [DataContract]
    public class Garments
    {
        [DataMember]
        public int GarmentId { get; private set; }
        [DataMember]
        public string Program { get; private set; }
        [DataMember]
        public string Location { get; private set; }
        [DataMember]
        public int MaxTemp { get; private set; }
        [DataMember]
        public string Color { get; private set; }
        [DataMember]
        public int Weight { get; private set; }

        public Garments(int garmentId, string program, string location, int maxTemp, string color, int weight)
        {
            GarmentId = garmentId;
            Program = program;
            Location = location;
            MaxTemp = maxTemp;
            Color = color;
            Weight = weight;
        }

    }

   
}
