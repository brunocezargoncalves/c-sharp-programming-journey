using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.Fundamentals
{
    class StringInterpolation
    {
        public static void Execute()
        {
            string product = "Notebook Gamer";
            string brand = "Dell";
            double price = 5800.00;

            Console.WriteLine("O " + product + " da marca " + brand + " custa " + price + ".");
            Console.WriteLine("O {0} da marca {1} custa {2}.", product, brand, price);
            Console.WriteLine($"O {product} da marca {brand} custa {price}.");
        }
    }
}
