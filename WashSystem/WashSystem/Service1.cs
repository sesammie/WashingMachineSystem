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
        public List<Garments> GarmentList { get; private set; }
        Database database;
        Sort sort;
        
        public Service1()
        {
            GarmentList = new List<Garments>();
            database = new Database();
            sort = new Sort();
        }

        public List<Garments> GetAllGarments()
        {
            return database.GetAllGarments();
        }

        public List<Programs> GetAllPrograms()
        {
            return database.GetAllPrograms();
        }

        public string GetServerName()
        {
            return "WashSystem";
        }

        public bool SendReceivedString(string garmentId, string location )
        {
            foreach (Garments garments in database.GetAllGarments())
            {
                if (garments.GarmentId == garmentId)
                {
                    if (location == garments.Location)
                    {
                        location = "Elsewhere";
                    }

                    database.UpdateGarmentLocation(garmentId, location);
                    break;
                }
            }

            return true;
        }

        public List<Garments> UpdateList(string location)
        {
            GarmentList.Clear();

            foreach (Garments garment in database.GetAllGarments())
            {
                if (garment.Location == location)
                {
                    GarmentList.Add(garment);
                }
            }

            return GarmentList;
        }

        public Wash GetWash()
        {
            return sort.SortGarments();
        }

    }
}

