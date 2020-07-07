using System;
using System.Collections.Generic;
using System.Text;

namespace InetStoreAccounting
{
    class Things
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

        public void Phone(string name, int amount, decimal price)
        {
            Name = name;
            Amount = amount;
            Price = price;
        }

        public void Computer(string name, int amount, decimal price)
        {
            Name = name;
            Amount = amount;
            Price = price;
        }

        public void Clothes(string name, int amount, decimal price)
        {
            Name = name;
            Amount = amount;
            Price = price;
        }

        public void Car(string name, int amount, decimal price)
        {
            Name = name;
            Amount = amount;
            Price = price;
        }
    }
}
