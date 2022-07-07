using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cat
    {
        public string Name;
        public string Color;
        public byte Age;

        public Cat()
        {
            Console.WriteLine("Default constructor worked");
        }

        public Cat(string n, string c, byte a)
        {
            Name = n;
            Color = c;
            Age = a;

            Console.WriteLine("Custom constructor worked");
        }   
        public string GetDetails()
        {
            return $"{Name} {Color} {Age}";
        }
    }
}
