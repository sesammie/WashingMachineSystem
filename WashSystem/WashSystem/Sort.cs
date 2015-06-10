using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WashSystem
{
    public class Sort
    {
        Database database = new Database();
        int[] numbers = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] weight = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        string[] programs = new string[] { "White/coloreds", "EasyCare", "Delicates", "Woolwax", "Automatic_Extra", "Dark/Jeans", "Shirts", "Silk" };
        int maxDiferenceWeight = 500;
        int temp = 100;

        public string SortGarments()
        {
            foreach (Garments garment in database.GetAllGarments())
            {
                if (garment.Location == "LaundryBasket")
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (garment.Program == programs[i])
                        {
                            weight[i] += garment.Weight;
                            numbers[i] += 1;
                        }
                    }
                }
            }

            foreach (Programs program in database.GetAllPrograms())
            {
                for (int i = 0; i < 8; i++ )
                {
                    if (program.Name == programs[i])
                    {
                            // gewicht moet lager zijn dan maxgewicht maar mag 500 gram minder zijn
                        if ((weight[i] + maxDiferenceWeight > program.MaxWeight * 1000) && (weight[i] + maxDiferenceWeight < program.MaxWeight * 1000 + maxDiferenceWeight))
                        {
                            temp = i; 
                        }
                    }
                }
            }


                return programs[temp];
        }
    }
}
