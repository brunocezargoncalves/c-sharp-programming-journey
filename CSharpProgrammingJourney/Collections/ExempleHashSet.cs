using System;
using System.Collections.Generic;
using static CSharpProgrammingJourney.Collections.ExempleList;

namespace CSharpProgrammingJourney.Collections
{
    class ExempleHashSet
    {
        public static void Execute()
        {
            var book = new Product("Game of Throne", 49.9);

            // HashSet é uma estrutura genérica (aceita diferentes formatos de dados)
            // HashSet é uma estrutura homogênea - só aceita um determinado tipo de dado
            // HashSet não é uma estrutura indexada - acessamos os itens pelo indice
            // HashSet não aceita duplicação
            var bag = new HashSet<Product>();
            bag.Add(book);

            var combo = new HashSet<Product>()
            {
                new Product("Camisa", 29.9),
                new Product("Caneca", 12.9),
                new Product("Poster", 19.9)
            };

            bag.UnionWith(combo);
            Console.WriteLine(bag.Count);
            //bag.RemoveAt(3);

            foreach (var item in bag)
            {
                //Console.WriteLine(bag.IndexOf(item));
                Console.WriteLine($" {item.Name}");
            }
        }
    }
}
