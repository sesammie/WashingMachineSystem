using System;
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
            string sql = "SELECT * FROM Clothes";
            OleDbCommand command = new OleDbCommand(sql, connection);

            List<Clothes> clothes = new List<Clothes>();
            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Id"]);
                    string clothesType = Convert.ToString(reader["ClothesType"]);
                    string washTypes = Convert.ToString(reader["WashType"]);
                    string detergent = Convert.ToString(reader["detergent"]);
                    string location = Convert.ToString(reader["location"]);
                    int maxTemp = Convert.ToInt32(reader["Maxtemp"]);
                    string info = Convert.ToString(reader["info"]);
                    clothes.Add(new Clothes(id, clothesType, washTypes, detergent, location, maxTemp, info));
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
    }
}
