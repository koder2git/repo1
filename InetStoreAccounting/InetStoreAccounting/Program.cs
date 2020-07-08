using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

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

            List<Phone> phones = new List<Phone>();
            phones.Add(new Phone("f123", "0sucks", 1, 100501.01m));
            phones.Add(new Phone("f124", "1sucks", 10, 100502.01m));
            phones.Add(new Phone("f125", "2sucks", 100, 100503.01m));
            phones.Add(new Phone("f126", "3sucks", 1000, 100504.01m));

            foreach (var phone in phones)
            {
                Console.WriteLine($"Phone ID:\t\t{phone.ID}");
                Console.WriteLine($"Phone moder:\t\t{phone.Name}");
                Console.WriteLine($"Amount of phone(s):\t{phone.Amount}");
                Console.WriteLine($"Price $:\t\t{phone.Price}");
                Console.WriteLine($"Total price $:\t\t{phone.Price * phone.Amount}");
                Console.WriteLine();
            }
            
            Console.WriteLine($"Car IDr:\t\t{car.ID}");
            Console.WriteLine($"Car moder:\t\t{car.Name}");
            Console.WriteLine($"Year of production:\t{car.ProductionYear}");
            Console.WriteLine($"Amount of car(s):\t{car.Amount}");
            Console.WriteLine($"Price $:\t\t{car.Price}");
            Console.ReadKey();
        }
    }
}
