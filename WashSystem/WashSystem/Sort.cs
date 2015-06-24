using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WashSystem
{
    public struct Wash
    {
        public List<Garments> Garmentlist;
        public Programs program;
    }

    public class Sort
    {
        Database database = new Database();
        int[] weight = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        string[] programs = new string[] { "White/coloreds", "EasyCare", "Delicates", "Woolwax", "Automatic_Extra", "Dark/Jeans", "Shirts", "Silk" };
        //int maxDiferenceWeight = 500;
        int tempWeight = 0;
        int temp = 100;
        Wash wash;


        public Wash SortGarments()
        {
            List<Garments> garmentsForProgram = new List<Garments>();

            foreach (Garments garment in database.GetAllGarments())
            {
                if (garment.Location == "LaundryBasket")
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (garment.Program == programs[i])
                        {
                            weight[i] += garment.Weight;
                        }
                    }
                }
            }

            foreach (Programs program in database.GetAllPrograms())
            {
                for (int i = 0; i < 8; i++)
                {
                    if (program.Name == programs[i])
                    {
                        if (weight[i] > tempWeight && weight[i] > 235)
                        {
                            tempWeight = weight[i];
                            temp = i;
                        }
                    }
                }
            }
            foreach (Garments garment in database.GetAllGarments())
            {
                if (temp != 100)
                {
                    if (garment.Program == programs[temp] && garment.Location == "LaundryBasket")
                    {
                        garmentsForProgram.Add(garment);
                    }
                }
            }
            foreach (Programs program in database.GetAllPrograms())
            {
                if (temp != 100)
                {
                    if (program.Name == programs[temp])
                    {
                        wash.program = program;
                    }
                }
            }

            wash.Garmentlist = garmentsForProgram;

            if (temp == 100)
            {
                wash.Garmentlist = null;
                wash.program = null;
            }

            return wash;
        }
    }
}
