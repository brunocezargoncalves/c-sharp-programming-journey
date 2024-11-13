using System;

namespace CSharpProgrammingJourney.Collections
{
    class ExempleArray
    {
        public static void Execute()
        {
            // Array é uma estrutura homogenea (não posso misturar valore de diferentes tipos)
            // Array é estático - não pode alterar o número de itens
            // Array é uma estrutura indexada
            string[] names = new string[5];
            names[0] = "Bruno";
            names[1] = "Amanda";
            names[1] = "Arthur";
            names[1] = "Ruby";
            names[1] = "Pandora";

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            string[] pets = { "Ruby", "Pandora" };

            foreach (var pet in pets)
            {
                Console.WriteLine(pet);
            }
        }
    }
}
