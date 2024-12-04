using System;
using System.Collections.Generic;

namespace CSharpProgrammingJourney.OO
{
    public abstract class Cellphone
    {
        public abstract string Assistant();

        public string Call()
        {
            return "Trim trim trim...";
        }
    }

    public class Samsung : Cellphone
    {
        public override string Assistant()
        {
            return "Olá! Meu nome é Bixby!";
        }
    }

    public class IPhone : Cellphone
    {
        public override string Assistant()
        {
            return "Olá! Meu nome é Siri!";
        }
    }

    // Classe concreta possue os membros definidos
    // Classe abstrata para definir conceitos - por natureza está inacabada, pode ou não ter métodos abstratos, por exemplo
    class Abstract
    {
        public static void Execute()
        {
            var cellphones = new List<Cellphone>()
            {
                new IPhone(),
                new Samsung(),
            };

            foreach (var cellphone in cellphones)
            {
                Console.WriteLine(cellphone.Assistant());
            }
        }
    }
}
