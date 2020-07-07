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
            Car car = new Car("c123", "shit", 1, 100500.00m, 1982);
            
            Phone phone = new Phone("f123", "sucks", 10, 100501.01m);


            Console.WriteLine($"Phone ID:\t\t{phone.ID}");
            Console.WriteLine($"Phone moder:\t\t{phone.Name}");
            Console.WriteLine($"Amount of phone(s):\t{phone.Amount}");
            Console.WriteLine($"Price $:\t\t{phone.Price}");
            Console.WriteLine();
            Console.WriteLine($"Car IDr:\t\t{car.ID}");
            Console.WriteLine($"Car moder:\t\t{car.Name}");
            Console.WriteLine($"Year of production:\t{car.ProductionYear}");
            Console.WriteLine($"Amount of car(s):\t{car.Amount}");
            Console.WriteLine($"Price $:\t\t{car.Price}");
            Console.ReadKey();
        }
    }
}
