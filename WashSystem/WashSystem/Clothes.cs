using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WashSystem
{
    [DataContract]
    public class Clothes
    {
        [DataMember]
        public int Id { get; private set; }
        [DataMember]
        public ClothesTypes ClothesType {get; private set;}
        [DataMember]
        public WashTypes WashType { get; private set; }
        [DataMember]
        public Detergents Detergent { get; private set; }
        [DataMember]
        public Locations Location { get; private set; }
        [DataMember]
        public int MaxTemp { get; private set; }
        [DataMember]
        public string Info { get; private set; }

        public Clothes(int id, ClothesTypes clothesTypes, WashTypes washTypes, Detergents detergents, Locations location, int maxTemp, string info)
        {
            Id = id;
            ClothesType = clothesTypes;
            WashType = washTypes;
            Detergent = detergents;
            Location = location;
            MaxTemp = maxTemp;
            Info = info;
        }

    }

   
}
