using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Kit : Tovar
    {
        public List<string> Products { get; set; }

        public Kit(string name, int price, List<string> products)
            : base(name, price)
        {
            Products = products;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}\nЦена: {Price}\nПродукты:");
            foreach (var product in Products)
            {
                Console.WriteLine($" - {product}");
            }
            Console.WriteLine();
        }

        public override bool IsExpired()
        {
            return false; // Комплекты не имеют срока годности
        }
    }
}
