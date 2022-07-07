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



            //Dog animals1 = new Dog("Alfred", "Black", 2);

            //Cat animals2 = new Cat("Tom", "White", 2);


            //Console.WriteLine(animals1.GetDetails());
            //Console.WriteLine(animals2.GetDetails());

            //Mercedes car1 = new Mercedes("MERCEDES", "55000$", "250km/h", "Gray");
            //BMW car2 = new BMW("BMW", "60000$", "300km/h", "Black");

            //Console.WriteLine(car1.GetDetails());
            //Console.WriteLine(car2.GetDetails());


            Cars Mercedes = new Cars();
            Mercedes.Brand = "Mercedes";
            Mercedes.Price = "55000$";
            Mercedes.Speed = "250km/h";
            Mercedes.Color = "Gray";
            Console.WriteLine($"{Mercedes.Brand}  {Mercedes.Price}  {Mercedes.Speed}  {Mercedes.Color}");

            Cars BMW = new Cars();
            BMW.Brand = "BMW";
            BMW.Price = "60000$";
            BMW.Speed = "300km/h";
            BMW.Color = "Black";
            Console.WriteLine($"{BMW.Brand}  {BMW.Price}  {BMW.Speed}  {BMW.Color}");












        }
    }


}




























