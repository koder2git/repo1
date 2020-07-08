using System;

namespace InetStoreAccounting
{
    public abstract class Things
    {
        public string ID { get; private set; }
        public string Name { get; private set; }
        public int Amount { get; private set; }
        public decimal Price { get; private set; }

        public Things(string id, string name, int amount, decimal price)
        {
            if (String.IsNullOrWhiteSpace(id)) throw new ArgumentException("The id is required.");
            ID = id;
            if (String.IsNullOrWhiteSpace(name)) throw new ArgumentException("The name is required.");
            Name = name;
            if (amount <= 0) throw new ArgumentOutOfRangeException("The number of things cannot be zero or negative.");
            Amount = amount;
            if (amount <= 0) throw new ArgumentOutOfRangeException("The priceS cannot be zero or negative.");
            Price = price;
        }
    }

    public class Phone : Things
    {
        public Phone(string id, string name, int amount, decimal price) : base(id, name, amount, price) { }
    }

    class Computer : Things
    {
        public string Description { get; private set; }
        public Computer(string id, string name, int amount, decimal price, string description) : base(id, name, amount, price)
        {
            Description = description;
        }
    }

    class Clothes : Things
    {
        public string Size { get; private set; }
        public Clothes(string id, string name, int amount, decimal price, string size) : base(id, name, amount, price)
        {
            Size = size;
        }
    }

    class Car : Things
    {
        public int ProductionYear { get; private set; }
        public Car(string id, string name, int amount, decimal price, int productionYear) : base(id, name, amount, price)
        {
            ProductionYear = productionYear;
        }
    }
}
