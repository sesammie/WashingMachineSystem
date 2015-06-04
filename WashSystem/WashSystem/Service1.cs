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
        
        public List<Program> ProgramList { get; private set; }
        public List<WashTypes> WashTypesList {get; private set;}
        public List<Detergents> DetergentsList { get; private set; }
        Database database = new Database(); 

        
        public Service1()
        {
            ProgramList = new List<Program>();
            WashTypesList = new List<WashTypes>();
            DetergentsList = new List<Detergents>();

            ProgramList.Add(new Program("Natural", 120, Detergents.Natural, 120, 800, 100));
            ProgramList.Add(new Program("White", 30, Detergents.White, 120, 8000, 200));
            ProgramList.Add(new Program("Colors", 60, Detergents.Colors, 120, 8000, 300));

            WashTypesList.Clear();
            foreach (WashTypes washType in Enum.GetValues(typeof(WashTypes)))
            {
                WashTypesList.Add(washType);
            }
            DetergentsList.Clear();
            foreach (Detergents detergent in Enum.GetValues(typeof(Detergents)))
            {
                DetergentsList.Add(detergent);
            }

        }
        public List<Program> GetProgramList()
        {
            return ProgramList;
        }
        public List<WashTypes> GetWashTypeList()
        {
            return WashTypesList;
        }
        public List<Detergents> GetDetergentList()
        {
            return DetergentsList;
        }
        public List<Clothes> GetClothesList()
        {
            return database.GetAllClothes();
        }
        public bool AddClothes()
        {
            return database.AddClothes("Pants", "sf", 1, 1, 50, 12, 250);
        }


      //  public 
    }
}

