using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace InetStoreAccounting
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage stor = new Storage();
            stor.AddItem(new Car(Guid.NewGuid(), "shit-car0", 1, 100500.00m, 1982));
            stor.AddItem(new Car(Guid.NewGuid(), "shit-car1", 1, 100500.00m, 1982));
            stor.AddItem(new Car(Guid.NewGuid(), "shit-car2", 1, 100500.00m, 1982));
            stor.AddItem(new Car(Guid.NewGuid(), "shit-car3", 1, 100500.00m, 1982));
            stor.AddItem(new Car(Guid.NewGuid(), "shit-car4", 1, 100500.00m, 1982));
            stor.AddItem(new Phone(Guid.NewGuid(), "shit phone #1", 10, 100500.00m));
            stor.AddItem(new Phone(Guid.NewGuid(), "shit phone #2", 10, 100500.00m));
            stor.AddItem(new Phone(Guid.NewGuid(), "shit phone #3", 10, 100500.00m));
            stor.AddItem(new Computer(Guid.NewGuid(), "shit_comp !", 99, 100500.00m, "PC"));
            stor.AddItem(new Computer(Guid.NewGuid(), "shit_comp @", 99, 100500.00m, "PC"));
            stor.AddItem(new Computer(Guid.NewGuid(), "shit_comp #", 99, 100500.00m, "PC"));
            stor.AddItem(new Computer(Guid.NewGuid(), "shit_comp $", 99, 100500.00m, "PC"));

            IEnumerable query = from item in stor.GetItemByType(typeof(Car)) where item.Name  == "shit-car2" select item;
            foreach (Car item in query)
            {
                Console.WriteLine(item.ID);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.ProductionYear);
                Console.WriteLine(item.Amount);
                Console.WriteLine(item.Price);
                Console.WriteLine();
                Console.ReadKey();
            }

            foreach (var item in stor.GetItemByType(typeof(Car)))
            {
                item.Print();
                Console.WriteLine();
                Console.ReadKey();
            }

            foreach (var item in stor.GetItemByType(typeof(Computer)))
            {
                item.Print();
                Console.WriteLine();
                Console.ReadKey();
            }
            
            foreach (var item in stor.GetItemByType(typeof(Phone)))
            {
                item.Print();
                Console.WriteLine();
                Console.ReadKey();
            }

            //stor.AddItem("Phone", "shit", 1, 100500.00m);
            //stor.PrintDic();

            //Dictionary<Guid, dynamic> dict = new Dictionary<Guid, dynamic>();

            //dict.Add(Guid.NewGuid(), new Phone(Guid.NewGuid(), "0sucks", 1, 100501.01m));
            //dict.Add(Guid.NewGuid(), new Phone(Guid.NewGuid(), "1sucks", 1, 100501.01m));
            //dict.Add(Guid.NewGuid(), new Car(Guid.NewGuid(), "shit", 1, 100500.00m, 1982));
            //dict.Add(Guid.NewGuid(), new Phone(Guid.NewGuid(), "2sucks", 1, 100501.01m));
            //dict.Add(Guid.NewGuid(), new Phone(Guid.NewGuid(), "3sucks", 1, 100501.01m));

            //foreach (KeyValuePair<Guid, dynamic> pair in dict)
            //{
            //    Console.WriteLine(pair.Key);
            //    Console.WriteLine(pair.Value.GetType().Name);
            //}

            //var query = from item in dict where item.Value.GetType().Name == "Car" select item;
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Value.Name);
            //}
            //Console.ReadKey();

            //Car car = new Car(Guid.NewGuid(), "shit", 1, 100500.00m, 1982);

            //List<Phone> phones = new List<Phone>();
            //phones.Add(new Phone(Guid.NewGuid(), "0sucks", 1, 100501.01m));
            //phones.Add(new Phone(Guid.NewGuid(), "1sucks", 10, 100502.01m));
            //phones.Add(new Phone(Guid.NewGuid(), "2sucks", 100, 100503.01m));
            //phones.Add(new Phone(Guid.NewGuid(), "3sucks", 1000, 100504.01m));

            //foreach (var phone in phones)
            //{
            //    Console.WriteLine($"Phone ID:\t\t{phone.ID}");
            //    Console.WriteLine($"Phone moder:\t\t{phone.Name}");
            //    Console.WriteLine($"Amount of phone(s):\t{phone.Amount}");
            //    Console.WriteLine($"Price $:\t\t{phone.Price}");
            //    Console.WriteLine($"Total price $:\t\t{phone.Price * phone.Amount}");
            //    Console.WriteLine();
            //}

            //Console.WriteLine($"Car IDr:\t\t{car.ID}");
            //Console.WriteLine($"Car moder:\t\t{car.Name}");
            //Console.WriteLine($"Year of production:\t{car.ProductionYear}");
            //Console.WriteLine($"Amount of car(s):\t{car.Amount}");
            //Console.WriteLine($"Price $:\t\t{car.Price}");
            //Console.ReadKey();
        }
    }
}
