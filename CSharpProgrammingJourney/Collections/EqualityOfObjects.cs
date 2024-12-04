using System;

namespace CSharpProgrammingJourney.Collections
{
    // Para comparar elementos iguais em coleções
    class EqualityOfObjects
    {
        public static void Execute()
        {
            var p1 = new Product("Caneta", 1.89);
            var p2 = new Product("Caneta", 1.89);
            var p3 = new Product();
            p2 = p3;

            // São falsos por que comparam referências/endereço de memória
            Console.WriteLine(p1 == p2);

            // É verdadeiro porque aponta para o mesmo endereço de memória
            Console.WriteLine(p2 == p3);

        }
    }
}
