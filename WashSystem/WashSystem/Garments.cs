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
        public string GarmentId { get; private set; }
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
        [DataMember]
        public string Info { get; private set; }

        public Garments(string garmentId, string program, string location, int maxTemp, string color, int weight, string info)
        {
            GarmentId = garmentId;
            Program = program;
            Location = location;
            MaxTemp = maxTemp;
            Color = color;
            Weight = weight;
            Info = info;

        }

        public override string ToString()
        {
            return GarmentId + " - " + Program + " - " + Location + " - " + MaxTemp.ToString() + " - " + Color + " - " + Weight.ToString();
        }

    }

   
}
