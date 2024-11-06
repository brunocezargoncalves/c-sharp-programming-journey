using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.ClassesAndMethods
{
    class Person
    {
        public string Name;
        public int Age;

        public string Greet()
        {
            return string.Format($"Olá! Meu nome é {Name} e eu tenho {Age} anos.");
        }

        public void ShowConsole()
        {
            Console.WriteLine(Greet());
        }
    }
}
