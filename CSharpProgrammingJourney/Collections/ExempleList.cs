using CSharpProgrammingJourney.ClassesAndMethods;
using System;
using System.Collections.Generic;

namespace CSharpProgrammingJourney.Collections
{
    public class Product
    {
        public string Name;
        public double Price;

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Product product = (Product)obj;
            return Name == product.Name && Price == product.Price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }
    }

    class ExempleList
    {      
        public static void Execute()
        {
            var book = new Product("Game of Throne", 49.9);

            // List é uma estrutura genérica (aceita diferentes formatos de dados)
            // List é uma estrutura homogênea - só aceita um determinado tipo de dado
            // List é uma estrutura indexada - acessamos os itens pelo indice
            var bag = new List<Product>();
            bag.Add(book);

            var combo = new List<Product>()
            {
                new Product("Camisa", 29.9),
                new Product("Caneca", 12.9),
                new Product("Poster", 19.9)
            };

            bag.AddRange(combo);
            Console.WriteLine(bag.Count);
            bag.RemoveAt(3);

            foreach (var item in bag)
            {
                Console.WriteLine(bag.IndexOf(item));
                Console.WriteLine($" {item.Name}");
            }
        }
    }
}
