using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cars
    {
        public string Brand;
        public string Price;
        public string Color;
        public string Speed;

        public Cars()
        {
            Console.WriteLine("Default constructor worked");
        }
        
        public Cars(string b, string p, string c, string s)
        {
            Brand = b;
            Price = p;
            Color = c;
            Speed = s; 

            Console.WriteLine("Custom constructor worked");
        }

        public string GetDetails()
        {
            return $"{Brand} {Price} {Color} {Speed}";
        }
    }
}
