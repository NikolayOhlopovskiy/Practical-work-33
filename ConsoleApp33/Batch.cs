using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Batch : Product
    {
        public int Quantity { get; set; }

        public Batch(string name, int price, int quantity, DateTime manufactureDate, int shelfLife)
            : base(name, price, manufactureDate, shelfLife)
        {
            Quantity = quantity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}\nЦена: {Price}\nКоличество: {Quantity}\nДата производства: {ManufactureDate:dd.MM.yyyy}\nСрок годности: {ShelfLife}\n");
        }
    }

}
