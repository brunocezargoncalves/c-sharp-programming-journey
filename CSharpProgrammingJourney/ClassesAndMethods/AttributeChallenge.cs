using System;

namespace CSharpProgrammingJourney.ClassesAndMethods
{
    class AttributeChallenge
    {
        int a = 10;

        public static void Execute()
        {
            // Acessar o valor de um atributo da classe
            AttributeChallenge challenge = new AttributeChallenge();
            Console.WriteLine(challenge.a);
        }
    }
}
