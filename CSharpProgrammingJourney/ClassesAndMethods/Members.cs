using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.ClassesAndMethods
{
    class Members
    {
        public static void Execute()
        {
            Person person = new Person();
            person.Name = "Bruno";
            person.Age = 36;

            //Console.WriteLine($"{person.Name} tem {person.Age} anos.");

            person.ShowConsole();

            var otherPerson = new Person();
            otherPerson.Name = "João";
            otherPerson.Age = 33;

            var greet = otherPerson.Greet();
            Console.WriteLine(greet);
        }
    }
}
