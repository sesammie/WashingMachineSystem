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
        
        public List<Garments> GermantList { get; private set; }
        Database database;
        Sort sort;
        
        public Service1()
        {
            GermantList = new List<Garments>();
            database = new Database();
            sort = new Sort();
        }

        public List<Garments> GetAllGermants()
        {
            return database.GetAllGarments();
        }

        public List<Programs> GetAllPrograms()
        {
            return database.GetAllPrograms();
        }

        public bool AddGermant()
        {
            return database.AddGarment(new Garments(20, "Dark/Jeans", "LaundryBasket", 45, "Black", 185));
        }

        public bool UpdateGermantLocation()
        {
            return database.UpdateGarmentLocation(14, "LaundryBasket");
        }
        public string SortGarments()
        {
            return sort.SortGarments();
        }
    }
}

