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

            Guid newGuid = Guid.NewGuid();

            stor.AddItem(new Car(newGuid, "shit-car0", 1, 100500.00m, 1982));
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


            Item obj1 = new Car(newGuid, "shit-car0", 1, 100500.00m, 1982);
            Item obj2 = new Car(newGuid, "shit-car1", 1, 100500.00m, 1982);
            Item obj3 = new Car(Guid.NewGuid(), "shit-car0", 1, 100500.00m, 1982);


            Console.WriteLine(obj1.Equals(obj2));
            Console.ReadKey();

            stor.RemoveItemByGuid(newGuid);

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
        }
    }
}
