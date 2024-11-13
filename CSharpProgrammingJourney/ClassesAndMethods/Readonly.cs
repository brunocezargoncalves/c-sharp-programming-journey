using System;

namespace CSharpProgrammingJourney.ClassesAndMethods
{
    public class Pet
    {
        public string Name;
        // Diferente do "const", o "readonly" não precisa de um valor definido na compilação, seu valor é definido na execução - na criação do objeto, e depois disso não poderá ser alterado
        readonly DateTime Birthdate;

        public Pet(string name, DateTime birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string GetBirthdate()
        {
            return String.Format("{0}/{1}/{2}", Birthdate.Day, Birthdate.Month, Birthdate.Year);
        }
    }

    class Readonly
    {
        public static void Execute()
        {
            var newPet = new Pet("Pandora", new DateTime(2023, 12, 28));

            Console.WriteLine(newPet.Name);
            Console.WriteLine(newPet.GetBirthdate());
        }
    }
}
