using Microsoft.VisualBasic;
using System;

namespace InetStoreAccounting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine(things.Name);
            //Console.ReadKey();
            Car car = new Car();
            car.Amount = 1;
            car.Name = "shit";
            car.Price = 100500.00m;
            car.ProductionYear = 1982;

            Phone phone = new Phone();
            phone.Amount = 10;
            phone.Name = "sucks";
            phone.Price = 100501.01m;

            Console.WriteLine($"Phone moder:\t\t{phone.Name}");
            Console.WriteLine($"Amount of phone(s):\t{phone.Amount}");
            Console.WriteLine($"Price $:\t\t{phone.Price}");
            Console.WriteLine();
            Console.WriteLine($"Car moder:\t\t{car.Name}");
            Console.WriteLine($"Year of production:\t{car.ProductionYear}");
            Console.WriteLine($"Amount of car(s):\t{car.Amount}");
            Console.WriteLine($"Price $:\t\t{car.Price}");
            Console.ReadKey();
        }
    }
}
