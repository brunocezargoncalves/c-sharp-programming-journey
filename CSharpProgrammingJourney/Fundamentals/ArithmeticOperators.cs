using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.Fundamentals
{
    class ArithmeticOperators
    {
        public static void Execute()
        {
            // Preço com desconto
            var price = 1000.0;
            var tax = 355;
            var discount = 0.1;

            double total = price + tax;
            var totalWithDiscound = total - (total * discount);
            Console.WriteLine("O valor do produto com desconto é {0}", totalWithDiscound);

            // IMC
            double weight = 93.4;
            double height = 1.83;
            double imc = weight / Math.Pow(height, 2);
            Console.WriteLine("O IMC da pessoa com peso {0} e altura {1} é {2}", weight, height, imc);

            // Número par
            int even = 24;
            int odd = 55;
            Console.WriteLine("{0}/2 têm resto {1}", even, even % 2);
            Console.WriteLine("{0}/2 têm resto {1}", odd, odd % 2);
        }
    }
}
