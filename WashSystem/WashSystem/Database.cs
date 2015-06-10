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

        public List<Garments> GetAllGarments()
        {
            string sql = "SELECT Garments.Garment_Id, Programs.Name, Locations.Location, Colors.Color, Garments.MaxTemp, Garments.Weight FROM Garments, Locations, Programs, Colors WHERE Garments.Program_Id = Programs.Program_Id AND Garments.Color_Id = Colors.Color_Id AND Garments.Location_Id = Locations.Location_Id";
            OleDbCommand command = new OleDbCommand(sql, connection);

            int id, weight, maxTemp;
            string program, location;

            List<Garments> garmentList = new List<Garments>();
            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Garment_Id"]);
                    weight = Convert.ToInt32(reader["Weight"]);
                    maxTemp = Convert.ToInt32(reader["MaxTemp"]);
                    program = Convert.ToString(reader["Name"]);
                    location = Convert.ToString(reader["Location"]);

                    string color = Convert.ToString(reader["Color"]);
                    garmentList.Add(new Garments(id, program, location, maxTemp, color, weight));
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
            return garmentList;
        }

        public List<Programs> GetAllPrograms()
        {
            string sql = "SELECT Programs.Temp, Programs.NormalDuration, Programs.ShortDuration, Programs.MaxWeight, Programs.Name, Programs.Centrifuging FROM Programs";
            OleDbCommand command = new OleDbCommand(sql, connection);

            int temp, normalDuration, shortDuration, maxWeight, centrifuging;
            string name;

            List<Programs> ProgramList = new List<Programs>();
            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    name = Convert.ToString(reader["Name"]);
                    normalDuration = Convert.ToInt32(reader["NormalDuration"]);
                    shortDuration = Convert.ToInt32(reader["ShortDuration"]);
                    maxWeight = Convert.ToInt32(reader["MaxWeight"]);
                    temp = Convert.ToInt32(reader["Temp"]);
                    centrifuging = Convert.ToInt32(reader["Centrifuging"]);
                    ProgramList.Add(new Programs(name, normalDuration, shortDuration, temp, centrifuging, maxWeight));
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

            return ProgramList;
        }


        public bool AddGarment(Garments garment)
        {
            string sql = "INSERT INTO Garments (Garment_Id, Program_Id, Location_id, Color_Id, MaxTemp, Weight) SELECT " + garment.GarmentId + ", Programs.Program_Id, Locations.Location_Id, Colors.Color_Id, " + garment.MaxTemp + ", " + garment.Weight + " FROM Programs, Locations, Colors WHERE Colors.Color = '" + garment.Color + "' AND Locations.Location = '" + garment.Location + "' AND Programs.Name = '" + garment.Program + "'";
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

        public bool UpdateGarmentLocation(int garmentId, string newLocation)
        {
            string sql = "UPDATE Garments, Locations Set Garments.Location_Id = Locations.Location_Id WHERE Garments.Garment_Id = " + garmentId + " AND Locations.Location = '" + newLocation + "'";
            
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
