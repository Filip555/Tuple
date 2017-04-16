using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars cars = new Cars();
            var model = cars.GetTheCars();
            foreach (var item in model.Item2)
            {
                Console.WriteLine($"{item.Name} {item.Model} is a {model.Item1}");
            }
            Console.ReadKey();
        }
    }
}
