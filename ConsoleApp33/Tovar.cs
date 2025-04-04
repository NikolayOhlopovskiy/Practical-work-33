using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    abstract class Tovar
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Tovar(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public abstract void DisplayInfo();
        public abstract bool IsExpired();
    }

}
