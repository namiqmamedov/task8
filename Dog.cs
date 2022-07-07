using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Dog

    {
        public string name;
        public string color;
        public byte age;


        public Dog()
        {
            Console.WriteLine("Default constructor worked");
        }
        public Dog(string n, string c, byte a)
        {
            name = n;
            color = c;
            age = a;

            Console.WriteLine("Custom constructor worked");
        }

        public string GetDetails()
        {
            return $"{name} {color} {age}";
        }


    }
}
