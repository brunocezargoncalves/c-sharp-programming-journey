using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.ClassesAndMethods
{
    class Constructor
    {
        class Car
        {
            public string Model;
            public string Maker;
            public int Year;

            // Construtor padrão
            public Car()
            {

            }

            // Construtor personalizado
            public Car(string model, string maker, int year)
            {
                Model = model;
                Maker = maker;
                Year = year;
            }
        }

        public static void Execute()
        {
            // Usando o construtor padrão
            var car1 = new Car();
            car1.Model = "Ka";
            car1.Maker = "Ford";
            car1.Year = 2020;
            Console.WriteLine($"{car1.Model} - {car1.Maker} - {car1.Year}");

            // Usando o construtor personalizado
            var car2 = new Car("325i", "BMW", 2017);
            Console.WriteLine($"{car2.Model} - {car2.Maker} - {car2.Year}");

            // Usando o construtor padrão de outra forma
            var car3 = new Car()
            {
                Model = "Uno",
                Maker = "Fiat",
                Year = 2018
            };
            Console.WriteLine($"{car3.Model} - {car3.Maker} - {car3.Year}");
        }
    }
}
