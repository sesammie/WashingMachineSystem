using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashSystem
{
    public class Program
    {
        public string Name { get; private set; }
        public int Duration { get; private set; }
        public Detergents Detergent { get; private set; }
        public int Temperature { get; private set; }
        
        public Program(string name, int duration, Detergents detergent, int temperature)
        {
            Name = name;
            Duration = duration;
            Detergent = detergent;
            Temperature = temperature;
        }
    }
}
