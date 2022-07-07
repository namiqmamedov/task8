using System;
namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            //var student1 = new
            //{
            //    name = "Eli",
            //    surname = "Kazimov",
            //    age = 21
            //};
            //var student2 = new
            //{
            //    name = "Huseyn",
            //    surname = "Ceferli",
            //    age = 22
            //};
            //Student student1 = new Student();
            //student1.name = "Namiq";
            //student1.surname = "Memmedov";
            //student1.age = 19;

            //Student student2 = new Student();
            //student2.name = "Eli";
            //student2.surname = "Kazimov";
            //student2.age = 22;

            //Console.WriteLine(student1.GetDetails());
            //Console.WriteLine(student2.GetDetails());



            Dog animals1 = new Dog("Alfred", "Black", 2);

            Cat animals2 = new Cat("Tom", "White", 2);
            //animals1.name = "Alfred";
            //animals1.color = "Black";
            //animals1.age = 2;

            Console.WriteLine(animals1.GetDetails());
            Console.WriteLine(animals2.GetDetails());

            







        }
    }


}




























