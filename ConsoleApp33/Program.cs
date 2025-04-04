using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tovar> store = new List<Tovar>
            {
            new Product("Молоко", 100, new DateTime(2024, 2, 14), 7),
            new Batch("Яблоки", 200, 10, new DateTime(2024, 2, 9), 30),
            new Kit("Подарочный набор", 500, new List<string>{"Шоколад", "Печенье"})
           };

            foreach (var item in store)
            {
                item.DisplayInfo();
            }

            Console.WriteLine("Просроченный товар:");
            foreach (var item in store)
            {
                if (item.IsExpired())
                {
                    Console.WriteLine(item.Name);
                }
            }
            Console.ReadKey();
        }
    }
}
