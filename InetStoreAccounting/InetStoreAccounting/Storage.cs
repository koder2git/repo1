using System;
using System.Linq;
using System.Collections.Generic;

namespace InetStoreAccounting
{
    class Storage
    {
        Dictionary<int, dynamic> dict = new Dictionary<int, dynamic>();
        
        int i = 0;

        public void AddItem(string itemType, string name, int amount, decimal price)
        {
            switch (itemType)
            {
                case "Phone":
                    dict.Add(i++, new Phone(Guid.NewGuid(), name, amount, 100501.01m));
                    break;
            }
        }

        public void AddItem(Car car)
        {
            dict.Add(i++, car);
        }

        public void RemoveItem(Guid id)
        {

        }

        public List<dynamic> GetItem()
        {
            List<dynamic> list = new List<dynamic>();
            return list;
        }

        public void PrintDic()
        {
            var query = from item in dict where item.Value.GetType().Name == "Car" select item;
            foreach (var item in query)
            {
                Console.WriteLine($"Car IDr:\t\t{item.Value.ID}");
                Console.WriteLine($"Car moder:\t\t{item.Value.Name}");
                Console.WriteLine($"Year of production:\t{item.Value.ProductionYear}");
                Console.WriteLine($"Amount of car(s):\t{item.Value.Amount}");
                Console.WriteLine($"Price $:\t\t{item.Value.Price}");
            }
            Console.WriteLine();
            var query1 = from item in dict where item.Value.GetType().Name == "Phone" select item;
            foreach (var item in query1)
            {
                Console.WriteLine($"Phone ID:\t\t{item.Value.ID}");
                Console.WriteLine($"Phone moder:\t\t{item.Value.Name}");
                Console.WriteLine($"Amount of phone(s):\t{item.Value.Amount}");
                Console.WriteLine($"Price $:\t\t{item.Value.Price}");
                Console.WriteLine($"Total price $:\t\t{item.Value.Price * item.Value.Amount}");

            }
            Console.ReadKey();
        }
    }
}
