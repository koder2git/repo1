using System;
using System.Collections.Generic;
using System.Text;

namespace InetStoreAccounting
{
    class Things
    {
        public string ID { get; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
    }

    class Phone : Things
    {
     
    }

    class Computer : Things
    {
        public string Description { get; set; }
    }

    class Clothes : Things
    {
        public string Size { get; set; }
    }

    class Car : Things
    {
        public int ProductionYear { get; set; }
    }
}
