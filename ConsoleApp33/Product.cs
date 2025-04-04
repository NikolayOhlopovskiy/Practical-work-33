using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Product : Tovar
    {
        public DateTime ManufactureDate { get; set; }
        public int ShelfLife { get; set; } // срок годности в днях

        public Product(string name, int price, DateTime manufactureDate, int shelfLife)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
            ShelfLife = shelfLife;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}\nЦена: {Price}\nДата производства: {ManufactureDate:dd.MM.yyyy}\nСрок годности: {ShelfLife}\n");
        }

        public override bool IsExpired()
        {
            return ManufactureDate.AddDays(ShelfLife) < DateTime.Today;
        }
    }

}
