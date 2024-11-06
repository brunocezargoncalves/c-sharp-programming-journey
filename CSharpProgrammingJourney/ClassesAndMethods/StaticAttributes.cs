using System;

namespace CSharpProgrammingJourney.ClassesAndMethods
{
    public class Product
    {
        public string Name;
        public double Price;
        public double Discount = 0.1;

        // O preço do desconto deixa de ser da instância e passa a ser classe - esse valor passa a ser compartilhado
        // public static double Discount = 0.1;

        public Product(string name, double price, double discount)
        {
            Name = name;
            Price = price;
            Discount = discount;
        }

        public Product()
        {

        }

        public double CalculateDiscount()
        {
            return Price - Price * Discount;
        }
    }

    class StaticAttributes
    {
        public static void Execute()
        {
            var product1 = new Product("Caneta", 3.2, 0.1);

            var product2 = new Product()
            {
                Name = "Borracha",
                Price = 5.3,
                Discount = 0.5
            };

            Console.WriteLine("{0} - Preço com desconto: {1}", product1.Name, product1.CalculateDiscount());
            Console.WriteLine("{0} - Preço com desconto: {1}", product2.Name, product2.CalculateDiscount());
        }
    }
}
