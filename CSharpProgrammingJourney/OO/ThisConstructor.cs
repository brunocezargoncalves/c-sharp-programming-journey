
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.OO
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
    }

    public class Dog : Animal
    {
        public double Height { get; set; }

        public Dog(string name) : base(name)
        {
            Console.WriteLine($"Cachorro {name} inicializado");
        }

        public Dog(string name, double height) : this(name)
        {
            Height = height;
        }

        public override string ToString()
        {
            return $"{Name} tem {Height}cm de altura";
        }
    }

    class ThisConstructor
    {
        public static void Execute()
        {
            var spike = new Dog("Spike");
            var max = new Dog("Max", 40.0);

            Console.WriteLine(spike);
            Console.WriteLine(max);
        }
    }
}
