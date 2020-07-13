using System;

namespace InetStoreAccounting
{
    public abstract class Item
    {
        public Guid ID { get; private set; }
        public string Name { get; private set; }
        public int Amount { get; private set; }
        public decimal Price { get; private set; }

        public Item(Guid id, string name, int amount, decimal price)
        {
            ID = id;
            if (String.IsNullOrWhiteSpace(name)) throw new ArgumentException("The name is required.");
            Name = name;
            if (amount <= 0) throw new ArgumentOutOfRangeException("The number of things cannot be zero or negative.");
            Amount = amount;
            if (price <= 0) throw new ArgumentOutOfRangeException("The price cannot be zero or negative.");
            Price = price;
        }

        public virtual void Print()
        {
            Console.WriteLine($"ID:\t\t\t{ID}");
            Console.WriteLine($"Name:\t\t\t{Name}");
            Console.WriteLine($"Amount:\t\t\t{Amount}");
            Console.WriteLine($"Price $:\t\t{Price}");
            Console.WriteLine($"Total price $:\t\t{Price * Amount}");
        }
    }

    public class Phone : Item
    {
        public Phone(Guid id, string name, int amount, decimal price) : base(id, name, amount, price) { }
    }

    public class Computer : Item
    {
        public string Description { get; private set; }
        public Computer(Guid id, string name, int amount, decimal price, string description) : base(id, name, amount, price)
        {
            Description = description;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Description:\t\t{Description}");
        }
    }

    class Clothes : Item
    {
        public string Size { get; private set; }
        public Clothes(Guid id, string name, int amount, decimal price, string size) : base(id, name, amount, price)
        {
            Size = size;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Size:\t\t{Size}");
        }
    }

    class Car : Item
    {
        public int ProductionYear { get; private set; }
        public Car(Guid id, string name, int amount, decimal price, int productionYear) : base(id, name, amount, price)
        {
            ProductionYear = productionYear;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Year of producton:\t{ProductionYear}");
        }
    }
}
