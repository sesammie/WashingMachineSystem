﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Runtime.Serialization;

namespace WashSystem
{
    [DataContract]
    public class Database
    {
        private OleDbConnection connection;

        public Database()
        {
            string provider = "Provider=Microsoft.ACE.OLEDB.12.0";
            string path = @"C:\Users\Sam\Documents\GitHub\WashingMachineSystem\";
            string file = path + "/Kledingkast.accdb";

            string connectionString = provider + ";Data Source=" + file;
            connection = new OleDbConnection(connectionString);
        }

        public List<Clothes> GetAllClothes()
        {
            string sql = "SELECT ClothesId, ClothesType, WashTypes.WashType, Detergents.Detergent, Locations.Location, Maxtemp, Info, Weight FROM WashTypes, Clothes, Locations, Detergents WHERE Clothes.WashTypeId = WashTypes.WashTypeId AND Clothes.DetergentId = Detergents.DetergentId AND Clothes.LocationId = Locations.LocationID ";
            OleDbCommand command = new OleDbCommand(sql, connection);

            int id = 100;

            List<Clothes> clothes = new List<Clothes>();
            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["ClothesId"]);
                    string clothesType = Convert.ToString(reader["ClothesType"]);
                    string washTypes = Convert.ToString(reader["WashType"]);
                    string detergent = Convert.ToString(reader["Detergent"]);
                    string location = Convert.ToString(reader["Location"]);
                    int maxTemp = Convert.ToInt32(reader["Maxtemp"]);
                    string info = Convert.ToString(reader["Info"]);
                    int weight = Convert.ToInt32(reader["Weight"]);
                    clothes.Add(new Clothes(id, clothesType, washTypes, detergent, location, maxTemp, info, weight));
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
            return clothes;
        }

        public bool AddClothes(string clothesType, string info, int washType, int detergent, int location, int maxTemp, int weight)
        {

            string sql = "INSERT INTO Clothes (ClothesType, Info, WashTypeId, DetergentId, LocationId, MaxTemp, Weight) VALUES ('" + clothesType + "', '" + info + "', '" + washType + "', '" + detergent + "', '" + location + "', '" + maxTemp + "', '" + weight + "')";
            OleDbCommand command = new OleDbCommand(sql, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
    }
}
