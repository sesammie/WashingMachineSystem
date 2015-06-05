using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WashSystem
{
    [DataContract]
    public class Garment
    {
        [DataMember]
        public int GarmentId { get; private set; }
        [DataMember]
        public string ClothesType {get; private set;}
        [DataMember]
        public string WashType { get; private set; }
        [DataMember]
        public string Detergent { get; private set; }
        [DataMember]
        public string Location { get; private set; }
        [DataMember]
        public int MaxTemp { get; private set; }
        [DataMember]
        public string Info { get; private set; }
        [DataMember]
        public int Weight { get; private set; }

        public Garment(int garmentId, string clothesTypes, string washTypes, string detergents, string location, int maxTemp, string info, int weight)
        {
            GarmentId = garmentId;
            ClothesType = clothesTypes;
            WashType = washTypes;
            Detergent = detergents;
            Location = location;
            MaxTemp = maxTemp;
            Info = info;
            Weight = weight;
        }

    }

   
}
