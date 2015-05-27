using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashSystem
{
    public class Clothes
    {
        public int Id { get; private set; }
        public ClothesTypes ClothesType {get; private set;}
        public WashTypes WashType { get; private set; }
        public Detergents Detergent { get; private set; }
        public Locations Location { get; private set; }
        public int MaxTemp { get; private set; }
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
